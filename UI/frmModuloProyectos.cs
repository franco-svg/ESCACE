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

namespace UI
{
    public partial class frmModuloProyectos : Form
    {

        BLLProyecto gestorProyectos;
        BEProyecto oProyecto;
        public frmModuloProyectos()
        {
            InitializeComponent();
            gestorProyectos = new BLLProyecto();
            oProyecto= new BEProyecto();
        }

        #region Métodos
        public void ConfigurarEstiloDGV(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;

            // Encabezados
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(68, 125, 155);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor=Color.FromArgb(68, 125, 155);
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor=Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 11, FontStyle.Bold);

            // Filas normales
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(118, 175, 205);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font=new Font("Bahnschrift", 10, FontStyle.Regular);


            // Bordes
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

        }

        public BEProyecto SeleccionarProyecto()
        {

            oProyecto = (BEProyecto)dgvListaProyectos.CurrentRow.DataBoundItem;
            return oProyecto;
        }

        void CargarDgvProyectos()
        {
            this.dgvListaProyectos.DataSource=null;
            this.dgvListaProyectos.DataSource= gestorProyectos.ListarProyectos();
            this.dgvListaProyectos.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        void CargarLtbHitos(BEProyecto oProyecto)
        {
            this.ltbHitos.DataSource=null;
            this.ltbHitos.DataSource= oProyecto.Hitos;
        }

        void CargarTreeBacklog(BEProyecto oProyecto)
        {
            // Limpia el árbol antes de cargar
            tvwFasesTareas.Nodes.Clear();

            if (oProyecto == null || oProyecto.Fases == null)
                return;

            // Recorremos cada fase del proyecto
            foreach (var fase in oProyecto.Fases)
            {
                // Nodo principal: Fase
                TreeNode nodoFase = new TreeNode(fase.Titulo);

                // Agregamos las tareas de la fase como nodos hijos
                if (fase.Tareas != null)
                {
                    foreach (var tarea in fase.Tareas)
                    {
                        TreeNode nodoTarea = new TreeNode(tarea.Titulo);
                        nodoFase.Nodes.Add(nodoTarea);
                    }
                }

                // Agregamos la fase al árbol
                tvwFasesTareas.Nodes.Add(nodoFase);
            }

            // Expande el árbol completo
            tvwFasesTareas.ExpandAll();
        }

        public void VerificarSeleccionProyecto()
        {
            if (dgvListaProyectos.SelectedRows.Count==0)
            {
                throw new InvalidOperationException("Debe seleccionar un proyecto");
            }
        }

        public void PoblarInputs(BEProyecto oProyecto)
        {
            txtTitulo.Text=oProyecto.Titulo;
            txtDescripcion.Text=oProyecto.Descripcion;
            txtFicha.Text = oProyecto.FichaProyecto.ToString();
            txtHorasEstimadas.Text=oProyecto.HorasEstimadas.ToString();
            txtHorasCompletadas.Text=oProyecto.HorasCompletadas.ToString();
            txtHorasRestantes.Text=oProyecto.HorasRestantes.ToString();
            txtEstado.Text =oProyecto.Estado.ToString();
        }
        void DespoblarInputs()
        {
            if (dgvListaProyectos.Rows.Count==0)
            {
                txtTitulo.Text=null;
                txtDescripcion.Text=null;
                txtFicha.Text = null;
                txtHorasEstimadas.Text=null;
                txtHorasCompletadas.Text=null;
                txtHorasRestantes.Text=null;
                txtEstado.Text =null;
                tvwFasesTareas.Nodes.Clear();
                ltbHitos.DataSource=null;
            }
        }
        #endregion
        #region Eventos
        private void frmModuloProyectos_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarEstiloDGV(dgvListaProyectos);
                CargarDgvProyectos();
                VerificarSeleccionProyecto();
                oProyecto = SeleccionarProyecto();
                CargarTreeBacklog(oProyecto);
                CargarLtbHitos(oProyecto);

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }


        private void dgvListaProyectos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                oProyecto=SeleccionarProyecto();
                PoblarInputs(oProyecto);
                CargarLtbHitos(oProyecto);
                CargarTreeBacklog(oProyecto);
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                frmAbmProyectos frm = new frmAbmProyectos();
                frm.ShowDialog();
                CargarDgvProyectos();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionProyecto();
                frmAbmProyectos frm = new frmAbmProyectos(SeleccionarProyecto());
                frm.Modificar = true;
                frm.ShowDialog();
                CargarDgvProyectos();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionProyecto();
                oProyecto = SeleccionarProyecto();

                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro de eliminar el proyecto {oProyecto}? Esto eliminara todos sus hitos y work items hijos",
                    "Confirmar baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    gestorProyectos.VerificarPresenciaColaboradores(oProyecto);
                    gestorProyectos.EliminarProyecto(oProyecto);
                    CargarDgvProyectos();

                    MessageBox.Show("El proyecto ha sido eliminado de forma exitosa",
                        "Baja exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    DespoblarInputs();
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
