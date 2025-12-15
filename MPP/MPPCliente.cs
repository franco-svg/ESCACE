using BE;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MPP
{
    public class MPPCliente
    {
        private readonly string rutaClientes;
        private readonly string rutaContratos;

        public MPPCliente()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            rutaClientes = Path.Combine(basePath, "Clientes.xml");
            rutaContratos = Path.Combine(basePath, "Contratos.xml");
        }

        public bool AgregarCliente(BECliente oCliente)
        {
            XDocument doc = XDocument.Load(rutaClientes);

            int nuevoId = 1;
            var clientes = doc.Descendants("Cliente");
            if (clientes.Any())
            {
                nuevoId = clientes.Max(x => (int)x.Attribute("Id")) + 1;
            }

            doc.Element("Clientes").Add(
                new XElement("Cliente",
                    new XAttribute("Id", nuevoId),
                    new XElement("RazonSocial", oCliente.RazonSocial),
                    new XElement("IdFiscal", oCliente.IdFiscal),
                    new XElement("Email", oCliente.Email),
                    new XElement("Telefono", oCliente.Telefono),
                    new XElement("Industria", oCliente.Industria),
                    new XElement("Pais", oCliente.Pais)
                )
            );

            doc.Save(rutaClientes);

            return true;
        }

        public bool ModificarCliente(BECliente oCliente)
        {
            XDocument doc = XDocument.Load(rutaClientes);

            var vCliente = doc.Descendants("Cliente")
                            .FirstOrDefault(x => (int)x.Attribute("Id") == oCliente.Id);

            vCliente.Element("RazonSocial").Value = oCliente.RazonSocial;
            vCliente.Element("IdFiscal").Value = oCliente.IdFiscal;
            vCliente.Element("Email").Value = oCliente.Email;
            vCliente.Element("Telefono").Value = oCliente.Telefono;
            vCliente.Element("Industria").Value = oCliente.Industria.ToString();
            vCliente.Element("Pais").Value = oCliente.Pais.ToString();

            doc.Save(rutaClientes);
            return true;
        }

        public bool EliminarCliente(BECliente oCliente)
        {
            XDocument doc = XDocument.Load(rutaClientes);

            var vCliente = doc.Descendants("Cliente")
                            .FirstOrDefault(x => (int)x.Attribute("Id") == oCliente.Id);

            vCliente.Remove();
            doc.Save(rutaClientes);

            return true;
        }

        public bool VerificarPresenciaContrato(BECliente oCliente)
        {
            XDocument doc = XDocument.Load(rutaContratos);

            bool concidencia = doc.Descendants("Contrato")
                    .Any(x => (int)x.Element("ClienteId") == oCliente.Id);

            return concidencia;
        }

        public List<BECliente> ListarClientes()
        {
            XDocument doc = XDocument.Load(rutaClientes);

            var listaClientes = from cliente in doc.Descendants("Cliente")
                                select new BECliente
                                {
                                    Id = int.Parse(cliente.Attribute("Id").Value),
                                    RazonSocial = cliente.Element("RazonSocial").Value,
                                    IdFiscal = cliente.Element("IdFiscal").Value,
                                    Email = cliente.Element("Email").Value,
                                    Telefono = cliente.Element("Telefono").Value,
                                    Pais = (BEEPais)Enum.Parse(typeof(BEEPais), cliente.Element("Pais").Value),
                                    Industria = (BEEIndustria)Enum.Parse(typeof(BEEIndustria), cliente.Element("Industria").Value)
                                };

            return listaClientes.ToList();
        }
    }

}
