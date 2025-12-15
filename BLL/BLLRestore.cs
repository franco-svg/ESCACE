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
    public class BLLRestore
    {
        MPPRestore mapper;
        public BLLRestore()
        {
            mapper = new MPPRestore();
        }

        public bool RealizarRestore(string sNombreArchivoBackup, BERestore oRestore)
        {
            return mapper.RealizarRestore(sNombreArchivoBackup, oRestore);
        }


    }

}
