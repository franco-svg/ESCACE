using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UI
{
    public partial class frmReporteriaAdministracion : Form
    {
        BLLContrato gestorContratos;
        BLLFichaProyecto gestorFichas;
        BLLCliente gestorClientes;
        List<BECliente> lClientes;
        DateTime dFechaInicial;
        DateTime dFechaFinal;
        public frmReporteriaAdministracion()
        {
            InitializeComponent();
            gestorContratos = new BLLContrato();
            gestorFichas=new BLLFichaProyecto();
            gestorClientes = new BLLCliente();
            lClientes = new List<BECliente>();
            dFechaInicial = new DateTime();
            dFechaFinal = new DateTime();
        }

        #region Métodos
        public void CargarDistribucionIndustria()
        {
            lClientes = gestorContratos.ListarClientesContratosFechas(dFechaInicial,dFechaFinal);

            var resumenPorIndustria = lClientes
                .GroupBy(c => c.Industria.ToString())
                .Select(g => new
                {
                    Industria = g.Key,
                    Cantidad = g.Count()
                })
                .OrderByDescending(r => r.Cantidad)
                .ToList();

            int total = resumenPorIndustria.Sum(r => r.Cantidad);

            // Chart 1, cantidades
            chtDistribucionIndustriasCantidad.Series.Clear();
            Series serieCantidad = new Series("Cantidad");
            serieCantidad.ChartType = SeriesChartType.Column;
            serieCantidad.XValueMember = "Industria";
            serieCantidad.YValueMembers = "Cantidad";
            serieCantidad.Color = Color.FromArgb(254, 119, 67);
            serieCantidad.IsValueShownAsLabel = true; // muestra etiquetas
            chtDistribucionIndustriasCantidad.Series.Add(serieCantidad);
            chtDistribucionIndustriasCantidad.DataSource = resumenPorIndustria;
            chtDistribucionIndustriasCantidad.DataBind();

            chtDistribucionIndustriasCantidad.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            //chtDistribucionIndustriasCantidad.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            // Chart 2, porcentajes
            chtDistribucionIndustriasPorcentaje.Series.Clear();

            var resumenPorcentajes = resumenPorIndustria
                .Select(r => new
                {
                    r.Industria,
                    Porcentaje = (decimal)r.Cantidad / total
                })
                .ToList();

            Series seriePorcentaje = new Series("Porcentaje");
            seriePorcentaje.ChartType = SeriesChartType.Pie;
            seriePorcentaje.Color = Color.FromArgb(254, 119, 67);
            seriePorcentaje.IsValueShownAsLabel = true; // muestra etiquetas
            seriePorcentaje.LabelFormat = "P0"; // formato de porcentaje
            seriePorcentaje.XValueMember = "Industria";
            seriePorcentaje.YValueMembers = "Porcentaje";

            chtDistribucionIndustriasPorcentaje.Series.Add(seriePorcentaje);
            chtDistribucionIndustriasPorcentaje.DataSource = resumenPorcentajes;
            chtDistribucionIndustriasPorcentaje.DataBind();

            chtDistribucionIndustriasPorcentaje.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chtDistribucionIndustriasPorcentaje.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        public void CargarDistribucionPais()
        {
            lClientes = gestorContratos.ListarClientesContratosFechas(dFechaInicial, dFechaFinal);

            var resumenPorPais = lClientes
                .GroupBy(c => c.Pais.ToString())
                .Select(g => new
                {
                    Pais = g.Key,
                    Cantidad = g.Count()
                })
                .OrderByDescending(r => r.Cantidad)
                .ToList();

            int total = resumenPorPais.Sum(r => r.Cantidad);

            // Chart 1, cantidades
            chtDistribucionPaisCantidad.Series.Clear();
            Series serieCantidad = new Series("Cantidad");
            serieCantidad.ChartType = SeriesChartType.Column;
            serieCantidad.XValueMember = "Pais";
            serieCantidad.YValueMembers = "Cantidad";
            serieCantidad.Color = Color.FromArgb(254, 119, 67);
            serieCantidad.IsValueShownAsLabel = true; // muestra etiquetas
            chtDistribucionPaisCantidad.Series.Add(serieCantidad);
            chtDistribucionPaisCantidad.DataSource = resumenPorPais;
            chtDistribucionPaisCantidad.DataBind();

            chtDistribucionPaisCantidad.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            // chtDistribucionPaisCantidad.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            // Chart 2, porcentaje
            chtDistribucionPaisPorcentaje.Series.Clear();

            var resumenPorcentajes = resumenPorPais
                .Select(r => new
                {
                    r.Pais,
                    Porcentaje = (decimal)r.Cantidad / total
                })
                .ToList();

            Series seriePorcentaje = new Series("Porcentaje");
            seriePorcentaje.ChartType = SeriesChartType.Pie;
            seriePorcentaje.Color = Color.FromArgb(254, 119, 67);
            seriePorcentaje.IsValueShownAsLabel = true; // muestra etiquetas
            seriePorcentaje.LabelFormat = "P0"; // formato de porcentaje
            seriePorcentaje.XValueMember = "Pais";
            seriePorcentaje.YValueMembers = "Porcentaje";

            chtDistribucionPaisPorcentaje.Series.Add(seriePorcentaje);
            chtDistribucionPaisPorcentaje.DataSource = resumenPorcentajes;
            chtDistribucionPaisPorcentaje.DataBind();

            chtDistribucionPaisPorcentaje.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            //chtDistribucionPaisPorcentaje.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        public void ColorearBotonesMonto()
        {
            btnMontos1.FillColor=Color.FromArgb(68, 125, 155);
            btnMontos2.FillColor=Color.FromArgb(68, 125, 155);
            btnMontos3.FillColor=Color.FromArgb(68, 125, 155);
            btnMontos4.FillColor=Color.FromArgb(68, 125, 155);
            btnMontos5.FillColor=Color.FromArgb(68, 125, 155);
        }
        public void ColorearBotonesHoras()
        {
            btnHoras1.FillColor=Color.FromArgb(68, 125, 155);
            btnHoras2.FillColor=Color.FromArgb(68, 125, 155);
            btnHoras3.FillColor=Color.FromArgb(68, 125, 155);
            btnHoras4.FillColor=Color.FromArgb(68, 125, 155);
            btnHoras5.FillColor=Color.FromArgb(68, 125, 155);
        }

        public void ColorearBotonesFechas()
        {
            btnPersonalizado.FillColor=Color.FromArgb(68, 125, 155);
            btn30dias.FillColor=Color.FromArgb(68, 125, 155);
            btn7dias.FillColor=Color.FromArgb(68, 125, 155);
            btnAno.FillColor=Color.FromArgb(68, 125, 155);
            btnMes.FillColor=Color.FromArgb(68, 125, 155);
        }

        public void ValidarFiltroSeleccionado()
        {
            if (dFechaInicial==DateTime.MinValue||dFechaFinal==DateTime.MinValue)
            {
                throw new InvalidOperationException("Debe seleccionar un filtro de fecha previo a seguir especificando demas filtros");
            }
        }
        public void EsconderLabels()
        {
            lblCantidadMonto.Text = null;
            lblPorcentajeMonto.Text = null;
            lblCantidadHoras.Text = null;
            lblPorcentajeHoras.Text = null;
        }
        #endregion
        #region Eventos
        private void frmReporteriaAdministracion_Load(object sender, EventArgs e)
        {
            try
            {

                EsconderLabels();
                dtpFechaInicial.Value=DateTime.Today;
                dtpFechaFinal.Value=DateTime.Today;

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnMontos1_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarFiltroSeleccionado();
                ColorearBotonesMonto();
                btnMontos1.FillColor = Color.FromArgb(254, 119, 67);

                int iMinimo = 0;
                int iMaximo = 5000;
                int iCantidad = gestorContratos.CalcularCantidadContratosMonto(iMinimo, iMaximo, dFechaInicial, dFechaFinal);
                int iPorcentaje = gestorContratos.CalcularPorcentajeContratosMonto(iMinimo, iMaximo, dFechaInicial, dFechaFinal);

                lblCantidadMonto.Text = $@"{iCantidad}";
                lblPorcentajeMonto.Text = $@"%{iPorcentaje}";
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnMontos2_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarFiltroSeleccionado();
                ColorearBotonesMonto();
                btnMontos2.FillColor = Color.FromArgb(254, 119, 67);

                int iMinimo = 5000;
                int iMaximo = 10000;
                int iCantidad = gestorContratos.CalcularCantidadContratosMonto(iMinimo, iMaximo, dFechaInicial, dFechaFinal);
                int iPorcentaje = gestorContratos.CalcularPorcentajeContratosMonto(iMinimo, iMaximo, dFechaInicial, dFechaFinal);

                lblCantidadMonto.Text = $@"{iCantidad}";
                lblPorcentajeMonto.Text = $@"%{iPorcentaje}";
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnMontos3_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarFiltroSeleccionado();
                ColorearBotonesMonto();
                btnMontos3.FillColor = Color.FromArgb(254, 119, 67);

                int iMinimo = 10000;
                int iMaximo = 20000;
                int iCantidad = gestorContratos.CalcularCantidadContratosMonto(iMinimo, iMaximo, dFechaInicial, dFechaFinal);
                int iPorcentaje = gestorContratos.CalcularPorcentajeContratosMonto(iMinimo, iMaximo, dFechaInicial, dFechaFinal);

                lblCantidadMonto.Text = $@"{iCantidad}";
                lblPorcentajeMonto.Text = $@"%{iPorcentaje}";
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnMontos4_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarFiltroSeleccionado();
                ColorearBotonesMonto();
                btnMontos4.FillColor = Color.FromArgb(254, 119, 67);

                int iMinimo = 20000;
                int iMaximo = 40000;
                int iCantidad = gestorContratos.CalcularCantidadContratosMonto(iMinimo, iMaximo, dFechaInicial, dFechaFinal);
                int iPorcentaje = gestorContratos.CalcularPorcentajeContratosMonto(iMinimo, iMaximo, dFechaInicial, dFechaFinal);

                lblCantidadMonto.Text = $@"{iCantidad}";
                lblPorcentajeMonto.Text = $@"%{iPorcentaje}";
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnMontos5_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarFiltroSeleccionado();
                ColorearBotonesMonto();
                btnMontos5.FillColor = Color.FromArgb(254, 119, 67);

                int iMinimo = 40000;
                int iMaximo = 0;
                int iCantidad = gestorContratos.CalcularCantidadContratosMonto(iMinimo, iMaximo, dFechaInicial, dFechaFinal);
                int iPorcentaje = gestorContratos.CalcularPorcentajeContratosMonto(iMinimo, iMaximo, dFechaInicial, dFechaFinal);

                lblCantidadMonto.Text = $@"{iCantidad}";
                lblPorcentajeMonto.Text = $@"%{iPorcentaje}";
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnHoras1_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarFiltroSeleccionado();
                ColorearBotonesHoras();
                btnHoras1.FillColor = Color.FromArgb(254, 119, 67);

                int iMinimo = 0;
                int iMaximo = 100;
                int iCantidad = gestorFichas.CalcularCantidadFichasHoras(iMinimo, iMaximo, dFechaInicial, dFechaFinal);
                int iPorcentaje = gestorFichas.CalcularPorcentajeFichasHoras(iMinimo, iMaximo, dFechaInicial, dFechaFinal);

                lblCantidadHoras.Text = $@"{iCantidad}";
                lblPorcentajeHoras.Text = $@"%{iPorcentaje}";
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnHoras2_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarFiltroSeleccionado();
                ColorearBotonesHoras();
                btnHoras2.FillColor = Color.FromArgb(254, 119, 67);

                int iMinimo = 100;
                int iMaximo = 250;
                int iCantidad = gestorFichas.CalcularCantidadFichasHoras(iMinimo, iMaximo, dFechaInicial, dFechaFinal);
                int iPorcentaje = gestorFichas.CalcularPorcentajeFichasHoras(iMinimo, iMaximo, dFechaInicial, dFechaFinal);

                lblCantidadHoras.Text = $@"{iCantidad}";
                lblPorcentajeHoras.Text = $@"%{iPorcentaje}";
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnHoras3_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarFiltroSeleccionado();
                ColorearBotonesHoras();
                btnHoras3.FillColor = Color.FromArgb(254, 119, 67);

                int iMinimo = 250;
                int iMaximo = 500;
                int iCantidad = gestorFichas.CalcularCantidadFichasHoras(iMinimo, iMaximo, dFechaInicial, dFechaFinal);
                int iPorcentaje = gestorFichas.CalcularPorcentajeFichasHoras(iMinimo, iMaximo, dFechaInicial, dFechaFinal);

                lblCantidadHoras.Text = $@"{iCantidad}";
                lblPorcentajeHoras.Text = $@"%{iPorcentaje}";
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnHoras4_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarFiltroSeleccionado();
                ColorearBotonesHoras();
                btnHoras4.FillColor = Color.FromArgb(254, 119, 67);

                int iMinimo = 500;
                int iMaximo = 1000;
                int iCantidad = gestorFichas.CalcularCantidadFichasHoras(iMinimo, iMaximo, dFechaInicial, dFechaFinal);
                int iPorcentaje = gestorFichas.CalcularPorcentajeFichasHoras(iMinimo, iMaximo, dFechaInicial, dFechaFinal);

                lblCantidadHoras.Text = $@"{iCantidad}";
                lblPorcentajeHoras.Text = $@"%{iPorcentaje}";
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnHoras5_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarFiltroSeleccionado();
                ColorearBotonesHoras();
                btnHoras5.FillColor = Color.FromArgb(254, 119, 67);

                int iMinimo = 1000;
                int iMaximo = 0;
                int iCantidad = gestorFichas.CalcularCantidadFichasHoras(iMinimo, iMaximo, dFechaInicial, dFechaFinal);
                int iPorcentaje = gestorFichas.CalcularPorcentajeFichasHoras(iMinimo, iMaximo, dFechaInicial, dFechaFinal);

                lblCantidadHoras.Text = $@"{iCantidad}";
                lblPorcentajeHoras.Text = $@"%{iPorcentaje}";
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }


        private void btnPersonalizado_Click(object sender, EventArgs e)
        {
            try
            {
                ColorearBotonesFechas();
                UIHelper.ValidarDiferenciaFechasFiltros(dtpFechaInicial.Value, dtpFechaFinal.Value);
                btnPersonalizado.FillColor=Color.FromArgb(254, 119, 67);
                dFechaInicial=dtpFechaInicial.Value;
                dFechaFinal=dtpFechaFinal.Value;
                EsconderLabels();
                ColorearBotonesMonto();
                ColorearBotonesHoras();

                CargarDistribucionIndustria();
                CargarDistribucionPais();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btn30dias_Click(object sender, EventArgs e)
        {
            try
            {
                ColorearBotonesFechas();
                btn30dias.FillColor=Color.FromArgb(254, 119, 67);
                dFechaInicial=DateTime.Now.Subtract(TimeSpan.FromDays(30));
                dFechaFinal=DateTime.Now;
                EsconderLabels();
                ColorearBotonesMonto();
                ColorearBotonesHoras();

                CargarDistribucionIndustria();
                CargarDistribucionPais();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btn7dias_Click(object sender, EventArgs e)
        {
            try
            {
                ColorearBotonesFechas();
                btn7dias.FillColor=Color.FromArgb(254, 119, 67);
                dFechaInicial=DateTime.Now.Subtract(TimeSpan.FromDays(7));
                dFechaFinal=DateTime.Now;
                EsconderLabels();
                ColorearBotonesMonto();
                ColorearBotonesHoras();

                CargarDistribucionIndustria();
                CargarDistribucionPais();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnAno_Click(object sender, EventArgs e)
        {
            try
            {
                ColorearBotonesFechas();
                btnAno.FillColor=Color.FromArgb(254, 119, 67);
                dFechaInicial = new DateTime(DateTime.Now.Year, 1, 1);
                dFechaFinal = new DateTime(DateTime.Now.Year, 12, 31);
                EsconderLabels();
                ColorearBotonesMonto();
                ColorearBotonesHoras();

                CargarDistribucionIndustria();
                CargarDistribucionPais();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            try
            {
                ColorearBotonesFechas();
                btnMes.FillColor=Color.FromArgb(254, 119, 67);
                dFechaInicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dFechaFinal=dFechaInicial.AddMonths(1).AddDays(-1);
                EsconderLabels();
                ColorearBotonesMonto();
                ColorearBotonesHoras();

                CargarDistribucionIndustria();
                CargarDistribucionPais();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void dtpFechaInicial_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                btnPersonalizado.FillColor=Color.FromArgb(68, 125, 155);
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void dtpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                btnPersonalizado.FillColor=Color.FromArgb(68, 125, 155);
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }

}
