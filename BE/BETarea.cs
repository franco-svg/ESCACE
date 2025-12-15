using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BETarea : BEWorkItem
    {
    
        public override decimal HorasCompletadas { get; set; }//input al cargarla

        public override decimal HorasRestantes { get; set; }//input al cargarla

        public BEFase Fase { get; set; }

    }
}
