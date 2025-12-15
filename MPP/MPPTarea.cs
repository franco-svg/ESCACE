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
    public class MPPTarea
    {
        private readonly string rutaTareas;

        public MPPTarea()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            rutaTareas = Path.Combine(basePath, "Tareas.xml");
        }

        public bool AgregarTarea(BETarea oTarea)
        {
            XDocument doc = XDocument.Load(rutaTareas);

            int nuevoId = 1;
            var tareas = doc.Descendants("Tarea");
            if (tareas.Any())
                nuevoId = tareas.Max(x => (int)x.Attribute("Id")) + 1;

            doc.Element("Tareas").Add(
                new XElement("Tarea",
                    new XAttribute("Id", nuevoId),
                    new XElement("Titulo", oTarea.Titulo),
                    new XElement("Descripcion", oTarea.Descripcion),
                    new XElement("HorasEstimadas", oTarea.HorasEstimadas),
                    new XElement("HorasCompletadas", oTarea.HorasCompletadas),
                    new XElement("HorasRestantes", oTarea.HorasRestantes),
                    new XElement("Estado", oTarea.Estado),
                    new XElement("FaseId", oTarea.Fase.Id)
                )
            );

            doc.Save(rutaTareas);
            return true;
        }

        public bool ModificarTarea(BETarea oTarea)
        {
            XDocument doc = XDocument.Load(rutaTareas);

            var vTarea = doc.Descendants("Tarea")
                            .FirstOrDefault(x => (int)x.Attribute("Id") == oTarea.Id);

            vTarea.Element("Titulo").Value = oTarea.Titulo;
            vTarea.Element("Descripcion").Value = oTarea.Descripcion;
            vTarea.Element("HorasEstimadas").Value = oTarea.HorasEstimadas.ToString();
            vTarea.Element("HorasCompletadas").Value = oTarea.HorasCompletadas.ToString();
            vTarea.Element("HorasRestantes").Value = oTarea.HorasRestantes.ToString();
            vTarea.Element("Estado").Value = oTarea.Estado.ToString();

            doc.Save(rutaTareas);
            return true;
        }

        public bool EliminarTarea(BETarea oTarea)
        {
            XDocument doc = XDocument.Load(rutaTareas);

            var vTarea = doc.Descendants("Tarea")
                            .FirstOrDefault(x => (int)x.Attribute("Id") == oTarea.Id);

            vTarea.Remove();
            doc.Save(rutaTareas);

            return true;
        }
    }

}

