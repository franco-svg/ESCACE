using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCliente
    {

        MPPCliente mapper;

        public BLLCliente()
        {
            mapper = new MPPCliente();
        }

        public bool AgregarCliente(BECliente oCliente)
        {
            return mapper.AgregarCliente(oCliente);
        }

        public bool ModificarCliente(BECliente oCliente)
        {
            return mapper.ModificarCliente(oCliente);
        }

        public bool EliminarCliente(BECliente oCliente)
        {
            return mapper.EliminarCliente(oCliente);
        }

        public bool VerificarPresenciaContrato(BECliente oCliente)
        {
            if (mapper.VerificarPresenciaContrato(oCliente))
            {
                throw new InvalidOperationException("El cliente no se puede eliminar del sistema teniendo contratos asociados");
            }
            return false;
        }

        public List<BECliente> ListarClientes()
        {
            return mapper.ListarClientes();
        }
    }
}
