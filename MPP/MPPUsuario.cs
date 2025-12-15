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
    public class MPPUsuario
    {
        private readonly string rutaUsuarios;
        private readonly string rutaUsuRol;
        private readonly string rutaUsuPer;

        private readonly MPPRolArq mapperRolArq;
        private readonly MPPPermiso mapperPermiso;

        public MPPUsuario()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            rutaUsuarios = Path.Combine(basePath, "Usuarios.xml");
            rutaUsuRol   = Path.Combine(basePath, "AsignacionesUsuRol.xml");
            rutaUsuPer   = Path.Combine(basePath, "AsignacionesUsuPer.xml");

            mapperRolArq = new MPPRolArq();
            mapperPermiso = new MPPPermiso();
        }

        public bool AgregarUsuario(BEUsuario oUsuario)
        {
            XDocument doc = XDocument.Load(rutaUsuarios);

            int nuevoId = 1;
            var usuarios = doc.Descendants("Usuario");
            if (usuarios.Any())
                nuevoId = usuarios.Max(x => (int)x.Attribute("Id")) + 1;

            doc.Element("Usuarios").Add(
                new XElement("Usuario",
                    new XAttribute("Id", nuevoId),
                    new XElement("Username", oUsuario.Username),
                    new XElement("Password", oUsuario.Password),
                    new XElement("Activo", oUsuario.Activo)
                )
            );

            doc.Save(rutaUsuarios);
            return true;
        }

        public bool ModificarUsuario(BEUsuario oUsuario)
        {
            XDocument doc = XDocument.Load(rutaUsuarios);

            var vUsuario = doc.Descendants("Usuario")
                              .FirstOrDefault(x => (int)x.Attribute("Id") == oUsuario.Id);

            vUsuario.Element("Username").Value = oUsuario.Username;
            vUsuario.Element("Password").Value = oUsuario.Password;
            vUsuario.Element("Activo").Value = oUsuario.Activo.ToString();

            doc.Save(rutaUsuarios);
            return true;
        }

        public bool EliminarUsuario(BEUsuario oUsuario)
        {
            // marcar inactivo
            XDocument docU = XDocument.Load(rutaUsuarios);

            var vUsuario = docU.Descendants("Usuario")
                               .FirstOrDefault(x => (int)x.Attribute("Id") == oUsuario.Id);

            vUsuario.Element("Activo").Value = oUsuario.Activo.ToString();
            docU.Save(rutaUsuarios);

            // borrar asignaciones de roles
            XDocument docUR = XDocument.Load(rutaUsuRol);

            var asignacionesRol = docUR.Descendants("Asignacion")
                                       .Where(x => (int)x.Element("UsuarioId") == oUsuario.Id)
                                       .ToList();

            foreach (var asign in asignacionesRol)
                asign.Remove();

            docUR.Save(rutaUsuRol);

            // borrar asignaciones de permisos
            XDocument docUP = XDocument.Load(rutaUsuPer);

            var asignacionesPermiso = docUP.Descendants("Asignacion")
                                           .Where(x => (int)x.Element("UsuarioId") == oUsuario.Id)
                                           .ToList();

            foreach (var asign in asignacionesPermiso)
                asign.Remove();

            docUP.Save(rutaUsuPer);

            return true;
        }

        public List<BEUsuario> ListarUsuarios()
        {
            XDocument xmlUsuarios = XDocument.Load(rutaUsuarios);
            XDocument xmlUsuRol = XDocument.Load(rutaUsuRol);
            XDocument xmlUsuPer = XDocument.Load(rutaUsuPer);

            var roles = mapperRolArq.ListarRoles();
            var permisos = mapperPermiso.ListarPermisos();

            var listaUsuarios =
                from usuario in xmlUsuarios.Descendants("Usuario")
                let usuarioId = (int)usuario.Attribute("Id")
                select new BEUsuario
                {
                    Id = usuarioId,
                    Username = usuario.Element("Username")?.Value ?? "",
                    Password = usuario.Element("Password")?.Value ?? "",
                    Activo = int.Parse(usuario.Element("Activo").Value),

                    Roles = (from asign in xmlUsuRol.Descendants("Asignacion")
                             let userId = (int?)asign.Element("UsuarioId")
                             let rolId = (int?)asign.Element("RolId")
                             where userId == usuarioId
                             select roles.FirstOrDefault(r => r.Id == rolId))
                             .Where(r => r != null).ToList(),

                    PermisosDirectos = (from asign in xmlUsuPer.Descendants("Asignacion")
                                        let userId = (int?)asign.Element("UsuarioId")
                                        let permisoId = (int?)asign.Element("PermisoId")
                                        where userId == usuarioId
                                        select permisos.FirstOrDefault(p => p.Id == permisoId))
                                        .Where(p => p != null).ToList()
                };

            return listaUsuarios.ToList();
        }

        public List<BEUsuario> ListarUsuariosActivos()
        {
            XDocument xmlUsuarios = XDocument.Load(rutaUsuarios);
            XDocument xmlUsuRol = XDocument.Load(rutaUsuRol);
            XDocument xmlUsuPer = XDocument.Load(rutaUsuPer);

            var roles = mapperRolArq.ListarRoles();
            var permisos = mapperPermiso.ListarPermisos();

            var listaUsuarios =
                from usuario in xmlUsuarios.Descendants("Usuario")
                let usuarioId = (int)usuario.Attribute("Id")
                where usuario.Element("Activo").Value == "1"
                select new BEUsuario
                {
                    Id = usuarioId,
                    Username = usuario.Element("Username")?.Value ?? "",
                    Password = usuario.Element("Password")?.Value ?? "",
                    Activo = 1,

                    Roles = (from asign in xmlUsuRol.Descendants("Asignacion")
                             let userId = (int?)asign.Element("UsuarioId")
                             let rolId = (int?)asign.Element("RolId")
                             where userId == usuarioId
                             select roles.FirstOrDefault(r => r.Id == rolId))
                             .Where(r => r != null).ToList(),

                    PermisosDirectos = (from asign in xmlUsuPer.Descendants("Asignacion")
                                        let userId = (int?)asign.Element("UsuarioId")
                                        let permisoId = (int?)asign.Element("PermisoId")
                                        where userId == usuarioId
                                        select permisos.FirstOrDefault(p => p.Id == permisoId))
                                        .Where(p => p != null).ToList()
                };

            return listaUsuarios.ToList();
        }

        public bool AsignarUsuarioRol(BEUsuario oUsuario, BERolArq oRol)
        {
            XDocument doc = XDocument.Load(rutaUsuRol);

            bool existe = doc.Descendants("Asignacion")
                             .Any(x => (int)x.Element("UsuarioId") == oUsuario.Id &&
                                       (int)x.Element("RolId") == oRol.Id);

            if (existe) return false;

            doc.Element("AsignacionesUsuRol").Add(
                new XElement("Asignacion",
                    new XElement("UsuarioId", oUsuario.Id),
                    new XElement("RolId", oRol.Id)
                )
            );

            doc.Save(rutaUsuRol);
            return true;
        }

        public bool DesasignarUsuarioRol(BEUsuario oUsuario, BERolArq oRol)
        {
            XDocument doc = XDocument.Load(rutaUsuRol);

            var asignacion = doc.Descendants("Asignacion")
                                .FirstOrDefault(x => (int)x.Element("UsuarioId") == oUsuario.Id &&
                                                     (int)x.Element("RolId") == oRol.Id);

            if (asignacion == null) return false;

            asignacion.Remove();
            doc.Save(rutaUsuRol);
            return true;
        }

        public bool AsignarUsuarioPermiso(BEUsuario oUsuario, BEPermiso oPermiso)
        {
            XDocument doc = XDocument.Load(rutaUsuPer);

            bool existe = doc.Descendants("Asignacion")
                             .Any(x => (int)x.Element("UsuarioId") == oUsuario.Id &&
                                       (int)x.Element("PermisoId") == oPermiso.Id);

            if (existe) return false;

            doc.Element("AsignacionesUsuPer").Add(
                new XElement("Asignacion",
                    new XElement("UsuarioId", oUsuario.Id),
                    new XElement("PermisoId", oPermiso.Id)
                )
            );

            doc.Save(rutaUsuPer);
            return true;
        }

        public bool DesasignarUsuarioPermiso(BEUsuario oUsuario, BEPermiso oPermiso)
        {
            XDocument doc = XDocument.Load(rutaUsuPer);

            var asignacion = doc.Descendants("Asignacion")
                                .FirstOrDefault(x => (int)x.Element("UsuarioId") == oUsuario.Id &&
                                                     (int)x.Element("PermisoId") == oPermiso.Id);

            if (asignacion == null) return false;

            asignacion.Remove();
            doc.Save(rutaUsuPer);
            return true;
        }
    }

}
