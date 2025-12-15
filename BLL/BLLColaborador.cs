using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL
{
    public class BLLColaborador
    {
        MPPColaborador mapper;

        public BLLColaborador()
        {
            mapper = new MPPColaborador();
        }

        public bool AgregarColaborador(BEColaborador oColaborador)
        {
            return mapper.AgregarColaborador(oColaborador);
        }

        public bool ModificarColaborador(BEColaborador oColaborador)
        {
            return mapper.ModificarColaborador(oColaborador);
        }

        public bool EliminarColaborador(BEColaborador oColaborador)
        {
            return mapper.EliminarColaborador(oColaborador);
        }

        public bool VerificarPresenciaProyecto(BEColaborador oColaborador)
        {
            if (mapper.VerificarPresenciaProyecto(oColaborador))
            {
                throw new InvalidOperationException("El colaborador no se puede eliminar del sistema estando asignado en algun proyecto");
            }
            return false;
        }

        public bool ValidarDniCargado(BEColaborador oColaborador)
        {
            var colaboradores = ListarColaboradores();

            // Buscar si hay un colaborador con el mismo DNI pero distinto ID
            var duplicado = colaboradores.FirstOrDefault(c => c.Dni == oColaborador.Dni && c.Id != oColaborador.Id);

            if (duplicado != null)
            {
                throw new InvalidOperationException($"Ya existe otro colaborador con el DNI {oColaborador.Dni}");
            }

            return false;
        }


        public List<BEColaborador> ListarColaboradores()
        {
            return mapper.ListarColaboradores();
        }

        public int ListarCantidadColaboradoresProyecto(int iNumProyectos, bool bIncluyeMayor = false)
        {
            return mapper.ListarCantidadColaboradoresProyecto(iNumProyectos, bIncluyeMayor);
        }

        public int CalcularPorcentajeColaboradoresConProyectos(int iNumProyectos, bool incluirMayores = false)
        {
            int totalColaboradores = ListarColaboradores().Count;
            int cantidadConNProyectos = mapper.ListarCantidadColaboradoresProyecto(iNumProyectos, incluirMayores);

            if (totalColaboradores == 0)
                return 0;

            // Calcula y redondea al entero más cercano
            int porcentaje = (int)Math.Round(
                (decimal)cantidadConNProyectos / totalColaboradores * 100,
                MidpointRounding.AwayFromZero
            );

            return porcentaje;
        }

        public int ListarCantidadProyectosColaborador(BEColaborador oColaborador)
        {
            return mapper.ListarCantidadProyectosColaborador(oColaborador);
        }

    }
}
