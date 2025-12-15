using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BEWorkItem
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public decimal HorasEstimadas { get; set; }
        public abstract decimal HorasCompletadas { get; set; }
        public abstract decimal HorasRestantes { get; set; }
        public BEEEstadoWI Estado { get; set; }

        public override string ToString()
        {
            return $"{Titulo} | {HorasEstimadas} horas estimadas";
        }

    }
}
