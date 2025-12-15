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
    public class MPPFichaProyecto
    {
        private readonly string rutaFichas;
        private readonly string rutaContratos;
        private readonly string rutaClientes;
        private readonly string rutaProyectos;

        public MPPFichaProyecto()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            rutaFichas = Path.Combine(basePath, "FichasProyecto.xml");
            rutaContratos = Path.Combine(basePath, "Contratos.xml");
            rutaClientes = Path.Combine(basePath, "Clientes.xml");
            rutaProyectos = Path.Combine(basePath, "Proyectos.xml");
        }


        public bool AgregarFichaProyecto(BEFichaProyecto oFicha)
        {
            XDocument doc = XDocument.Load(rutaFichas);

            int nuevoId = 1;
            var fichas = doc.Descendants("FichaProyecto");
            if (fichas.Any())
            {
                nuevoId = fichas.Max(x => (int)x.Attribute("Id")) + 1;
            }

            doc.Element("FichasProyecto").Add(
                new XElement("FichaProyecto",
                    new XAttribute("Id", nuevoId),
                    new XElement("Titulo", oFicha.Titulo),
                    new XElement("Descripcion", oFicha.Descripcion),
                    new XElement("FechaInicioPrevista", oFicha.FechaInicioPrevista.ToString("dd-MM-yyyy")),
                    new XElement("FechaFinPrevista", oFicha.FechaFinPrevista.ToString("dd-MM-yyyy")),
                    new XElement("Horas", oFicha.Horas),
                    new XElement("Presupuesto", oFicha.Presupuesto),
                    new XElement("Estado", oFicha.Estado),
                    new XElement("ContratoId", oFicha.Contrato.Id)
                )
            );

            doc.Save(rutaFichas);
            return true;
        }


        public bool ModificarFichaProyecto(BEFichaProyecto oFicha)
        {
            XDocument doc = XDocument.Load(rutaFichas);

            var vFicha = doc.Descendants("FichaProyecto")
                            .FirstOrDefault(x => (int)x.Attribute("Id") == oFicha.Id);

            if (vFicha == null)
                throw new InvalidOperationException("No se encontró la ficha de proyecto a modificar.");

            vFicha.Element("Titulo").Value = oFicha.Titulo;
            vFicha.Element("Descripcion").Value = oFicha.Descripcion;
            vFicha.Element("Horas").Value = oFicha.Horas.ToString();
            vFicha.Element("Presupuesto").Value = oFicha.Presupuesto.ToString();
            vFicha.Element("Estado").Value = oFicha.Estado.ToString();

            doc.Save(rutaFichas);
            return true;
        }


        public bool EliminarFichaProyecto(BEFichaProyecto oFicha)
        {
            XDocument doc = XDocument.Load(rutaFichas);

            var vFicha = doc.Descendants("FichaProyecto")
                            .FirstOrDefault(x => (int)x.Attribute("Id") == oFicha.Id);

            vFicha.Remove();
            doc.Save(rutaFichas);

            return true;
        }


        public bool VerificarPresenciaProyecto(BEFichaProyecto oFicha)
        {
            XDocument doc = XDocument.Load(rutaProyectos);

            return doc.Descendants("Proyecto")
                      .Any(x => (int)x.Element("FichaProyectoId") == oFicha.Id);
        }


        public bool VerificarEstadoProyectoAsociado(BEFichaProyecto oFicha, string sEstado)
        {
            XDocument doc = XDocument.Load(rutaProyectos);

            var proyecto = doc.Descendants("Proyecto")
                .FirstOrDefault(x => (int)x.Element("FichaProyectoId") == oFicha.Id);

            if (proyecto == null)
                return true;

            string estadoProyecto = ((string)proyecto.Element("Estado") ?? "")
                .Trim().ToLower();

            string estadoFicha = (sEstado ?? "")
                .Trim().ToLower();

            if (estadoFicha == "finalizado" || estadoFicha == "cancelado")
                return estadoProyecto == estadoFicha;

            return true;
        }


        public List<BEFichaProyecto> ListarFichasProyecto()
        {
            XDocument fichasXml = XDocument.Load(rutaFichas);
            XDocument contratosXml = XDocument.Load(rutaContratos);
            XDocument clientesXml = XDocument.Load(rutaClientes);

            var listaFichas =
                from ficha in fichasXml.Descendants("FichaProyecto")
                select new BEFichaProyecto
                {
                    Id = int.Parse(ficha.Attribute("Id").Value),
                    Titulo = ficha.Element("Titulo").Value,
                    Descripcion = ficha.Element("Descripcion").Value,
                    FechaInicioPrevista = DateTime.Parse(ficha.Element("FechaInicioPrevista").Value),
                    FechaFinPrevista = DateTime.Parse(ficha.Element("FechaFinPrevista").Value),
                    Horas = int.Parse(ficha.Element("Horas").Value),
                    Presupuesto = decimal.Parse(ficha.Element("Presupuesto").Value),
                    Estado = (BEEEstadoFicha)Enum.Parse(typeof(BEEEstadoFicha), ficha.Element("Estado").Value),

                    Contrato =
                        (from contrato in contratosXml.Descendants("Contrato")
                         where (int)contrato.Attribute("Id") == (int)ficha.Element("ContratoId")
                         select new BEContrato
                         {
                             Id = (int)contrato.Attribute("Id"),
                             Titulo = contrato.Element("Titulo").Value,
                             Descripcion = contrato.Element("Descripcion").Value,
                             TerminosCondiciones = contrato.Element("TerminosCondiciones").Value,
                             FechaFirma = DateTime.Parse(contrato.Element("FechaFirma").Value),
                             FechaInicio = DateTime.Parse(contrato.Element("FechaInicio").Value),
                             Monto = decimal.Parse(contrato.Element("Monto").Value),
                             Estado = (BEEEstadoContrato)Enum.Parse(typeof(BEEEstadoContrato), contrato.Element("Estado").Value),

                             Cliente =
                                 (from cliente in clientesXml.Descendants("Cliente")
                                  where (int)cliente.Attribute("Id") == (int)contrato.Element("ClienteId")
                                  select new BECliente
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
                };

            return listaFichas.ToList();
        }
    }

}
