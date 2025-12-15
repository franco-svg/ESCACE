using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEFichaProyecto 
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicioPrevista { get; set; }
        public DateTime FechaFinPrevista { get; set; }
        public int Horas { get; set; }
        public decimal Presupuesto { get; set; }
        public BEEEstadoFicha Estado { get; set; }
        public BEContrato Contrato { get; set; }

        public override string ToString()
        {
            return $"{Titulo} | {Horas} horas";
        }

    }
}
