using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEProyecto 
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }

        public int HorasEstimadas { get; set; } //Viene de la ficha de proyecto

        public decimal HorasCompletadas { get; set; } //Roll up desde sus fases

        public decimal HorasRestantes { get; set; } //Roll up desde sus fases

        public BEEEstadoProyecto Estado { get; set; }

        public List<BEFase> Fases { get; set; }

        public List<BEHito> Hitos { get; set; }

        public BEFichaProyecto FichaProyecto { get; set; }

        public List<BEColaborador> Colaboradores { get; set; }


        public override string ToString()
        {
            return $"{Titulo} | {HorasEstimadas}";
        }
    }
}
