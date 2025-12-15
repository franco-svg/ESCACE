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
    public class MPPBackup
    {
        MPPUsuario mapperUsuario;

        // Carpeta donde se guardan los backups (junto al EXE)
        private readonly string rutaBackups;

        // Archivo Backups.xml (junto al EXE)
        private readonly string rutaRegistroBackups;

        List<string> archivosValidos = new List<string>
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
    };

        public MPPBackup()
        {
            mapperUsuario = new MPPUsuario();

            // Carpeta del EXE
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            // Backups.xml ahora está junto al EXE
            rutaRegistroBackups = Path.Combine(basePath, "Backups.xml");

            // Carpeta Backups dentro del EXE (si no existe, la creo)
            rutaBackups = Path.Combine(basePath, "Backups");

            if (!Directory.Exists(rutaBackups))
                Directory.CreateDirectory(rutaBackups);
        }

        public bool RealizarBackup(BEBackup oBackup)
        {
            XDocument docBackup = new XDocument(new XElement("BackupData"));

            foreach (string archivo in archivosValidos)
            {
                string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, archivo);

                XDocument doc = XDocument.Load(rutaArchivo);

                docBackup.Root.Add(new XElement(
                    Path.GetFileNameWithoutExtension(archivo),
                    doc.Root.Elements()
                ));
            }

            string nombreBackup = $"Backup_{DateTime.Now:dd-MM-yyyy_HH-mm-ss}.xml";
            string rutaBackup = Path.Combine(rutaBackups, nombreBackup);

            docBackup.Save(rutaBackup);

            // Registrar en Backups.xml
            XDocument docRegistro = XDocument.Load(rutaRegistroBackups);

            int nuevoId = 1;
            var backups = docRegistro.Descendants("Backup");
            if (backups.Any())
                nuevoId = backups.Max(x => (int)x.Attribute("Id")) + 1;

            docRegistro.Element("Backups").Add(
                new XElement("Backup",
                    new XAttribute("Id", nuevoId),
                    new XElement("Detalle", oBackup.Detalle),
                    new XElement("Fecha", oBackup.Fecha.ToString("dd-MM-yyyy HH:mm:ss")),
                    new XElement("UsuarioId", oBackup.Usuario.Id)
                )
            );

            docRegistro.Save(rutaRegistroBackups);
            return true;
        }

        public List<BEBackup> ListarBackups()
        {
            XDocument doc = XDocument.Load(rutaRegistroBackups);

            MPPUsuario mapperUsuario = new MPPUsuario();
            var usuarios = mapperUsuario.ListarUsuarios();

            var listaBackups =
                from backup in doc.Descendants("Backup")
                let usuarioId = int.Parse(backup.Element("UsuarioId").Value)
                select new BEBackup
                {
                    Id = int.Parse(backup.Attribute("Id").Value),
                    Detalle = backup.Element("Detalle").Value,
                    Fecha = DateTime.Parse(backup.Element("Fecha").Value),
                    Usuario = usuarios.FirstOrDefault(u => u.Id == usuarioId)
                };

            return listaBackups.ToList();
        }

        public List<string> ListarArchivosBackups()
        {
            return Directory.GetFiles(rutaBackups, "*.xml")
                            .Select(Path.GetFileName)
                            .OrderBy(f => f)
                            .ToList();
        }
    }

}
