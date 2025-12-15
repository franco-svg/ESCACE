using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLContrato
    {
        MPPContrato mapper;

        public BLLContrato()
        {
            mapper = new MPPContrato();
        }

        public bool AgregarContrato(BEContrato oContrato)
        {
            return mapper.AgregarContrato(oContrato);
        }


        public bool ModificarContrato(BEContrato oContrato)
        {
            return mapper.ModificarContrato(oContrato);
        }

        public bool EliminarContrato(BEContrato oContrato)
        {
            return mapper.EliminarContrato(oContrato);
        }


        public bool VerificarPresenciaFicha(BEContrato oContrato)
        {
            if (mapper.VerificarPresenciaFicha(oContrato))
            {
                throw new InvalidOperationException("El contrato no se puede eliminar del sistema teniendo una ficha de proyecto asociada");
            }
            return false;
        }

        public bool VerificarTraspasoPendiente(BEContrato oContrato, string sEstado)
        {
            if (oContrato.Estado!=BEEEstadoContrato.Pendiente && sEstado=="Pendiente")
            {
                throw new InvalidOperationException("No es posible revertir el contrato al estado Pendiente. Se recomienda crear un nuevo contrato en su lugar.");
            }
            return false;
        }

        public bool VerificarEstadoFichaAsociada(BEContrato oContrato, string sEstado)
        {
            if (!mapper.VerificarEstadoFichaAsociada(oContrato, sEstado))
            {
                throw new InvalidOperationException($"No se puede pasar el contrato al estado '{sEstado}' porque la ficha de proyecto asociada no se encuentra en este mismo estado.");
            }
            return true;
        }

        public List<BEContrato> ListarContratos()
        {
            return mapper.ListarContratos();
        }

        public List<BEContrato> ListarContratosDisponibles()
        {
            return mapper.ListarContratosDisponibles();
        }

        public List<BEContrato> ListarContratosFechas(DateTime dFecha1, DateTime dFecha2)
        {
            var lContratos = mapper.ListarContratos();

            DateTime desde = dFecha1.Date;
            DateTime hasta = dFecha2.Date.AddDays(1).AddTicks(-1);

            return lContratos
            .Where(c => c.FechaInicio >= desde && c.FechaInicio<= hasta)
            .ToList();
        }

        public List<BECliente> ListarClientesContratosFechas(DateTime dFecha1, DateTime dFecha2)
        {
            var contratos = ListarContratosFechas(dFecha1, dFecha2);

            return contratos
                .Select(co => co.Cliente)
                .Distinct()
                .ToList();
        }
        public int CalcularCantidadContratosMonto(int iMinimo, int iMaximo,DateTime dFecha1, DateTime dFecha2)
        {
            var contratos = ListarContratosFechas(dFecha1,dFecha2);

            if (iMaximo == 0)
            {
                return contratos.Count(c => c.Monto >= iMinimo);
            }

            return contratos.Count(c => c.Monto >= iMinimo && c.Monto < iMaximo);
        }
        public int CalcularPorcentajeContratosMonto(int iMinimo, int iMaximo, DateTime dFecha1, DateTime dFecha2)
        {
            var contratos = ListarContratosFechas(dFecha1, dFecha2);

            int total = contratos.Count;
            if (total == 0)
                return 0;

            int cantidadEnRango;

            if (iMaximo == 0)
            {
                cantidadEnRango = contratos.Count(c => c.Monto >= iMinimo);
            }
            else
            {
                cantidadEnRango = contratos.Count(c => c.Monto >= iMinimo && c.Monto < iMaximo);
            }

            int porcentaje = (int)Math.Round((decimal)cantidadEnRango / total * 100, MidpointRounding.AwayFromZero);

            return porcentaje;
        }

    }
}
