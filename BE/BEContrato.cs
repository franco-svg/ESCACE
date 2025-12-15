using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEContrato 
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string TerminosCondiciones { get; set; }
        public DateTime FechaFirma { get; set; }
        public DateTime FechaInicio { get; set; }
        public decimal Monto { get; set; } //el monto siempre sera en USD
        public BEEEstadoContrato Estado { get; set; }
        public BECliente Cliente { get; set; }


        public override string ToString()
        {
            return $"{Titulo} - {Cliente.RazonSocial}";
        }

    }
}
