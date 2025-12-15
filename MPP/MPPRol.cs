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
    public class MPPRol
    {
        private readonly string rutaRoles;
        private readonly string rutaColaboradores;

        public MPPRol()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            rutaRoles = Path.Combine(basePath, "Roles.xml");
            rutaColaboradores = Path.Combine(basePath, "Colaboradores.xml");
        }


        public bool AgregarRol(BERol oRol)
        {
            XDocument doc = XDocument.Load(rutaRoles);

            int nuevoId = 1;
            var roles = doc.Descendants("Rol");
            if (roles.Any())
            {
                nuevoId = roles.Max(x => (int)x.Attribute("Id")) + 1;
            }

            doc.Element("Roles").Add(
                new XElement("Rol",
                    new XAttribute("Id", nuevoId),
                    new XElement("Nombre", oRol.Nombre),
                    new XElement("Descripcion", oRol.Descripcion),
                    new XElement("Categoria", oRol.Categoria)
                )
            );

            doc.Save(rutaRoles);
            return true;
        }


        public bool ModificarRol(BERol oRol)
        {
            XDocument doc = XDocument.Load(rutaRoles);

            var vRol = doc.Descendants("Rol")
                          .FirstOrDefault(x => (int)x.Attribute("Id") == oRol.Id);

            vRol.Element("Nombre").Value = oRol.Nombre;
            vRol.Element("Descripcion").Value = oRol.Descripcion;
            vRol.Element("Categoria").Value = oRol.Categoria.ToString();

            doc.Save(rutaRoles);
            return true;
        }


        public bool EliminarRol(BERol oRol)
        {
            XDocument doc = XDocument.Load(rutaRoles);

            var vRol = doc.Descendants("Rol")
                          .FirstOrDefault(x => (int)x.Attribute("Id") == oRol.Id);

            vRol.Remove();
            doc.Save(rutaRoles);

            return true;
        }


        public bool VerificarPresenciaColaborador(BERol oRol)
        {
            XDocument doc = XDocument.Load(rutaColaboradores);

            return doc.Descendants("Colaborador")
                      .Any(x => (int)x.Element("RolId") == oRol.Id);
        }


        public List<BERol> ListarRoles()
        {
            XDocument doc = XDocument.Load(rutaRoles);

            var listaRoles =
                from rol in doc.Descendants("Rol")
                select new BERol
                {
                    Id = int.Parse(rol.Attribute("Id").Value),
                    Nombre = rol.Element("Nombre").Value,
                    Descripcion = rol.Element("Descripcion").Value,
                    Categoria = (BEECategoria)Enum.Parse(typeof(BEECategoria),
                                                         rol.Element("Categoria").Value)
                };

            return listaRoles.ToList();
        }
    }

}
