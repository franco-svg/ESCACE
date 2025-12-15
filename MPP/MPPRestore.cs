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
    public class MPPRestore
    {
        private readonly string rutaBackups;
        private readonly string rutaRestores;
        private readonly List<string> archivosRestorear;

        public MPPRestore()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            // Carpeta donde estarán los backups en el instalador
            rutaBackups = Path.Combine(basePath, "Backups");

            // Archivo donde se registran los restores
            rutaRestores = Path.Combine(basePath, "Restores.xml");

            // Archivos a restaurar (con rutas completas)
            archivosRestorear = new List<string>
        {
            "AsignacionesColPro.xml",
            "Clientes.xml",
            "Colaboradores.xml",
            "Contratos.xml",
            "Fases.xml",
            "FichasProyecto.xml",
            "Hitos.xml",
            "Proyectos.xml",
            "Roles.xml",
            "Tareas.xml",
            "AsignacionesRolPer.xml",
            "AsignacionesRolRol.xml",
            "AsignacionesUsuPer.xml",
            "AsignacionesUsuRol.xml",
            "RolesArq.xml",
            "Usuarios.xml",
            "Permisos.xml"
        }
            .Select(f => Path.Combine(basePath, f))
            .ToList();
        }


        public bool RealizarRestore(string nombreArchivoBackup, BERestore oRestore)
        {
            // Cargar backup seleccionado (ruta absoluta)
            string rutaBackup = Path.Combine(rutaBackups, nombreArchivoBackup);
            XDocument docBackup = XDocument.Load(rutaBackup);

            // Restaurar cada archivo
            foreach (string rutaArchivoDestino in archivosRestorear)
            {
                string nombreArchivo = Path.GetFileName(rutaArchivoDestino);
                string nombreNodo = Path.GetFileNameWithoutExtension(nombreArchivo);

                XElement nodoBackup = docBackup.Root.Element(nombreNodo);

                if (nodoBackup != null)
                {
                    // Crear un XML con ese nodo como root
                    XDocument docDestino = new XDocument(new XElement(nodoBackup));

                    // Sobrescribir archivo real del sistema
                    docDestino.Save(rutaArchivoDestino);
                }
            }

            // Registrar restore
            XDocument docRegistro = XDocument.Load(rutaRestores);

            int nuevoId = 1;
            var restores = docRegistro.Descendants("Restore");
            if (restores.Any())
                nuevoId = restores.Max(x => (int)x.Attribute("Id")) + 1;

            docRegistro.Element("Restores").Add(
                new XElement("Restore",
                    new XAttribute("Id", nuevoId),
                    new XElement("Detalle", oRestore.Detalle),
                    new XElement("Fecha", oRestore.Fecha.ToString("dd-MM-yyyy HH:mm:ss")),
                    new XElement("UsuarioId", oRestore.Usuario.Id)
                )
            );

            docRegistro.Save(rutaRestores);

            return true;
        }
    }

}
