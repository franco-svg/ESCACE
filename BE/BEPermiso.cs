using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEPermiso : BEComponente
    {
        public override void AgregarHijo(BEComponente oComponente)
        {
            //leaf
        }

        public override List<BEComponente> ObtenerHijos()
        {
            return null; //leaf
        }

        public override bool TienePermiso(string nombrePermiso)
        {
            return Nombre.Equals(nombrePermiso, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return $"{Nombre}";
        }
    }
}
