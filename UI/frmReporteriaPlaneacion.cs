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
    public partial class frmReporteriaPlaneacion : Form
    {
        BLLProyecto gestorProyectos;
        BEProyecto oProyecto;
        List<BEProyecto> lProyectos;
        DateTime dFechaInicial;
        DateTime dFechaFinal;
        public frmReporteriaPlaneacion()
        {
            InitializeComponent();
            gestorProyectos = new BLLProyecto();
            oProyecto = new BEProyecto();
            lProyectos= new List<BEProyecto>();
            dFechaInicial = new DateTime();
            dFechaFinal = new DateTime();
        }
        #region Métodos
        public void CargarDistribucionEstado()
        {
            lProyectos = gestorProyectos.ListarProyectosFechas(dFechaInicial, dFechaFinal);

            var resumenPorEstado = lProyectos
                .GroupBy(p => p.Estado.ToString())
                .Select(g => new
                {
                    Estado = g.Key,
                    Cantidad = g.Count()
                })
                .OrderByDescending(r => r.Cantidad)
                .ToList();

            int total = resumenPorEstado.Sum(r => r.Cantidad);

            // Chart 1, cantidades
            chtDistribucionEstadoCantidad.Series.Clear();
            Series serieCantidad = new Series("Cantidad");
            serieCantidad.ChartType = SeriesChartType.Column;
            serieCantidad.XValueMember = "Estado";
            serieCantidad.YValueMembers = "Cantidad";
            serieCantidad.Color = Color.FromArgb(254, 119, 67);
            serieCantidad.IsValueShownAsLabel = true; // muestra etiquetas
            chtDistribucionEstadoCantidad.Series.Add(serieCantidad);
            chtDistribucionEstadoCantidad.DataSource = resumenPorEstado;
            chtDistribucionEstadoCantidad.DataBind();

            chtDistribucionEstadoCantidad.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            //chtDistribucionEstadoCantidad.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            // Chart 2, porcentajes
            chtDistribucionEstadoPorcentaje.Series.Clear();

            var resumenPorcentajes = resumenPorEstado
                .Select(r => new
                {
                    r.Estado,
                    Porcentaje = (decimal)r.Cantidad / total
                })
                .ToList();

            Series seriePorcentaje = new Series("Porcentaje");
            seriePorcentaje.ChartType = SeriesChartType.Pie;
            seriePorcentaje.Color = Color.FromArgb(254, 119, 67);
            seriePorcentaje.IsValueShownAsLabel = true; // muestra etiquetas
            seriePorcentaje.LabelFormat = "P0"; // formato de porcentaje
            seriePorcentaje.XValueMember = "Estado";
            seriePorcentaje.YValueMembers = "Porcentaje";

            chtDistribucionEstadoPorcentaje.Series.Add(seriePorcentaje);
            chtDistribucionEstadoPorcentaje.DataSource = resumenPorcentajes;
            chtDistribucionEstadoPorcentaje.DataBind();

            chtDistribucionEstadoPorcentaje.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chtDistribucionEstadoPorcentaje.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        public void CargarDistribucionHorasEstimadas()
        {
            lProyectos = gestorProyectos.ListarProyectosFechas(dFechaInicial, dFechaFinal);

            // Clasificacion x rangos
            var resumenPorRango = lProyectos
                .GroupBy(p =>
                {
                    if (p.HorasEstimadas < 100)
                        return "0-100";
                    else if (p.HorasEstimadas < 250)
                        return "100-250";
                    else if (p.HorasEstimadas < 500)
                        return "250-500";
                    else if (p.HorasEstimadas < 1000)
                        return "500-1000";
                    else
                        return "+1000";
                })
                .Select(g => new
                {
                    Rango = g.Key,
                    Cantidad = g.Count()
                })
                .OrderBy(r => r.Rango)
                .ToList();

            int total = resumenPorRango.Sum(r => r.Cantidad);

            // Chart 1, cantidades
            chtDistribucionEstimadasCantidad.Series.Clear();
            Series serieCantidad = new Series("Cantidad");
            serieCantidad.ChartType = SeriesChartType.Column;
            serieCantidad.XValueMember = "Rango";
            serieCantidad.YValueMembers = "Cantidad";
            serieCantidad.Color = Color.FromArgb(254, 119, 67);
            serieCantidad.IsValueShownAsLabel = true; // muestra etiquetas
            chtDistribucionEstimadasCantidad.Series.Add(serieCantidad);
            chtDistribucionEstimadasCantidad.DataSource = resumenPorRango;
            chtDistribucionEstimadasCantidad.DataBind();

            chtDistribucionEstimadasCantidad.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chtDistribucionEstimadasCantidad.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            // Chart 2, porcentajes
            chtDistribucionEstimadasPorcentaje.Series.Clear();

            var resumenPorcentajes = resumenPorRango
                .Select(r => new
                {
                    r.Rango,
                    Porcentaje = (decimal)r.Cantidad / total
                })
                .ToList();

            Series seriePorcentaje = new Series("Porcentaje");
            seriePorcentaje.ChartType = SeriesChartType.Pie;
            seriePorcentaje.Color = Color.FromArgb(254, 119, 67);
            seriePorcentaje.IsValueShownAsLabel = true;
            seriePorcentaje.LabelFormat = "P0";
            seriePorcentaje.XValueMember = "Rango";
            seriePorcentaje.YValueMembers = "Porcentaje";

            chtDistribucionEstimadasPorcentaje.Series.Add(seriePorcentaje);
            chtDistribucionEstimadasPorcentaje.DataSource = resumenPorcentajes;
            chtDistribucionEstimadasPorcentaje.DataBind();

            chtDistribucionEstimadasPorcentaje.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chtDistribucionEstimadasPorcentaje.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        public void CargarHitosProyecto(BEProyecto oProyecto)
        {
            // Validación por si el proyecto no tiene hitos
            if (oProyecto.Hitos == null || oProyecto.Hitos.Count == 0)
            {
                chtHitosProyectoCantidad.Series.Clear();
                chtHitosProyectoPorcentaje.Series.Clear();
                return;
            }


            var resumenPorEstadoHito = oProyecto.Hitos
                .GroupBy(h => h.Alcanzado ? "Alcanzado" : "No Alcanzado")
                .Select(g => new
                {
                    Estado = g.Key,
                    Cantidad = g.Count()
                })
                .OrderByDescending(r => r.Cantidad)
                .ToList();

            int total = resumenPorEstadoHito.Sum(r => r.Cantidad);

            // Chart 1, cantidades
            chtHitosProyectoCantidad.Series.Clear();
            Series serieCantidad = new Series("Cantidad");
            serieCantidad.ChartType = SeriesChartType.Column;
            serieCantidad.XValueMember = "Estado";
            serieCantidad.YValueMembers = "Cantidad";
            serieCantidad.Color = Color.FromArgb(254, 119, 67);
            serieCantidad.IsValueShownAsLabel = true; // muestra etiquetas

            chtHitosProyectoCantidad.Series.Add(serieCantidad);
            chtHitosProyectoCantidad.DataSource = resumenPorEstadoHito;
            chtHitosProyectoCantidad.DataBind();

            chtHitosProyectoCantidad.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            // Chart 2, porcentajes
            chtHitosProyectoPorcentaje.Series.Clear();

            var resumenPorcentajes = resumenPorEstadoHito
                .Select(r => new
                {
                    r.Estado,
                    Porcentaje = (decimal)r.Cantidad / total
                })
                .ToList();

            Series seriePorcentaje = new Series("Porcentaje");
            seriePorcentaje.ChartType = SeriesChartType.Doughnut;
            seriePorcentaje.Color = Color.FromArgb(254, 119, 67);
            seriePorcentaje.IsValueShownAsLabel = true; // muestra etiquetas
            seriePorcentaje.LabelFormat = "P0"; // formato de porcentaje
            seriePorcentaje.XValueMember = "Estado";
            seriePorcentaje.YValueMembers = "Porcentaje";

            chtHitosProyectoPorcentaje.Series.Add(seriePorcentaje);
            chtHitosProyectoPorcentaje.DataSource = resumenPorcentajes;
            chtHitosProyectoPorcentaje.DataBind();

            chtHitosProyectoPorcentaje.ChartAreas[0].AxisY.LabelStyle.Format = "P0";
            chtHitosProyectoPorcentaje.ChartAreas[0].AxisY.Maximum = 1; // 100%
            chtHitosProyectoPorcentaje.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        }

        public void CargarFasesProyecto(BEProyecto oProyecto)
        {
            // --- Validación por si el proyecto no tiene fases ---
            if (oProyecto.Fases == null || oProyecto.Fases.Count == 0)
            {
                chtFasesProyectoCantidad.Series.Clear();
                chtFasesProyectoPorcentaje.Series.Clear();
                return;
            }

            var resumenPorEstadoFase = oProyecto.Fases
                .GroupBy(f => f.Estado.ToString())
                .Select(g => new
                {
                    Estado = g.Key,
                    Cantidad = g.Count()
                })
                .OrderByDescending(r => r.Cantidad)
                .ToList();

            int total = resumenPorEstadoFase.Sum(r => r.Cantidad);

            // Chart 1, cantidades
            chtFasesProyectoCantidad.Series.Clear();
            Series serieCantidad = new Series("Cantidad");
            serieCantidad.ChartType = SeriesChartType.Column;
            serieCantidad.XValueMember = "Estado";
            serieCantidad.YValueMembers = "Cantidad";
            serieCantidad.Color = Color.FromArgb(254, 119, 67);
            serieCantidad.IsValueShownAsLabel = true; // muestra etiquetas

            chtFasesProyectoCantidad.Series.Add(serieCantidad);
            chtFasesProyectoCantidad.DataSource = resumenPorEstadoFase;
            chtFasesProyectoCantidad.DataBind();

            chtFasesProyectoCantidad.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            // Chart 2, porcentajes
            chtFasesProyectoPorcentaje.Series.Clear();

            var resumenPorcentajes = resumenPorEstadoFase
                .Select(r => new
                {
                    r.Estado,
                    Porcentaje = (decimal)r.Cantidad / total
                })
                .ToList();

            Series seriePorcentaje = new Series("Porcentaje");
            seriePorcentaje.ChartType = SeriesChartType.Doughnut;
            seriePorcentaje.Color = Color.FromArgb(254, 119, 67);
            seriePorcentaje.IsValueShownAsLabel = true; // muestra etiquetas
            seriePorcentaje.LabelFormat = "P0"; // formato de porcentaje
            seriePorcentaje.XValueMember = "Estado";
            seriePorcentaje.YValueMembers = "Porcentaje";

            chtFasesProyectoPorcentaje.Series.Add(seriePorcentaje);
            chtFasesProyectoPorcentaje.DataSource = resumenPorcentajes;
            chtFasesProyectoPorcentaje.DataBind();

            chtFasesProyectoPorcentaje.ChartAreas[0].AxisY.LabelStyle.Format = "P0";
            chtFasesProyectoPorcentaje.ChartAreas[0].AxisY.Maximum = 1; // 100%
            chtFasesProyectoPorcentaje.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        }

        void CargarDatosProyecto(BEProyecto oProyecto)
        {
            lblHorasEstimadas.Text=oProyecto.HorasEstimadas.ToString();
            lblHorasCompletadas.Text=oProyecto.HorasCompletadas.ToString();
            lblPorcentajeAvance.Text = "%"+((oProyecto.HorasCompletadas / oProyecto.HorasEstimadas) * 100).ToString("F1"); //0,1 (1 decimal)
            lblColaboradores.Text=oProyecto.Colaboradores.Count.ToString();
        }
        public BEProyecto SeleccionarProyecto()
        {
            oProyecto = (BEProyecto)ltbListaProyectos.SelectedItem;
            return oProyecto;
        }

        public void CargarLtbProyectos()
        {
            ltbListaProyectos.DataSource = gestorProyectos.ListarProyectosFechas(dFechaInicial, dFechaFinal);
        }
        public void ColorearBotonesFechas()
        {
            btnPersonalizado.FillColor=Color.FromArgb(68, 125, 155);
            btn30dias.FillColor=Color.FromArgb(68, 125, 155);
            btn7dias.FillColor=Color.FromArgb(68, 125, 155);
            btnAno.FillColor=Color.FromArgb(68, 125, 155);
            btnMes.FillColor=Color.FromArgb(68, 125, 155);
        }

        public void EsconderLabels()
        {
            lblColaboradores.Text = null;
            lblHorasCompletadas.Text = null;
            lblHorasEstimadas.Text = null;
            lblPorcentajeAvance.Text = null;
        }

        public void LimpiarCharts(BEProyecto oProyecto)
        {
            if (oProyecto==null)
            {
                chtFasesProyectoCantidad.Series.Clear();
                chtFasesProyectoPorcentaje.Series.Clear();
                chtHitosProyectoCantidad.Series.Clear();
                chtHitosProyectoPorcentaje.Series.Clear();
            }
        }
        #endregion
        #region Eventos
        private void frmReporteriaPlaneacion_Load(object sender, EventArgs e)
        {
            try
            {
                EsconderLabels();
                dtpFechaInicial.Value=DateTime.Today;
                dtpFechaFinal.Value=DateTime.Today;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }



        private void ltbListaProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                oProyecto = SeleccionarProyecto();
                CargarHitosProyecto(oProyecto);
                CargarFasesProyecto(oProyecto);
                CargarDatosProyecto(oProyecto);
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

                CargarDistribucionEstado();
                CargarDistribucionHorasEstimadas();
                CargarLtbProyectos();
                LimpiarCharts(SeleccionarProyecto());
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

                CargarDistribucionEstado();
                CargarDistribucionHorasEstimadas();
                CargarLtbProyectos();
                LimpiarCharts(SeleccionarProyecto());

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

                CargarDistribucionEstado();
                CargarDistribucionHorasEstimadas();
                CargarLtbProyectos();
                LimpiarCharts(SeleccionarProyecto());

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

                CargarDistribucionEstado();
                CargarDistribucionHorasEstimadas();
                CargarLtbProyectos();
                LimpiarCharts(SeleccionarProyecto());

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

                CargarDistribucionEstado();
                CargarDistribucionHorasEstimadas();
                CargarLtbProyectos();
                LimpiarCharts(SeleccionarProyecto());

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
