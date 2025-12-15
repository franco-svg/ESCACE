using BE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MPP
{
    public class MPPRolArq
    {
        private readonly string rutaRolesArq;
        private readonly string rutaAsignRolPer;
        private readonly string rutaAsignRolRol;
        private readonly string rutaAsignUsuRol;
        private readonly string rutaPermisos;

        public MPPRolArq()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            rutaRolesArq = Path.Combine(basePath, "RolesArq.xml");
            rutaAsignRolPer = Path.Combine(basePath, "AsignacionesRolPer.xml");
            rutaAsignRolRol = Path.Combine(basePath, "AsignacionesRolRol.xml");
            rutaAsignUsuRol = Path.Combine(basePath, "AsignacionesUsuRol.xml");
            rutaPermisos = Path.Combine(basePath, "Permisos.xml");
        }


        public bool AgregarRolArq(BERolArq oRolArq)
        {
            XDocument doc = XDocument.Load(rutaRolesArq);

            int nuevoId = 1;
            var roles = doc.Descendants("Rol");
            if (roles.Any())
                nuevoId = roles.Max(x => (int)x.Attribute("Id")) + 1;

            doc.Element("RolesArq").Add(
                new XElement("Rol",
                    new XAttribute("Id", nuevoId),
                    new XElement("Nombre", oRolArq.Nombre)
                )
            );

            doc.Save(rutaRolesArq);
            return true;
        }


        public bool ModificarRolArq(BERolArq oRolArq)
        {
            XDocument doc = XDocument.Load(rutaRolesArq);

            var vRol = doc.Descendants("Rol")
                          .FirstOrDefault(x => (int)x.Attribute("Id") == oRolArq.Id);

            vRol.Element("Nombre").Value = oRolArq.Nombre;

            doc.Save(rutaRolesArq);
            return true;
        }


        public bool EliminarRolArq(BERolArq oRolArq)
        {
            // 1️⃣ Eliminar en RolesArq.xml
            XDocument docR = XDocument.Load(rutaRolesArq);

            var vRol = docR.Descendants("Rol")
                           .FirstOrDefault(x => (int)x.Attribute("Id") == oRolArq.Id);

            if (vRol == null)
                throw new InvalidOperationException("No se encontró el rol a eliminar.");

            vRol.Remove();
            docR.Save(rutaRolesArq);


            // 2️⃣ Eliminar asignaciones Rol–Permiso
            XDocument docRP = XDocument.Load(rutaAsignRolPer);
            var asignPer = docRP.Descendants("Asignacion")
                                .Where(x => (int)x.Element("RolId") == oRolArq.Id)
                                .ToList();

            foreach (var asign in asignPer)
                asign.Remove();

            docRP.Save(rutaAsignRolPer);


            // 3️⃣ Eliminar asignaciones RolPadre–RolHijo
            XDocument docRR = XDocument.Load(rutaAsignRolRol);
            var asignRol = docRR.Descendants("Asignacion")
                                .Where(x => (int)x.Element("RolPadreId") == oRolArq.Id)
                                .ToList();

            foreach (var asign in asignRol)
                asign.Remove();

            docRR.Save(rutaAsignRolRol);

            return true;
        }


        public bool VerificarPresenciaUsuario(BERolArq oRolArq)
        {
            XDocument doc = XDocument.Load(rutaAsignUsuRol);

            return doc.Descendants("Asignacion")
                      .Any(x => (int)x.Element("RolId") == oRolArq.Id);
        }


        public bool VerificarPresenciaRol(BERolArq oRolArq)
        {
            XDocument doc = XDocument.Load(rutaAsignRolRol);

            return doc.Descendants("Asignacion")
                      .Any(x => (int)x.Element("RolHijoId") == oRolArq.Id);
        }


        public List<BERolArq> ListarRoles()
        {
            XDocument rolesXml = XDocument.Load(rutaRolesArq);
            XDocument asignRolRolXml = XDocument.Load(rutaAsignRolRol);
            XDocument asignRolPerXml = XDocument.Load(rutaAsignRolPer);
            XDocument permisosXml = XDocument.Load(rutaPermisos);

            var roles = (from rol in rolesXml.Descendants("Rol")
                         select new BERolArq
                         {
                             Id = (int)rol.Attribute("Id"),
                             Nombre = rol.Element("Nombre").Value
                         }).ToList();

            foreach (var rol in roles)
            {
                // -------- Roles Hijos --------
                var rolesHijosIds = asignRolRolXml.Descendants("Asignacion")
                        .Where(x => (int)x.Element("RolPadreId") == rol.Id)
                        .Select(x => (int)x.Element("RolHijoId"))
                        .ToList();

                foreach (var idHijo in rolesHijosIds)
                {
                    var rolHijo = roles.FirstOrDefault(r => r.Id == idHijo);
                    if (rolHijo != null)
                        rol.AgregarHijo(rolHijo);
                }

                // -------- Permisos --------
                var permisos = permisosXml.Descendants("Permiso")
                                          .Select(p => new BEPermiso
                                          {
                                              Id = (int)p.Attribute("Id"),
                                              Nombre = p.Element("Nombre").Value
                                          }).ToList();

                var permisosIds = asignRolPerXml.Descendants("Asignacion")
                                                .Where(x => (int)x.Element("RolId") == rol.Id)
                                                .Select(x => (int)x.Element("PermisoId"))
                                                .ToList();

                foreach (var idPerm in permisosIds)
                {
                    var permiso = permisos.FirstOrDefault(p => p.Id == idPerm);
                    if (permiso != null)
                        rol.AgregarHijo(permiso);
                }
            }

            return roles;
        }


        public bool AsignarRolPermiso(BERolArq oRol, BEPermiso oPermiso)
        {
            XDocument doc = XDocument.Load(rutaAsignRolPer);

            bool existe = doc.Descendants("Asignacion")
                             .Any(x => (int)x.Element("RolId") == oRol.Id &&
                                       (int)x.Element("PermisoId") == oPermiso.Id);

            if (existe)
                return false;

            doc.Element("AsignacionesRolPer").Add(
                new XElement("Asignacion",
                    new XElement("RolId", oRol.Id),
                    new XElement("PermisoId", oPermiso.Id)
                )
            );

            doc.Save(rutaAsignRolPer);
            return true;
        }


        public bool DesasignarRolPermiso(BERolArq oRol, BEPermiso oPermiso)
        {
            XDocument doc = XDocument.Load(rutaAsignRolPer);

            var asignacion = doc.Descendants("Asignacion")
                                .FirstOrDefault(x => (int)x.Element("RolId") == oRol.Id &&
                                                     (int)x.Element("PermisoId") == oPermiso.Id);

            if (asignacion == null)
                return false;

            asignacion.Remove();
            doc.Save(rutaAsignRolPer);
            return true;
        }


        public bool AsignarRolRol(BERolArq oRolPadre, BERolArq oRolHijo)
        {
            XDocument doc = XDocument.Load(rutaAsignRolRol);

            if (oRolPadre.Id == oRolHijo.Id)
                throw new InvalidOperationException("Un rol no puede asignarse a sí mismo.");

            bool existe = doc.Descendants("Asignacion")
                             .Any(x => (int)x.Element("RolPadreId") == oRolPadre.Id &&
                                       (int)x.Element("RolHijoId") == oRolHijo.Id);

            if (existe)
                return false;

            doc.Element("AsignacionesRolRol").Add(
                new XElement("Asignacion",
                    new XElement("RolPadreId", oRolPadre.Id),
                    new XElement("RolHijoId", oRolHijo.Id)
                )
            );

            doc.Save(rutaAsignRolRol);
            return true;
        }


        public bool DesasignarRolRol(BERolArq oRolPadre, BERolArq oRolHijo)
        {
            XDocument doc = XDocument.Load(rutaAsignRolRol);

            var asignacion = doc.Descendants("Asignacion")
                                .FirstOrDefault(x => (int)x.Element("RolPadreId") == oRolPadre.Id &&
                                                     (int)x.Element("RolHijoId") == oRolHijo.Id);

            if (asignacion == null)
                return false;

            asignacion.Remove();
            doc.Save(rutaAsignRolRol);
            return true;
        }
    }


}
