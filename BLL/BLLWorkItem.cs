using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLWorkItem
    {

        MPPFase mapperFase;
        MPPTarea mapperTarea;

        public BLLWorkItem()
        {
            mapperFase = new MPPFase();
            mapperTarea = new MPPTarea();
        }

        
        public bool AgregarWorkItem(BEFase oFase)
        {
            return mapperFase.AgregarFase(oFase);
        }

        public bool ModificarWorkItem(BEFase oFase)
        {
            return mapperFase.ModificarFase(oFase);
        }

        public bool EliminarWorkItem(BEFase oFase)
        {
            return mapperFase.EliminarFase(oFase);
        }

        public bool SumarizarHoraFase(BEFase oFase)
        {
            return mapperFase.SumarizarHoras(oFase);
        }

        public bool AgregarWorkItem(BETarea oTarea)
        {
            return mapperTarea.AgregarTarea(oTarea);
        }

        public bool ModificarWorkItem(BETarea oTarea)
        {
            return mapperTarea.ModificarTarea(oTarea);
        }

        public bool EliminarWorkItem(BETarea oTarea)
        {
            return mapperTarea.EliminarTarea(oTarea);
        }

    }
}
