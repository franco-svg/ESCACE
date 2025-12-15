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
    public class MPPContrato
    {
        private readonly string rutaContratos;
        private readonly string rutaClientes;
        private readonly string rutaFichasProyecto;

        public MPPContrato()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            rutaContratos = Path.Combine(basePath, "Contratos.xml");
            rutaClientes = Path.Combine(basePath, "Clientes.xml");
            rutaFichasProyecto = Path.Combine(basePath, "FichasProyecto.xml");
        }

        public bool AgregarContrato(BEContrato oContrato)
        {
            XDocument doc = XDocument.Load(rutaContratos);

            int nuevoId = 1;
            var contratos = doc.Descendants("Contrato");
            if (contratos.Any())
            {
                nuevoId = contratos.Max(x => (int)x.Attribute("Id")) + 1;
            }

            doc.Element("Contratos").Add(
                new XElement("Contrato",
                    new XAttribute("Id", nuevoId),
                    new XElement("Titulo", oContrato.Titulo),
                    new XElement("Descripcion", oContrato.Descripcion),
                    new XElement("TerminosCondiciones", oContrato.TerminosCondiciones),
                    new XElement("FechaFirma", oContrato.FechaFirma.ToString("dd-MM-yyyy")),
                    new XElement("FechaInicio", oContrato.FechaInicio.ToString("dd-MM-yyyy")),
                    new XElement("Monto", oContrato.Monto),
                    new XElement("Estado", oContrato.Estado),
                    new XElement("ClienteId", oContrato.Cliente.Id)
                )
            );

            doc.Save(rutaContratos);

            return true;
        }

        public bool ModificarContrato(BEContrato oContrato)
        {
            XDocument doc = XDocument.Load(rutaContratos);

            var vContrato = doc.Descendants("Contrato")
                               .FirstOrDefault(x => (int)x.Attribute("Id") == oContrato.Id);

            vContrato.Element("Titulo").Value = oContrato.Titulo;
            vContrato.Element("Descripcion").Value = oContrato.Descripcion;
            vContrato.Element("TerminosCondiciones").Value = oContrato.TerminosCondiciones;
            vContrato.Element("Estado").Value = oContrato.Estado.ToString();

            doc.Save(rutaContratos);
            return true;
        }

        public bool EliminarContrato(BEContrato oContrato)
        {
            XDocument doc = XDocument.Load(rutaContratos);

            var vContrato = doc.Descendants("Contrato")
                              .FirstOrDefault(x => (int)x.Attribute("Id") == oContrato.Id);

            vContrato.Remove();
            doc.Save(rutaContratos);

            return true;
        }

        public bool VerificarPresenciaFicha(BEContrato oContrato)
        {
            XDocument doc = XDocument.Load(rutaFichasProyecto);

            bool concidencia = doc.Descendants("FichaProyecto")
                    .Any(x => (int)x.Element("ContratoId") == oContrato.Id);

            return concidencia;
        }

        public bool VerificarEstadoFichaAsociada(BEContrato oContrato, string sEstado)
        {
            XDocument doc = XDocument.Load(rutaFichasProyecto);

            var ficha = doc.Descendants("FichaProyecto")
                .FirstOrDefault(x => (int)x.Element("ContratoId") == oContrato.Id);

            if (ficha == null)
                return true;

            string estadoFicha = ((string)ficha.Element("Estado") ?? "")
                .Trim().ToLower();
            string estadoContrato = (sEstado ?? "")
                .Trim().ToLower();

            if (estadoContrato == "finalizado" || estadoContrato == "cancelado")
                return estadoFicha == estadoContrato;

            return true;
        }

        public List<BEContrato> ListarContratos()
        {
            XDocument contratosXml = XDocument.Load(rutaContratos);
            XDocument clientesXml = XDocument.Load(rutaClientes);

            var listaContratos = from contrato in contratosXml.Descendants("Contrato")
                                 select new BEContrato
                                 {
                                     Id = int.Parse(contrato.Attribute("Id").Value),
                                     Titulo = contrato.Element("Titulo").Value,
                                     Descripcion = contrato.Element("Descripcion").Value,
                                     TerminosCondiciones = contrato.Element("TerminosCondiciones").Value,
                                     FechaFirma = DateTime.Parse(contrato.Element("FechaFirma").Value),
                                     FechaInicio = DateTime.Parse(contrato.Element("FechaInicio").Value),
                                     Monto = decimal.Parse(contrato.Element("Monto").Value),
                                     Estado = (BEEEstadoContrato)Enum.Parse(typeof(BEEEstadoContrato), contrato.Element("Estado").Value),

                                     Cliente = (from cliente in clientesXml.Descendants("Cliente")
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
                                 };

            return listaContratos.ToList();
        }

        public List<BEContrato> ListarContratosDisponibles()
        {
            List<BEContrato> lContratos = ListarContratos();
            List<BEContrato> contratosDisponibles = new List<BEContrato>();

            foreach (var contrato in lContratos)
            {
                if (contrato.Estado == BEEEstadoContrato.Vigente && !VerificarPresenciaFicha(contrato))
                {
                    contratosDisponibles.Add(contrato);
                }
            }

            return contratosDisponibles;
        }
    }

}
