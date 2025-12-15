using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLRol
    {
        MPPRol mapper;

        public BLLRol()
        {
            mapper = new MPPRol();
        }

        public bool AgregarRol(BERol oRol)
        {
            return mapper.AgregarRol(oRol);
        }

        public bool ModificarRol(BERol oRol)
        {
            return mapper.ModificarRol(oRol);
        }

        public bool EliminarRol(BERol oRol)
        {
            return mapper.EliminarRol(oRol);
        }

        public bool VerificarPresenciaColaborador(BERol oRol)
        {
            if (mapper.VerificarPresenciaColaborador(oRol))
            {
                throw new InvalidOperationException("El rol no se puede eliminar del sistema estando asignado a algun colaborador");
            }
            return false;
        }

        public List<BERol> ListarRoles()
        {
            return mapper.ListarRoles();
        }

    }
}
