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
    public class MPPColaborador
    {
        private readonly string rutaColaboradores;
        private readonly string rutaAsignacionesColPro;
        private readonly string rutaRoles;

        public MPPColaborador()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            rutaColaboradores = Path.Combine(basePath, "Colaboradores.xml");
            rutaAsignacionesColPro = Path.Combine(basePath, "AsignacionesColPro.xml");
            rutaRoles = Path.Combine(basePath, "Roles.xml");
        }


        public bool AgregarColaborador(BEColaborador oColaborador)
        {
            XDocument doc = XDocument.Load(rutaColaboradores);

            int nuevoId = 1;
            var colaboradores = doc.Descendants("Colaborador");
            if (colaboradores.Any())
            {
                nuevoId = colaboradores.Max(x => (int)x.Attribute("Id")) + 1;
            }

            doc.Element("Colaboradores").Add(
                new XElement("Colaborador",
                    new XAttribute("Id", nuevoId),
                    new XElement("Nombre", oColaborador.Nombre),
                    new XElement("Apellido", oColaborador.Apellido),
                    new XElement("DNI", oColaborador.Dni),
                    new XElement("Email", oColaborador.Email),
                    new XElement("Telefono", oColaborador.Telefono),
                    new XElement("Seniority", oColaborador.Seniority),
                    new XElement("RolId", oColaborador.Rol.Id)
                )
            );

            doc.Save(rutaColaboradores);

            return true;
        }


        public bool ModificarColaborador(BEColaborador oColaborador)
        {
            XDocument doc = XDocument.Load(rutaColaboradores);

            var vColaborador = doc.Descendants("Colaborador")
                                  .FirstOrDefault(x => (int)x.Attribute("Id") == oColaborador.Id);

            vColaborador.Element("Nombre").Value = oColaborador.Nombre;
            vColaborador.Element("Apellido").Value = oColaborador.Apellido;
            vColaborador.Element("DNI").Value = oColaborador.Dni;
            vColaborador.Element("Email").Value = oColaborador.Email;
            vColaborador.Element("Telefono").Value = oColaborador.Telefono;
            vColaborador.Element("Seniority").Value = oColaborador.Seniority.ToString();
            vColaborador.Element("RolId").Value = oColaborador.Rol.Id.ToString();

            doc.Save(rutaColaboradores);
            return true;
        }


        public bool EliminarColaborador(BEColaborador oColaborador)
        {
            XDocument doc = XDocument.Load(rutaColaboradores);

            var vColaborador = doc.Descendants("Colaborador")
                                  .FirstOrDefault(x => (int)x.Attribute("Id") == oColaborador.Id);

            vColaborador.Remove();
            doc.Save(rutaColaboradores);

            return true;
        }


        public bool VerificarPresenciaProyecto(BEColaborador oColaborador)
        {
            XDocument doc = XDocument.Load(rutaAsignacionesColPro);

            bool concidencia = doc.Descendants("Asignacion")
                    .Any(x => (int)x.Element("ColaboradorId") == oColaborador.Id);

            return concidencia;
        }


        public List<BEColaborador> ListarColaboradores()
        {
            XDocument colaboradoresXml = XDocument.Load(rutaColaboradores);
            XDocument rolesXml = XDocument.Load(rutaRoles);

            var listaColaboradores = from colaborador in colaboradoresXml.Descendants("Colaborador")
                                     select new BEColaborador
                                     {
                                         Id = int.Parse(colaborador.Attribute("Id").Value),
                                         Nombre = colaborador.Element("Nombre").Value,
                                         Apellido = colaborador.Element("Apellido").Value,
                                         Dni = colaborador.Element("DNI").Value,
                                         Email = colaborador.Element("Email").Value,
                                         Telefono = colaborador.Element("Telefono").Value,
                                         Seniority = (BEESeniority)Enum.Parse(typeof(BEESeniority),
                                                                               colaborador.Element("Seniority").Value),

                                         Rol = (from rol in rolesXml.Descendants("Rol")
                                                where (int)rol.Attribute("Id") == (int)colaborador.Element("RolId")
                                                select new BERol
                                                {
                                                    Id = (int)rol.Attribute("Id"),
                                                    Nombre = rol.Element("Nombre").Value,
                                                    Descripcion = rol.Element("Descripcion").Value,
                                                    Categoria = (BEECategoria)Enum.Parse(typeof(BEECategoria),
                                                                                         rol.Element("Categoria").Value)
                                                }).FirstOrDefault()
                                     };

            return listaColaboradores.ToList();
        }


        public int ListarCantidadColaboradoresProyecto(int iNumProyectos, bool incluirMayores = false)
        {
            XDocument xmlAsignaciones = XDocument.Load(rutaAsignacionesColPro);
            XDocument xmlColaboradores = XDocument.Load(rutaColaboradores);

            var todosLosColaboradores = xmlColaboradores.Descendants("Colaborador")
                .Select(c => (int)c.Attribute("Id"))
                .ToList();

            var asignacionesPorColaborador = xmlAsignaciones.Descendants("Asignacion")
                .GroupBy(a => (int)a.Element("ColaboradorId"))
                .Select(g => new
                {
                    ColaboradorId = g.Key,
                    CantidadProyectos = g.Count()
                })
                .ToList();

            var colaboradoresSinAsignaciones = todosLosColaboradores
                .Where(id => !asignacionesPorColaborador.Any(a => a.ColaboradorId == id))
                .Select(id => new { ColaboradorId = id, CantidadProyectos = 0 })
                .ToList();

            var resumenTotal = asignacionesPorColaborador.Concat(colaboradoresSinAsignaciones);

            if (incluirMayores)
            {
                return resumenTotal.Count(x => x.CantidadProyectos >= iNumProyectos);
            }
            else
            {
                return resumenTotal.Count(x => x.CantidadProyectos == iNumProyectos);
            }
        }


        public int ListarCantidadProyectosColaborador(BEColaborador oColaborador)
        {
            XDocument doc = XDocument.Load(rutaAsignacionesColPro);

            int cantidad = doc.Descendants("Asignacion")
                              .Count(a => (int)a.Element("ColaboradorId") == oColaborador.Id);

            return cantidad;
        }
    }

}
