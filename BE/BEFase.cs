using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEFase : BEWorkItem  //Las fases del proyecto
    {

        public override decimal HorasCompletadas { get; set; } //roll up desde sus tareas

        public override decimal HorasRestantes { get; set; } //roll up desde sus tareas

        public List<BETarea> Tareas { get; set; }

        public BEProyecto Proyecto { get; set; }

        
    }
}
