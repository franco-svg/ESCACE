using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BE
{
    public class BERolArq : BEComponente
    {

        private List<BEComponente> Hijos;

        public BERolArq()
        {
            Hijos = new List<BEComponente>();
        }

        public override void AgregarHijo(BEComponente oComponente) //se le pueden pasar tanto roles como permisos
        {
            Hijos.Add(oComponente);
        }

        public override List<BEComponente> ObtenerHijos() //lista hijos de forma indiferente, sean roles o permisos
        {
            return Hijos.ToList();
        }

        public override bool TienePermiso(string nombrePermiso)//Operation, recursivo
        {
            foreach (var hijo in Hijos)
            {
                if (hijo.TienePermiso(nombrePermiso))//si se trata de un subrol, sigue buscando mas profundo. si es un permiso, se ejecuta la version "basica" del metodo
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{Nombre}";
        }
    }
}

