using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEHito 
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public string CriterioAlcance { get; set; }

        public DateTime Fecha { get; set; }

        public bool Alcanzado { get; set; }

        public BEProyecto Proyecto { get; set; }

        public override string ToString()
        {
            return $"{Titulo} | {Fecha.ToString("dd/MM/yyyy")}";
        }
    }
}
