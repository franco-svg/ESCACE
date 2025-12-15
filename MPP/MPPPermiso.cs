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
    public class MPPPermiso
    {
        private readonly string rutaPermisos;
        private readonly string rutaAsignacionesUsuPer;
        private readonly string rutaAsignacionesRolPer;

        public MPPPermiso()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            rutaPermisos = Path.Combine(basePath, "Permisos.xml");
            rutaAsignacionesUsuPer = Path.Combine(basePath, "AsignacionesUsuPer.xml");
            rutaAsignacionesRolPer = Path.Combine(basePath, "AsignacionesRolPer.xml");
        }


        public bool AgregarPermiso(BEPermiso oPermiso)
        {
            XDocument doc = XDocument.Load(rutaPermisos);

            int nuevoId = 1;
            var permisos = doc.Descendants("Permiso");
            if (permisos.Any())
            {
                nuevoId = permisos.Max(x => (int)x.Attribute("Id")) + 1;
            }

            doc.Element("Permisos").Add(
                new XElement("Permiso",
                    new XAttribute("Id", nuevoId),
                    new XElement("Nombre", oPermiso.Nombre)
                )
            );

            doc.Save(rutaPermisos);
            return true;
        }


        public bool EliminarPermiso(BEPermiso oPermiso)
        {
            XDocument doc = XDocument.Load(rutaPermisos);

            var vPermiso = doc.Descendants("Permiso")
                              .FirstOrDefault(x => (int)x.Attribute("Id") == oPermiso.Id);

            vPermiso.Remove();
            doc.Save(rutaPermisos);

            return true;
        }


        public bool VerificarPresenciaUsuario(BEPermiso oPermiso)
        {
            XDocument doc = XDocument.Load(rutaAsignacionesUsuPer);

            return doc.Descendants("Asignacion")
                      .Any(x => (int)x.Element("PermisoId") == oPermiso.Id);
        }


        public bool VerificarPresenciaRol(BEPermiso oPermiso)
        {
            XDocument doc = XDocument.Load(rutaAsignacionesRolPer);

            return doc.Descendants("Asignacion")
                      .Any(x => (int)x.Element("PermisoId") == oPermiso.Id);
        }


        public List<BEPermiso> ListarPermisos()
        {
            XDocument doc = XDocument.Load(rutaPermisos);

            var listaPermisos =
                from permiso in doc.Descendants("Permiso")
                select new BEPermiso
                {
                    Id = (int)permiso.Attribute("Id"),
                    Nombre = permiso.Element("Nombre").Value
                };

            return listaPermisos.ToList();
        }
    }

}
