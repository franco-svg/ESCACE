using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLBitacora
    {
        MPPBitacora mapper;
        public BLLBitacora()
        {
            mapper = new MPPBitacora();
        }

        public bool AgregarBitacora(BEBitacora oBitacora)
        {
            return mapper.AgregarBitacora(oBitacora);
        }

        public List<BEBitacora> ListarBitacorasCompleto()
        {
            return mapper.ListarBitacoras();
        }

        public List<BEBitacora> ListarBitacorasBackup()
        {
            var listaCompleta = mapper.ListarBitacoras();
            return listaCompleta
                .Where(b => b.Detalle.Equals("backup", StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
        public List<BEBitacora> ListarBitacorasRestore()
        {
            var listaCompleta = mapper.ListarBitacoras();
            return listaCompleta
                .Where(b => b.Detalle.Equals("restore", StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

    }
}
