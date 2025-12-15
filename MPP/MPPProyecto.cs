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
    public class MPPProyecto
    {
        private readonly string rutaProyectos;
        private readonly string rutaFases;
        private readonly string rutaTareas;
        private readonly string rutaHitos;
        private readonly string rutaAsignaciones;
        private readonly string rutaFichas;
        private readonly string rutaContratos;
        private readonly string rutaClientes;
        private readonly string rutaColaboradores;
        private readonly string rutaRoles;

        public MPPProyecto()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            rutaProyectos      = Path.Combine(basePath, "Proyectos.xml");
            rutaFases          = Path.Combine(basePath, "Fases.xml");
            rutaTareas         = Path.Combine(basePath, "Tareas.xml");
            rutaHitos          = Path.Combine(basePath, "Hitos.xml");
            rutaAsignaciones   = Path.Combine(basePath, "AsignacionesColPro.xml");
            rutaFichas         = Path.Combine(basePath, "FichasProyecto.xml");
            rutaContratos      = Path.Combine(basePath, "Contratos.xml");
            rutaClientes       = Path.Combine(basePath, "Clientes.xml");
            rutaColaboradores  = Path.Combine(basePath, "Colaboradores.xml");
            rutaRoles          = Path.Combine(basePath, "Roles.xml");
        }

        public bool AgregarProyecto(BEProyecto oProyecto)
        {
            XDocument doc = XDocument.Load(rutaProyectos);

            int nuevoId = 1;
            var proyectos = doc.Descendants("Proyecto");
            if (proyectos.Any())
                nuevoId = proyectos.Max(x => (int)x.Attribute("Id")) + 1;

            doc.Element("Proyectos").Add(
                new XElement("Proyecto",
                    new XAttribute("Id", nuevoId),
                    new XElement("Titulo", oProyecto.Titulo),
                    new XElement("Descripcion", oProyecto.Descripcion),
                    new XElement("HorasEstimadas", oProyecto.HorasEstimadas),
                    new XElement("HorasCompletadas", oProyecto.HorasCompletadas),
                    new XElement("HorasRestantes", oProyecto.HorasRestantes),
                    new XElement("Estado", oProyecto.Estado),
                    new XElement("FichaProyectoId", oProyecto.FichaProyecto.Id)
                )
            );

            doc.Save(rutaProyectos);
            return true;
        }

        public bool ModificarProyecto(BEProyecto oProyecto)
        {
            XDocument doc = XDocument.Load(rutaProyectos);

            var vProyecto = doc.Descendants("Proyecto")
                               .FirstOrDefault(x => (int)x.Attribute("Id") == oProyecto.Id);

            if (vProyecto == null)
                throw new InvalidOperationException("No se encontró el proyecto a modificar.");

            vProyecto.Element("Titulo").Value = oProyecto.Titulo;
            vProyecto.Element("Descripcion").Value = oProyecto.Descripcion;
            vProyecto.Element("HorasEstimadas").Value = oProyecto.HorasEstimadas.ToString();
            vProyecto.Element("HorasCompletadas").Value = oProyecto.HorasCompletadas.ToString();
            vProyecto.Element("HorasRestantes").Value = oProyecto.HorasRestantes.ToString();
            vProyecto.Element("Estado").Value = oProyecto.Estado.ToString();

            doc.Save(rutaProyectos);
            return true;
        }


        public bool EliminarProyecto(BEProyecto oProyecto)
        {
            // Eliminar el proyecto
            XDocument docP = XDocument.Load(rutaProyectos);

            var vProyecto = docP.Descendants("Proyecto")
                                .FirstOrDefault(x => (int)x.Attribute("Id") == oProyecto.Id);

            if (vProyecto == null)
                throw new InvalidOperationException("No se encontró el proyecto a eliminar.");

            vProyecto.Remove();
            docP.Save(rutaProyectos);

            // Eliminar fases
            XDocument docF = XDocument.Load(rutaFases);

            var fasesAEliminar = docF.Descendants("Fase")
                                     .Where(x => (int)x.Element("ProyectoId") == oProyecto.Id)
                                     .ToList();

            foreach (var fase in fasesAEliminar)
            {
                int faseId = (int)fase.Attribute("Id");

                // Eliminar tareas de la fase
                XDocument docT = XDocument.Load(rutaTareas);

                var tareasAEliminar = docT.Descendants("Tarea")
                                          .Where(x => (int)x.Element("FaseId") == faseId)
                                          .ToList();

                foreach (var tarea in tareasAEliminar)
                    tarea.Remove();

                docT.Save(rutaTareas);

                fase.Remove();
            }

            docF.Save(rutaFases);

            // Eliminar hitos
            XDocument docH = XDocument.Load(rutaHitos);

            var hitosAEliminar = docH.Descendants("Hito")
                                     .Where(x => (int)x.Element("ProyectoId") == oProyecto.Id)
                                     .ToList();

            foreach (var hito in hitosAEliminar)
                hito.Remove();

            docH.Save(rutaHitos);

            return true;
        }


        public bool VerificarPresenciaColaboradores(BEProyecto oProyecto)
        {
            XDocument doc = XDocument.Load(rutaAsignaciones);

            return doc.Descendants("Asignacion")
                      .Any(x => (int)x.Element("ProyectoId") == oProyecto.Id);
        }


        public bool SumarizarHoras(BEProyecto oProyecto)
        {
            XDocument doc = XDocument.Load(rutaFases);

            var fases = from fase in doc.Descendants("Fase")
                        where (int)fase.Element("ProyectoId") == oProyecto.Id
                        select new BEFase
                        {
                            Id = (int)fase.Attribute("Id"),
                            HorasCompletadas = decimal.Parse(fase.Element("HorasCompletadas").Value),
                            HorasRestantes = decimal.Parse(fase.Element("HorasRestantes").Value)
                        };

            var listaFases = fases.ToList();

            if (listaFases.Count == 0)
            {
                oProyecto.HorasCompletadas = 0;
                oProyecto.HorasRestantes = 0;
                ModificarProyecto(oProyecto);
                return false;
            }

            oProyecto.HorasCompletadas = listaFases.Sum(f => f.HorasCompletadas);
            oProyecto.HorasRestantes = listaFases.Sum(f => f.HorasRestantes);

            ModificarProyecto(oProyecto);
            return true;
        }


        public List<BEProyecto> ListarProyectos()
        {
            XDocument proyectosXml = XDocument.Load(rutaProyectos);
            XDocument fichasXml = XDocument.Load(rutaFichas);
            XDocument contratosXml = XDocument.Load(rutaContratos);
            XDocument clientesXml = XDocument.Load(rutaClientes);
            XDocument fasesXml = XDocument.Load(rutaFases);
            XDocument tareasXml = XDocument.Load(rutaTareas);
            XDocument hitosXml = XDocument.Load(rutaHitos);
            XDocument asignacionesXml = XDocument.Load(rutaAsignaciones);
            XDocument colaboradoresXml = XDocument.Load(rutaColaboradores);
            XDocument rolesXml = XDocument.Load(rutaRoles);


            var listaProyectos = from proyecto in proyectosXml.Descendants("Proyecto")
                                 select new BEProyecto//Armo el proyecto
                                 {
                                     Id = int.Parse(proyecto.Attribute("Id").Value),
                                     Titulo = proyecto.Element("Titulo").Value,
                                     Descripcion = proyecto.Element("Descripcion").Value,
                                     HorasEstimadas = int.Parse(proyecto.Element("HorasEstimadas").Value),
                                     HorasCompletadas = decimal.Parse(proyecto.Element("HorasCompletadas").Value),
                                     HorasRestantes = decimal.Parse(proyecto.Element("HorasRestantes").Value),
                                     Estado = (BEEEstadoProyecto)Enum.Parse(typeof(BEEEstadoProyecto), proyecto.Element("Estado").Value),

                                     FichaProyecto = (from ficha in fichasXml.Descendants("FichaProyecto")
                                                      where (int)ficha.Attribute("Id") == (int)proyecto.Element("FichaProyectoId")
                                                      select new BEFichaProyecto//Armo la ficha de proyecto del proyecto
                                                      {
                                                          Id = (int)ficha.Attribute("Id"),
                                                          Titulo = ficha.Element("Titulo").Value,
                                                          Descripcion = ficha.Element("Descripcion").Value,
                                                          FechaInicioPrevista = DateTime.Parse(ficha.Element("FechaInicioPrevista").Value),
                                                          FechaFinPrevista = DateTime.Parse(ficha.Element("FechaFinPrevista").Value),
                                                          Horas = int.Parse(ficha.Element("Horas").Value),
                                                          Presupuesto = decimal.Parse(ficha.Element("Presupuesto").Value),
                                                          Estado = (BEEEstadoFicha)Enum.Parse(typeof(BEEEstadoFicha), ficha.Element("Estado").Value),

                                                          Contrato = (from contrato in contratosXml.Descendants("Contrato")
                                                                      where (int)contrato.Attribute("Id") == (int)ficha.Element("ContratoId")
                                                                      select new BEContrato//Armo el contrato de la ficha del proyecto
                                                                      {
                                                                          Id = (int)contrato.Attribute("Id"),
                                                                          Titulo = contrato.Element("Titulo").Value,
                                                                          Descripcion = contrato.Element("Descripcion").Value,
                                                                          TerminosCondiciones = contrato.Element("TerminosCondiciones").Value,
                                                                          FechaFirma = DateTime.Parse(contrato.Element("FechaFirma").Value),
                                                                          FechaInicio = DateTime.Parse(contrato.Element("FechaInicio").Value),
                                                                          Monto = decimal.Parse(contrato.Element("Monto").Value),
                                                                          Estado = (BEEEstadoContrato)Enum.Parse(typeof(BEEEstadoContrato), contrato.Element("Estado").Value),

                                                                          Cliente = (from cliente in clientesXml.Descendants("Cliente")
                                                                                     where (int)cliente.Attribute("Id") == (int)contrato.Element("ClienteId")
                                                                                     select new BECliente//Armo el cliente del contrato de la ficha del proyecto
                                                                                     {
                                                                                         Id = (int)cliente.Attribute("Id"),
                                                                                         RazonSocial = cliente.Element("RazonSocial").Value,
                                                                                         IdFiscal = cliente.Element("IdFiscal").Value,
                                                                                         Email = cliente.Element("Email").Value,
                                                                                         Telefono = cliente.Element("Telefono").Value,
                                                                                         Pais = (BEEPais)Enum.Parse(typeof(BEEPais), cliente.Element("Pais").Value),
                                                                                         Industria = (BEEIndustria)Enum.Parse(typeof(BEEIndustria), cliente.Element("Industria").Value)
                                                                                     }).FirstOrDefault()
                                                                      }).FirstOrDefault()
                                                      }).FirstOrDefault(),

                                     Fases = (from fase in fasesXml.Descendants("Fase")
                                              where (int)fase.Element("ProyectoId") == (int)proyecto.Attribute("Id")
                                              select new BEFase //Armo las fases del proyecto
                                              {
                                                  Id = (int)fase.Attribute("Id"),
                                                  Titulo = fase.Element("Titulo").Value,
                                                  Descripcion = fase.Element("Descripcion").Value,
                                                  HorasEstimadas = decimal.Parse(fase.Element("HorasEstimadas").Value),
                                                  HorasCompletadas = decimal.Parse(fase.Element("HorasCompletadas").Value),
                                                  HorasRestantes = decimal.Parse(fase.Element("HorasRestantes").Value),
                                                  Estado = (BEEEstadoWI)Enum.Parse(typeof(BEEEstadoWI), fase.Element("Estado").Value),

                                                  Tareas = (from tarea in tareasXml.Descendants("Tarea")
                                                            where (int)tarea.Element("FaseId") == (int)fase.Attribute("Id")
                                                            select new BETarea//Armo las tareas de las fases del proyecto
                                                            {
                                                                Id = (int)tarea.Attribute("Id"),
                                                                Titulo = tarea.Element("Titulo").Value,
                                                                Descripcion = tarea.Element("Descripcion").Value,
                                                                HorasEstimadas = decimal.Parse(tarea.Element("HorasEstimadas").Value),
                                                                HorasCompletadas = decimal.Parse(tarea.Element("HorasCompletadas").Value),
                                                                HorasRestantes = decimal.Parse(tarea.Element("HorasRestantes").Value),
                                                                Estado = (BEEEstadoWI)Enum.Parse(typeof(BEEEstadoWI), tarea.Element("Estado").Value)
                                                            }).ToList()
                                              }).ToList(),

                                     Hitos = (from hito in hitosXml.Descendants("Hito")
                                              where (int)hito.Element("ProyectoId") == (int)proyecto.Attribute("Id")
                                              select new BEHito//Armo los hitos del proyecto
                                              {
                                                  Id = (int)hito.Attribute("Id"),
                                                  Titulo = hito.Element("Titulo").Value,
                                                  CriterioAlcance = hito.Element("CriterioAlcance").Value,
                                                  Fecha = DateTime.Parse(hito.Element("Fecha").Value),
                                                  Alcanzado = bool.Parse(hito.Element("Alcanzado").Value)
                                              }).ToList(),

                                     Colaboradores = (from asignacion in asignacionesXml.Descendants("Asignacion")
                                                      where (int)asignacion.Element("ProyectoId") == (int)proyecto.Attribute("Id")
                                                      let colaboradorId = (int)asignacion.Element("ColaboradorId")
                                                      select (from colaborador in colaboradoresXml.Descendants("Colaborador")
                                                              where (int)colaborador.Attribute("Id") == colaboradorId
                                                              select new BEColaborador//Armo los colaboradores del proyecto
                                                              {
                                                                  Id = (int)colaborador.Attribute("Id"),
                                                                  Nombre = colaborador.Element("Nombre").Value,
                                                                  Apellido = colaborador.Element("Apellido").Value,
                                                                  Dni = colaborador.Element("DNI").Value,
                                                                  Email = colaborador.Element("Email").Value,
                                                                  Telefono = colaborador.Element("Telefono").Value,
                                                                  Seniority = (BEESeniority)Enum.Parse(typeof(BEESeniority), colaborador.Element("Seniority").Value),

                                                                  Rol = (from rol in rolesXml.Descendants("Rol")
                                                                         where (int)rol.Attribute("Id") == (int)colaborador.Element("RolId")
                                                                         select new BERol //Armo los roles de los colaboradores del proyecto
                                                                         {
                                                                             Id = (int)rol.Attribute("Id"),
                                                                             Nombre = rol.Element("Nombre").Value,
                                                                             Descripcion = rol.Element("Descripcion").Value,
                                                                             Categoria = (BEECategoria)Enum.Parse(typeof(BEECategoria), rol.Element("Categoria").Value)
                                                                         }).FirstOrDefault()
                                                              }).FirstOrDefault()).ToList()
                                 };

            return listaProyectos.ToList();
        }

        public bool AsignarColaboradorProyecto(BEProyecto oProyecto, BEColaborador oColaborador)
        {
            XDocument doc = XDocument.Load(rutaAsignaciones);

            bool existe = doc.Descendants("Asignacion")
                             .Any(x => (int)x.Element("ColaboradorId") == oColaborador.Id &&
                                       (int)x.Element("ProyectoId") == oProyecto.Id);

            if (existe)
                return false;

            doc.Element("AsignacionesColPro").Add(
                new XElement("Asignacion",
                    new XElement("ColaboradorId", oColaborador.Id),
                    new XElement("ProyectoId", oProyecto.Id)
                )
            );

            doc.Save(rutaAsignaciones);
            return true;
        }

        public bool DesasignarColaboradorProyecto(BEProyecto oProyecto, BEColaborador oColaborador)
        {
            XDocument doc = XDocument.Load(rutaAsignaciones);

            var vAsignacion = doc.Descendants("Asignacion")
                                 .FirstOrDefault(x => (int)x.Element("ColaboradorId") == oColaborador.Id &&
                                                      (int)x.Element("ProyectoId") == oProyecto.Id);

            vAsignacion.Remove();
            doc.Save(rutaAsignaciones);
            return true;
        }

    }
}
