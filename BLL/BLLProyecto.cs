using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLProyecto
    {
        MPPProyecto mapper;

        public BLLProyecto()
        {
            mapper = new MPPProyecto();
        }

        public bool AgregarProyecto(BEProyecto oProyecto)
        {
            return mapper.AgregarProyecto(oProyecto);
        }

        public bool ModificarProyecto(BEProyecto oProyecto)
        {
            return mapper.ModificarProyecto(oProyecto);
        }

        public bool EliminarProyecto(BEProyecto oProyecto)
        {
            return mapper.EliminarProyecto(oProyecto);
        }

        public bool VerificarPresenciaColaboradores(BEProyecto oProyecto)
        {
            if (mapper.VerificarPresenciaColaboradores(oProyecto))
            {
                throw new InvalidOperationException("El proyecto no se puede eliminar del sistema teniendo colaboradores asignados");
            }
            return false;
        }
        public bool SumarizarHoras(BEProyecto oProyecto)
        {
            return mapper.SumarizarHoras(oProyecto);
        }

        public List<BEProyecto> ListarProyectos()
        {
            return mapper.ListarProyectos();
        }

        public List<BEProyecto> ListarProyectosColaborador(BEColaborador oColaborador)
        {
            var proyectos = mapper.ListarProyectos();
            return proyectos.Where(p => p.Colaboradores.Any(c => c.Id == oColaborador.Id)).ToList();
        }

        public List<BEProyecto> ListarProyectosFechas(DateTime dFecha1, DateTime dFecha2)
        {
            var lProyectos = mapper.ListarProyectos();

            DateTime desde = dFecha1.Date;
            DateTime hasta = dFecha2.Date.AddDays(1).AddTicks(-1);

            return lProyectos
            .Where(p => p.FichaProyecto.FechaInicioPrevista >= desde && p.FichaProyecto.FechaInicioPrevista<= hasta)
            .ToList();
        }

        public bool AsignarColaboradorProyecto(BEProyecto oProyecto, BEColaborador oColaborador)
        {
            return mapper.AsignarColaboradorProyecto(oProyecto, oColaborador);
        }

        public bool DesasignarColaboradorProyecto(BEProyecto oProyecto, BEColaborador oColaborador)
        {
            return mapper.DesasignarColaboradorProyecto(oProyecto, oColaborador);
        }

    }
}
