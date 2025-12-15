using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLHito
    {
        MPPHito mapper;
        public BLLHito() 
        {
            mapper=new MPPHito();
        }

        public bool AgregarHito(BEHito oHito)
        {
            return mapper.AgregarHito(oHito);
        }

        public bool ModificarHito(BEHito oHito)
        {
            return mapper.ModificarHito(oHito);
        }

        public bool EliminarHito(BEHito oHito)
        {
            return mapper.EliminarHito(oHito);
        }
    }
}
