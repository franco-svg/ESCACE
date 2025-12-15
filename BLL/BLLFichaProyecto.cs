using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLFichaProyecto
    {
        MPPFichaProyecto mapper;
        public BLLFichaProyecto()
        {
            mapper=new MPPFichaProyecto();
        }

        public bool AgregarFichaProyecto(BEFichaProyecto oFicha)
        {
            return mapper.AgregarFichaProyecto(oFicha);
        }

        public bool ModificarFichaProyecto(BEFichaProyecto oFicha)
        {
            return mapper.ModificarFichaProyecto(oFicha);
        }

        public bool VerificarPresenciaProyecto(BEFichaProyecto oFicha)
        {
            if (mapper.VerificarPresenciaProyecto(oFicha))
            {
                throw new InvalidOperationException("La ficha de proyecto no se puede eliminar del sistema teniendo un contrato asociado");
            }
            return false;
        }

        public bool VerificarEstadoProyectoAsociado(BEFichaProyecto oFicha, string sEstado)
        {
            if (!mapper.VerificarEstadoProyectoAsociado(oFicha, sEstado))
            {
                throw new InvalidOperationException($"No se puede pasar la ficha al estado '{sEstado}' porque el proyecto asociado no se encuentra en este mismo estado.");
            }
            return true;
        }

        public bool VerificarPresenciaProyecto(BEFichaProyecto oFicha, bool bFlag)
        {
            if (mapper.VerificarPresenciaProyecto(oFicha))
            {
                return true;
            }
            return false;
        }

        public bool VerificarTraspasoPendiente(BEFichaProyecto oFicha, string sEstado)
        {
            if (oFicha.Estado!=BEEEstadoFicha.Pendiente && sEstado=="Pendiente")
            {
                throw new InvalidOperationException("No es posible revertir la ficha de proyecto al estado Pendiente. Se recomienda crear una nueva ficha de proyecto en su lugar.");
            }
            return false;
        }

        public bool EliminarFichaProyecto(BEFichaProyecto oFicha)
        {
            return mapper.EliminarFichaProyecto(oFicha);
        }

        public List<BEFichaProyecto> ListarFichasProyecto()
        {
            return mapper.ListarFichasProyecto();
        }

        public List<BEFichaProyecto> ListarFichasDisponibles()
        {
            List<BEFichaProyecto> lFichas = ListarFichasProyecto();
            List<BEFichaProyecto> fichasDisponibles = new List<BEFichaProyecto>();

            foreach (var ficha in lFichas)
            {
                // Cumple dos condiciones:
                // 1. Estado pendiente
                // 2. No tiene proyecto asociado
                if (ficha.Estado == BEEEstadoFicha.En_Curso && !VerificarPresenciaProyecto(ficha, true))
                {
                    fichasDisponibles.Add(ficha);
                }
            }

            return fichasDisponibles;
        }

        public List<BEFichaProyecto>ListarFichasFechas(DateTime dFecha1, DateTime dFecha2)
        {
            var lfichas = mapper.ListarFichasProyecto();

            DateTime desde = dFecha1.Date;
            DateTime hasta = dFecha2.Date.AddDays(1).AddTicks(-1);

            return lfichas
            .Where(f => f.FechaInicioPrevista >= desde && f.FechaInicioPrevista<= hasta)
            .ToList();
        }

        public int CalcularCantidadFichasHoras(int iMinimo, int iMaximo, DateTime dFecha1, DateTime dFecha2)
        {
            var fichas = ListarFichasFechas(dFecha1,dFecha2);

            if (iMaximo == 0)
            {
                return fichas.Count(c => c.Horas >= iMinimo);
            }

            return fichas.Count(c => c.Horas >= iMinimo && c.Horas < iMaximo);
        }

        public int CalcularPorcentajeFichasHoras(int iMinimo, int iMaximo, DateTime dFecha1, DateTime dFecha2)
        {
            var fichas = ListarFichasFechas(dFecha1, dFecha2);

            int total = fichas.Count;
            if (total == 0)
                return 0;

            int cantidadEnRango;

            if (iMaximo == 0)
            {
                cantidadEnRango = fichas.Count(c => c.Horas >= iMinimo);
            }
            else
            {
                cantidadEnRango = fichas.Count(c => c.Horas >= iMinimo && c.Horas < iMaximo);
            }

            // Calcular porcentaje en entero
            int porcentaje = (int)Math.Round((decimal)cantidadEnRango / total * 100, MidpointRounding.AwayFromZero);

            return porcentaje;
        }

    }
}
