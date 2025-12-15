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
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UI
{
    public partial class frmReporteriaRRHH : Form
    {

        BLLColaborador gestorColaboradores;
        BLLRol gestorRoles;
        BERol oRol;
        BEColaborador oColaborador;

        List<BEColaborador> lColaboradores;
        List<BERol> lRoles;

        public frmReporteriaRRHH()
        {
            InitializeComponent();
            gestorColaboradores = new BLLColaborador();
            gestorRoles = new BLLRol();
            oRol = new BERol();
            oColaborador = new BEColaborador();
            lColaboradores= new List<BEColaborador>();
            lRoles = new List<BERol>();
        }
        #region Métodos
        public void CargarDistribucionSeniority()
        {
            lColaboradores = gestorColaboradores.ListarColaboradores();

            var resumenPorSeniority = lColaboradores
                .GroupBy(c => c.Seniority.ToString())
                .Select(g => new
                {
                    Seniority = g.Key,
                    Cantidad = g.Count()
                })
                .OrderByDescending(r => r.Cantidad)
                .ToList();

            int total = resumenPorSeniority.Sum(r => r.Cantidad);

            // Chart 1, cantidades
            chtDistribucionSeniorityCantidad.Series.Clear();
            Series serieCantidad = new Series("Cantidad");
            serieCantidad.ChartType = SeriesChartType.Column;
            serieCantidad.XValueMember = "Seniority";
            serieCantidad.YValueMembers = "Cantidad";
            serieCantidad.Color = Color.FromArgb(254, 119, 67);
            serieCantidad.IsValueShownAsLabel = true; // muestra etiquetas
            chtDistribucionSeniorityCantidad.Series.Add(serieCantidad);
            chtDistribucionSeniorityCantidad.DataSource = resumenPorSeniority;
            chtDistribucionSeniorityCantidad.DataBind();

            chtDistribucionSeniorityCantidad.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            // Chart 2, porcentajes
            chtDistribucionSeniorityPorcentaje.Series.Clear();

            var resumenPorcentajes = resumenPorSeniority
                .Select(r => new
                {
                    r.Seniority,
                    Porcentaje = (decimal)r.Cantidad / total
                })
                .ToList();

            Series seriePorcentaje = new Series("Porcentaje");
            seriePorcentaje.ChartType = SeriesChartType.Pie;
            seriePorcentaje.Color = Color.FromArgb(254, 119, 67);
            seriePorcentaje.IsValueShownAsLabel = true; // muestra etiquetas
            seriePorcentaje.LabelFormat = "P0"; // formato de porcentaje
            seriePorcentaje.XValueMember = "Seniority";
            seriePorcentaje.YValueMembers = "Porcentaje";

            chtDistribucionSeniorityPorcentaje.Series.Add(seriePorcentaje);
            chtDistribucionSeniorityPorcentaje.DataSource = resumenPorcentajes;
            chtDistribucionSeniorityPorcentaje.DataBind();

            chtDistribucionSeniorityPorcentaje.ChartAreas[0].AxisY.LabelStyle.Format = "P0";
            chtDistribucionSeniorityPorcentaje.ChartAreas[0].AxisY.Maximum = 1; // 100%
            chtDistribucionSeniorityPorcentaje.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        }


        public void CargarDistribucionRol()
        {
            lColaboradores = gestorColaboradores.ListarColaboradores();

            var resumenPorRol = lColaboradores
                .GroupBy(c => c.Rol.ToString())
                .Select(g => new
                {
                    Rol = g.Key,
                    Cantidad = g.Count()
                })
                .OrderByDescending(r => r.Cantidad)
                .ToList();

            int total = resumenPorRol.Sum(r => r.Cantidad);

            // Chart 1, cantidades
            chtDistribucionRolCantidad.Series.Clear();
            Series serieCantidad = new Series("Cantidad");
            serieCantidad.ChartType = SeriesChartType.Column;
            serieCantidad.XValueMember = "Rol";
            serieCantidad.YValueMembers = "Cantidad";
            serieCantidad.Color = Color.FromArgb(254, 119, 67);
            serieCantidad.IsValueShownAsLabel = true; // muestra etiquetas
            chtDistribucionRolCantidad.Series.Add(serieCantidad);
            chtDistribucionRolCantidad.DataSource = resumenPorRol;
            chtDistribucionRolCantidad.DataBind();

            chtDistribucionRolCantidad.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            // Chart 2, porcentajes
            chtDistribucionRolPorcentaje.Series.Clear();

            var resumenPorcentajes = resumenPorRol
                .Select(r => new
                {
                    r.Rol,
                    Porcentaje = (decimal)r.Cantidad / total
                })
                .ToList();

            Series seriePorcentaje = new Series("Porcentaje");
            seriePorcentaje.ChartType = SeriesChartType.Pie;
            seriePorcentaje.Color = Color.FromArgb(254, 119, 67);
            seriePorcentaje.IsValueShownAsLabel = true; // muestra etiquetas
            seriePorcentaje.LabelFormat = "P0"; // formato de porcentaje
            seriePorcentaje.XValueMember = "Rol";
            seriePorcentaje.YValueMembers = "Porcentaje";

            chtDistribucionRolPorcentaje.Series.Add(seriePorcentaje);
            chtDistribucionRolPorcentaje.DataSource = resumenPorcentajes;
            chtDistribucionRolPorcentaje.DataBind();

            chtDistribucionRolPorcentaje.ChartAreas[0].AxisY.LabelStyle.Format = "P0";
            chtDistribucionRolPorcentaje.ChartAreas[0].AxisY.Maximum = 1; // 100%
            chtDistribucionRolPorcentaje.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        }

        public void CargarSeniorityRolSeleccionado(BERol oRol)
        {
            lColaboradores = gestorColaboradores.ListarColaboradores();

            // Filtro x rol
            var colaboradoresPorRol = lColaboradores
                .Where(c => c.Rol.Id == oRol.Id)
                .ToList();

            if (colaboradoresPorRol.Count == 0)
            {
                // Si no hay colaboradores para ese rol, limpiamos ambos gráficos
                chtSeniorityRolCantidadd.Series.Clear();
                chtSeniorityRolPorcentaje.Series.Clear();
                return;
            }

            var resumenPorSeniority = colaboradoresPorRol
                .GroupBy(c => c.Seniority.ToString())
                .Select(g => new
                {
                    Seniority = g.Key,
                    Cantidad = g.Count()
                })
                .OrderByDescending(r => r.Cantidad)
                .ToList();

            int total = resumenPorSeniority.Sum(r => r.Cantidad);

            // Chart 1, cantidades
            chtSeniorityRolCantidadd.Series.Clear();
            Series serieCantidad = new Series("Cantidad");
            serieCantidad.ChartType = SeriesChartType.Column;
            serieCantidad.XValueMember = "Seniority";
            serieCantidad.YValueMembers = "Cantidad";
            serieCantidad.Color = Color.FromArgb(254, 119, 67);
            serieCantidad.IsValueShownAsLabel = true; // muestra etiquetas

            chtSeniorityRolCantidadd.Series.Add(serieCantidad);
            chtSeniorityRolCantidadd.DataSource = resumenPorSeniority;
            chtSeniorityRolCantidadd.DataBind();

            chtSeniorityRolCantidadd.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            // Chart 2, porcentajes
            chtSeniorityRolPorcentaje.Series.Clear();

            var resumenPorcentajes = resumenPorSeniority
                .Select(r => new
                {
                    r.Seniority,
                    Porcentaje = (decimal)r.Cantidad / total
                })
                .ToList();

            Series seriePorcentaje = new Series("Porcentaje");
            seriePorcentaje.ChartType = SeriesChartType.Doughnut;
            seriePorcentaje.Color = Color.FromArgb(254, 119, 67);
            seriePorcentaje.IsValueShownAsLabel = true; // muestra etiquetas
            seriePorcentaje.LabelFormat = "P0"; // formato de porcentaje
            seriePorcentaje.XValueMember = "Seniority";
            seriePorcentaje.YValueMembers = "Porcentaje";

            chtSeniorityRolPorcentaje.Series.Add(seriePorcentaje);
            chtSeniorityRolPorcentaje.DataSource = resumenPorcentajes;
            chtSeniorityRolPorcentaje.DataBind();

            chtSeniorityRolPorcentaje.ChartAreas[0].AxisY.LabelStyle.Format = "P0";
            chtSeniorityRolPorcentaje.ChartAreas[0].AxisY.Maximum = 1; // 100%
            chtSeniorityRolPorcentaje.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        }



        public BERol SeleccionarRol()
        {
            oRol = (BERol)ltbListaRoles.SelectedItem;
            return oRol;
        }

        public BEColaborador SeleccionarColaborador()
        {
            oColaborador = (BEColaborador)ltbListaColaboradores.SelectedItem;
            return oColaborador;
        }

        public void ColorearBotonesProyectos()
        {
            btn0.FillColor=Color.FromArgb(68, 125, 155);
            btn1.FillColor=Color.FromArgb(68, 125, 155);
            btn2.FillColor=Color.FromArgb(68, 125, 155);
            btn3.FillColor=Color.FromArgb(68, 125, 155);
            btn4.FillColor=Color.FromArgb(68, 125, 155);
            btn5.FillColor=Color.FromArgb(68, 125, 155);
            btnMas5.FillColor=Color.FromArgb(68, 125, 155);

        }

        #endregion
        #region Eventos
        private void frmReporteriaRRHH_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDistribucionSeniority();
                CargarDistribucionRol();
                ltbListaRoles.DataSource = gestorRoles.ListarRoles();
                ltbListaColaboradores.DataSource = gestorColaboradores.ListarColaboradores();
                lblCantidad.Text = null;
                lblPorcentaje.Text = null;
                lblCantidadProyectosColaborador.Text = null;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void ltbListaRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarSeniorityRolSeleccionado(SeleccionarRol());
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            try
            {
                ColorearBotonesProyectos();
                btn0.FillColor = Color.FromArgb(254, 119, 67);

                int nProyectos = 0;
                int iCantidad = gestorColaboradores.ListarCantidadColaboradoresProyecto(nProyectos);
                int dPorcentaje = gestorColaboradores.CalcularPorcentajeColaboradoresConProyectos(nProyectos);

                lblCantidad.Text = $"{iCantidad} colaboradores no tienen proyectos asignados";
                lblPorcentaje.Text = $@"El %{dPorcentaje} de los colaboradores no tienen
proyectos asignados";
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                ColorearBotonesProyectos();
                btn1.FillColor = Color.FromArgb(254, 119, 67);

                int nProyectos = 1;
                int iCantidad = gestorColaboradores.ListarCantidadColaboradoresProyecto(nProyectos);
                int dPorcentaje = gestorColaboradores.CalcularPorcentajeColaboradoresConProyectos(nProyectos);

                lblCantidad.Text = $"{iCantidad} colaboradores tienen solamente 1 proyecto asignado";
                lblPorcentaje.Text = $@"El %{dPorcentaje} de los colaboradores tienen solamente 1 
proyecto asignado";
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                ColorearBotonesProyectos();
                btn2.FillColor = Color.FromArgb(254, 119, 67);

                int nProyectos = 2;
                int iCantidad = gestorColaboradores.ListarCantidadColaboradoresProyecto(nProyectos);
                int dPorcentaje = gestorColaboradores.CalcularPorcentajeColaboradoresConProyectos(nProyectos);

                lblCantidad.Text = $"{iCantidad} colaboradores tienen {nProyectos} proyectos asignados";
                lblPorcentaje.Text = $@"El %{dPorcentaje} de los colaboradores tienen {nProyectos}
proyectos asignados";
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                ColorearBotonesProyectos();
                btn3.FillColor = Color.FromArgb(254, 119, 67);

                int nProyectos = 3;
                int iCantidad = gestorColaboradores.ListarCantidadColaboradoresProyecto(nProyectos);
                int dPorcentaje = gestorColaboradores.CalcularPorcentajeColaboradoresConProyectos(nProyectos);

                lblCantidad.Text = $"{iCantidad} colaboradores tienen {nProyectos} proyectos asignados";
                lblPorcentaje.Text = $@"El %{dPorcentaje} de los colaboradores tienen {nProyectos}
proyectos asignados";
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            try
            {
                ColorearBotonesProyectos();
                btn4.FillColor = Color.FromArgb(254, 119, 67);

                int nProyectos = 4;
                int iCantidad = gestorColaboradores.ListarCantidadColaboradoresProyecto(nProyectos);
                int dPorcentaje = gestorColaboradores.CalcularPorcentajeColaboradoresConProyectos(nProyectos);

                lblCantidad.Text = $"{iCantidad} colaboradores tienen {nProyectos} proyectos asignados";
                lblPorcentaje.Text = $@"El %{dPorcentaje} de los colaboradores tienen {nProyectos}
proyectos asignados";
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            try
            {
                ColorearBotonesProyectos();
                btn5.FillColor = Color.FromArgb(254, 119, 67);

                int nProyectos = 5;
                int iCantidad = gestorColaboradores.ListarCantidadColaboradoresProyecto(nProyectos);
                int dPorcentaje = gestorColaboradores.CalcularPorcentajeColaboradoresConProyectos(nProyectos);

                lblCantidad.Text = $"{iCantidad} colaboradores tienen {nProyectos} proyectos asignados";
                lblPorcentaje.Text = $@"El %{dPorcentaje} de los colaboradores tienen {nProyectos}
proyectos asignados";
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnMas5_Click(object sender, EventArgs e)
        {
            try
            {
                ColorearBotonesProyectos();
                btnMas5.FillColor = Color.FromArgb(254, 119, 67);

                int nProyectos = 5;
                int iCantidad = gestorColaboradores.ListarCantidadColaboradoresProyecto(nProyectos, true);
                int dPorcentaje = gestorColaboradores.CalcularPorcentajeColaboradoresConProyectos(nProyectos, true);

                lblCantidad.Text = $"{iCantidad} colaboradores tienen más de {nProyectos} proyectos asignados";
                lblPorcentaje.Text = $@"El %{dPorcentaje} de los colaboradores tienen más de {nProyectos}
proyectos asignados";
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void ltbListaColaboradores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int iCantidad = gestorColaboradores.ListarCantidadProyectosColaborador(SeleccionarColaborador());
                lblCantidadProyectosColaborador.Text = $"{iCantidad}";
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
