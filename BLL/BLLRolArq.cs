using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL
{
    public class BLLRolArq
    {
        MPPRolArq mapper;

        public BLLRolArq()
        {
            mapper = new MPPRolArq();
        }

        public bool AgregarRolArq(BERolArq oRolArq)
        {
            return mapper.AgregarRolArq(oRolArq);
        }

        public bool ModificarRolArq(BERolArq oRolArq)
        {
            return mapper.ModificarRolArq(oRolArq);
        }

        public bool EliminarRolArq(BERolArq oRolArq)
        {
            return mapper.EliminarRolArq(oRolArq);
        }

        public bool VerificarPresenciaUsuario(BERolArq oRolArq)
        {
            if (mapper.VerificarPresenciaUsuario(oRolArq))
            {
                throw new InvalidOperationException("El rol no se puede eliminar del sistema estando asignado a algun usuario");
            }
            return false;
        }
        public bool VerificarPresenciaRol(BERolArq oRolArq)
        {
            if (mapper.VerificarPresenciaRol(oRolArq))
            {
                throw new InvalidOperationException("El rol no se puede eliminar del sistema estando asignado a algun rol");
            }
            return false;
        }

        public List<BERolArq> ListarRoles()
        {
            return mapper.ListarRoles();
        }

        public bool AsignarRolPermiso(BERolArq oRolArq, BEPermiso oPermiso)
        {
            if (!mapper.AsignarRolPermiso(oRolArq,oPermiso))
            {
                throw new InvalidOperationException($"El permiso {oPermiso} ya esta asignado al rol {oRolArq}");
            }
            return false;
        }
        public bool DesasignarRolPermiso(BERolArq oRolArq, BEPermiso oPermiso)
        {
            return mapper.DesasignarRolPermiso(oRolArq, oPermiso);
        }

        public bool AsignarRolRol(BERolArq oRolPadre, BERolArq oRolHijo)
        {
            if (!mapper.AsignarRolRol(oRolPadre, oRolHijo))
            {
                throw new InvalidOperationException($"El rol {oRolHijo} ya esta asignado al rol {oRolPadre}");
            }
            return false;
        }

        public bool DesasignarRolRol(BERolArq oRolPadre, BERolArq oRolHijo)
        {
            return mapper.DesasignarRolRol(oRolPadre, oRolHijo);
        }
    }

}
