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
    public class BLLBackup
    {
        MPPBackup mapper;

        public BLLBackup()
        {
            mapper = new MPPBackup();
        }

        public bool RealizarBackup(BEBackup oBackup)
        {
            return mapper.RealizarBackup(oBackup);
        }

        public List<BEBackup> ListarBackups()
        {
            return mapper.ListarBackups();
        }

        public List<string> ListarArchivosBackups()
        {
            return mapper.ListarArchivosBackups();
        }
    }
}
