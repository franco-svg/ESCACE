using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLPermiso
    {
        MPPPermiso mapper;

        public BLLPermiso()
        {
            mapper = new MPPPermiso();
        }


        public bool AgregarPermiso(BEPermiso oPermiso)
        {
            return mapper.AgregarPermiso(oPermiso);
        }
        public bool EliminarPermiso(BEPermiso oPermiso)
        {
            return mapper.EliminarPermiso(oPermiso);
        }

        public bool VerificarPresenciaUsuario(BEPermiso oPermiso)
        {
            if (mapper.VerificarPresenciaUsuario(oPermiso))
            {
                throw new InvalidOperationException("El permiso no se puede eliminar del sistema estando asignado directamente a algun usuario");
            }
            return false;
        }
        public bool VerificarPresenciaRol(BEPermiso oPermiso)
        {
            if (mapper.VerificarPresenciaRol(oPermiso))
            {
                throw new InvalidOperationException("El permiso no se puede eliminar del sistema estando asignado directamente a algun rol");
            }
            return false;
        }

        public List<BEPermiso> ListarPermisos()
        {
            return mapper.ListarPermisos();
        }

    }
}
