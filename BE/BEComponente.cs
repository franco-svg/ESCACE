using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BEComponente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        // Métodos comunes del patrón Composite
        public abstract void AgregarHijo(BEComponente oComponente);
        public abstract List<BEComponente> ObtenerHijos();

        // "Operation" del patron
        public abstract bool TienePermiso(string nombrePermiso);
    }
}

