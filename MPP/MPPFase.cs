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
    public class MPPFase
    {
        private readonly string rutaFases;
        private readonly string rutaTareas;

        public MPPFase()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            rutaFases = Path.Combine(basePath, "Fases.xml");
            rutaTareas = Path.Combine(basePath, "Tareas.xml");
        }

        public bool AgregarFase(BEFase oFase)
        {
            XDocument doc = XDocument.Load(rutaFases);

            int nuevoId = 1;
            var fases = doc.Descendants("Fase");
            if (fases.Any())
            {
                nuevoId = fases.Max(x => (int)x.Attribute("Id")) + 1;
            }

            doc.Element("Fases").Add(
                new XElement("Fase",
                    new XAttribute("Id", nuevoId),
                    new XElement("Titulo", oFase.Titulo),
                    new XElement("Descripcion", oFase.Descripcion),
                    new XElement("HorasEstimadas", oFase.HorasEstimadas),
                    new XElement("HorasCompletadas", oFase.HorasCompletadas),
                    new XElement("HorasRestantes", oFase.HorasRestantes),
                    new XElement("Estado", oFase.Estado.ToString()),
                    new XElement("ProyectoId", oFase.Proyecto.Id)
                )
            );

            doc.Save(rutaFases);
            return true;
        }

        public bool ModificarFase(BEFase oFase)
        {
            XDocument doc = XDocument.Load(rutaFases);

            var vFase = doc.Descendants("Fase")
                           .FirstOrDefault(x => (int)x.Attribute("Id") == oFase.Id);

            vFase.Element("Titulo").Value = oFase.Titulo;
            vFase.Element("Descripcion").Value = oFase.Descripcion;
            vFase.Element("HorasEstimadas").Value = oFase.HorasEstimadas.ToString();
            vFase.Element("HorasCompletadas").Value = oFase.HorasCompletadas.ToString();
            vFase.Element("HorasRestantes").Value = oFase.HorasRestantes.ToString();
            vFase.Element("Estado").Value = oFase.Estado.ToString();

            doc.Save(rutaFases);
            return true;
        }

        public bool EliminarFase(BEFase oFase)
        {
            XDocument fasesXml = XDocument.Load(rutaFases);
            XDocument tareasXml = XDocument.Load(rutaTareas);

            var vFase = fasesXml.Descendants("Fase")
                                .FirstOrDefault(x => (int)x.Attribute("Id") == oFase.Id);

            // Eliminar todas las tareas hijas
            var tareasHijas = tareasXml.Descendants("Tarea")
                                       .Where(x => (int)x.Element("FaseId") == oFase.Id)
                                       .ToList();

            foreach (var tarea in tareasHijas)
            {
                tarea.Remove();
            }

            tareasXml.Save(rutaTareas);

            vFase.Remove();
            fasesXml.Save(rutaFases);

            return true;
        }

        public bool SumarizarHoras(BEFase oFase)
        {
            XDocument doc = XDocument.Load(rutaTareas);

            var tareas = from tarea in doc.Descendants("Tarea")
                         where (int)tarea.Element("FaseId") == oFase.Id
                         select new BETarea
                         {
                             Id = (int)tarea.Attribute("Id"),
                             HorasCompletadas = decimal.Parse(tarea.Element("HorasCompletadas").Value),
                             HorasRestantes = decimal.Parse(tarea.Element("HorasRestantes").Value)
                         };

            var listaTareas = tareas.ToList();

            if (listaTareas.Count == 0)
            {
                oFase.HorasCompletadas = 0;
                oFase.HorasRestantes = 0;
                ModificarFase(oFase);
                return false;
            }

            oFase.HorasCompletadas = listaTareas.Sum(t => t.HorasCompletadas);
            oFase.HorasRestantes = listaTareas.Sum(t => t.HorasRestantes);

            ModificarFase(oFase);
            return true;
        }
    }

}
