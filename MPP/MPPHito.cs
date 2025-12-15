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
    public class MPPHito
    {
        private readonly string rutaHitos;

        public MPPHito()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            rutaHitos = Path.Combine(basePath, "Hitos.xml");
        }

        public bool AgregarHito(BEHito oHito)
        {
            XDocument doc = XDocument.Load(rutaHitos);

            int nuevoId = 1;
            var hitos = doc.Descendants("Hito");
            if (hitos.Any())
            {
                nuevoId = hitos.Max(x => (int)x.Attribute("Id")) + 1;
            }

            doc.Element("Hitos").Add(
                new XElement("Hito",
                    new XAttribute("Id", nuevoId),
                    new XElement("Titulo", oHito.Titulo),
                    new XElement("CriterioAlcance", oHito.CriterioAlcance),
                    new XElement("Fecha", oHito.Fecha.ToString("yyyy-MM-dd")),
                    new XElement("Alcanzado", oHito.Alcanzado),
                    new XElement("ProyectoId", oHito.Proyecto.Id)
                )
            );

            doc.Save(rutaHitos);
            return true;
        }

        public bool ModificarHito(BEHito oHito)
        {
            XDocument doc = XDocument.Load(rutaHitos);

            var vHito = doc.Descendants("Hito")
                           .FirstOrDefault(x => (int)x.Attribute("Id") == oHito.Id);

            vHito.Element("Titulo").Value = oHito.Titulo;
            vHito.Element("CriterioAlcance").Value = oHito.CriterioAlcance;
            vHito.Element("Fecha").Value = oHito.Fecha.ToString("yyyy-MM-dd");
            vHito.Element("Alcanzado").Value = oHito.Alcanzado.ToString();

            doc.Save(rutaHitos);
            return true;
        }

        public bool EliminarHito(BEHito oHito)
        {
            XDocument doc = XDocument.Load(rutaHitos);

            var vHito = doc.Descendants("Hito")
                           .FirstOrDefault(x => (int)x.Attribute("Id") == oHito.Id);

            vHito.Remove();
            doc.Save(rutaHitos);

            return true;
        }
    }

}
