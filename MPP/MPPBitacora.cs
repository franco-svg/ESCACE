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
    public class MPPBitacora
    {
        private readonly string rutaBitacoras;
        MPPUsuario mapperUsuario;

        public MPPBitacora()
        {
            mapperUsuario = new MPPUsuario();

            // Carpeta base del EXE instalado
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            // Bitacoras.xml ubicado en la raíz junto al EXE
            rutaBitacoras = Path.Combine(basePath, "Bitacoras.xml");
        }

        public bool AgregarBitacora(BEBitacora oBitacora)
        {
            XDocument doc = XDocument.Load(rutaBitacoras);

            int nuevoId = 1;
            var bitacoras = doc.Descendants("Bitacora");
            if (bitacoras.Any())
            {
                nuevoId = bitacoras.Max(x => (int)x.Attribute("Id")) + 1;
            }

            doc.Element("Bitacoras").Add(
                new XElement("Bitacora",
                    new XAttribute("Id", nuevoId),
                    new XElement("Detalle", oBitacora.Detalle),
                    new XElement("Fecha", oBitacora.Fecha.ToString("dd-MM-yyyy HH:mm:ss")),
                    new XElement("UsuarioId", oBitacora.Usuario.Id)
                )
            );

            doc.Save(rutaBitacoras);
            return true;
        }

        public List<BEBitacora> ListarBitacoras()
        {
            XDocument doc = XDocument.Load(rutaBitacoras);

            List<BEUsuario> usuarios = mapperUsuario.ListarUsuarios();

            var listaBitacoras =
                from bitacora in doc.Descendants("Bitacora")
                let usuarioId = int.Parse(bitacora.Element("UsuarioId").Value)
                select new BEBitacora
                {
                    Id = int.Parse(bitacora.Attribute("Id").Value),
                    Detalle = bitacora.Element("Detalle").Value,
                    Fecha = DateTime.Parse(bitacora.Element("Fecha").Value),
                    Usuario = usuarios.FirstOrDefault(u => u.Id == usuarioId)
                };

            return listaBitacoras.ToList();
        }
    }

}
