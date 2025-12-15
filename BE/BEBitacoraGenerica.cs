using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEBitacoraGenerica
    {
        public int Id { get; set; }
        public string Detalle { get; set; }
        public DateTime Fecha { get; set; }
        public BEUsuario Usuario { get; set; }
    }
}
