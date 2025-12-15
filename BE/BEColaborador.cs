using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEColaborador 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
      
        public BERol Rol { get; set; }
        public BEESeniority Seniority { get; set; }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} | {Rol} | {Seniority}";
        }
    }

    
}
