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
    public partial class frmModuloBacklog : Form
    {
        BEProyecto oProyecto;
        BLLProyecto gestorProyecto;
        BEFase oFase;
        BETarea oTarea;
        BLLWorkItem gestorWorkItems;
        public frmModuloBacklog()
        {
            InitializeComponent();
            oProyecto=new BEProyecto();
            oFase=new BEFase();
            oTarea=new BETarea();
            gestorWorkItems = new BLLWorkItem();
            gestorProyecto=new BLLProyecto();
        }
        #region Métodos

        public void VisualizarBotonesFase()
        {
            btnRegistrarFase.Visible=true;
            btnEliminarFase.Visible=true;
            btnModificarFase.Visible=true;
            btnRegistrarTarea.Visible=true;
            btnEliminarTarea.Visible=false;
            btnModificarTarea.Visible =false;
        }

        void OcultarBotones()
        {
            btnRegistrarFase.Visible=false;
            btnEliminarFase.Visible=false;
            btnModificarFase.Visible=false;
            btnRegistrarTarea.Visible=false;
            btnEliminarTarea.Visible=false;
            btnModificarTarea.Visible =false;
        }

        public void VisualizarBotonesTarea()
        {
            btnRegistrarFase.Visible=false;
            btnEliminarFase.Visible=false;
            btnModificarFase.Visible=false;
            btnRegistrarTarea.Visible=false;
            btnEliminarTarea.Visible=true;
            btnModificarTarea.Visible =true;
        }

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

        void PoblarInputs(BEWorkItem oWorkItem)
        {
            txtTitulo.Text= oWorkItem.Titulo;
            txtDescripcion.Text=oWorkItem.Descripcion;
            txtHorasEstimadas.Text=oWorkItem.HorasEstimadas.ToString();
            txtHorasRestantes.Text=oWorkItem.HorasRestantes.ToString();
            txtHorasCompletadas.Text=oWorkItem.HorasCompletadas.ToString();
            txtEstado.Text=oWorkItem.Estado.ToString();
        }

        void DespoblarInputs()
        {
            txtTitulo.Text= null;
            txtDescripcion.Text= null;
            txtHorasEstimadas.Text= null;
            txtHorasRestantes.Text= null;
            txtHorasCompletadas.Text= null;
            txtEstado.Text= null;
        }

        public BEProyecto SeleccionarProyecto()
        {
            oProyecto=(BEProyecto)dgvListaProyectos.CurrentRow.DataBoundItem;
            return oProyecto;
        }

        public BEWorkItem SeleccionarWorkItem()
        {
            return tvwBacklog.SelectedNode.Tag as BEWorkItem;
        }

        public BEFase SeleccionarFase() => SeleccionarWorkItem() as BEFase;

        public BETarea SeleccionarTarea()
        {
            var tarea = tvwBacklog.SelectedNode.Tag as BETarea;
            var fase = tvwBacklog.SelectedNode.Parent.Tag as BEFase;
            tarea.Fase = fase;
            return tarea;
        }


        void CargarDgvProyectos()
        {
            this.dgvListaProyectos.DataSource=null;
            this.dgvListaProyectos.DataSource=gestorProyecto.ListarProyectos();
            this.dgvListaProyectos.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        void CargarTvwWorkItems(BEProyecto oProyecto)
        {
            tvwBacklog.Nodes.Clear();

            // Evita null o proyecto sin fases
            if (oProyecto == null || oProyecto.Fases == null)
                return;

            //Recorre cada fase del proyecto
            foreach (var fase in oProyecto.Fases)
            {
                TreeNode nodoFase = new TreeNode(fase.Titulo);
                nodoFase.Tag = fase;

                //Agrega las tareas dentro de la fase
                if (fase.Tareas != null)
                {
                    foreach (var tarea in fase.Tareas)
                    {
                        TreeNode nodoTarea = new TreeNode(tarea.Titulo);
                        nodoTarea.Tag = tarea;
                        nodoFase.Nodes.Add(nodoTarea);
                    }
                }

                tvwBacklog.Nodes.Add(nodoFase);
            }
            tvwBacklog.ExpandAll();
        }

        public void VerificarSeleccionProyecto()
        {
            if (dgvListaProyectos.SelectedRows.Count==0)
            {
                throw new InvalidOperationException("Debe seleccionar un proyecto");
            }
        }
        #endregion
        #region Eventos
        private void btnRegistrarFase_Click_1(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionProyecto();
                frmAbmFases frm = new frmAbmFases(SeleccionarProyecto());
                frm.ShowDialog();
                CargarDgvProyectos();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnModificarFase_Click_1(object sender, EventArgs e)
        {
            try
            {
                oFase=SeleccionarFase();
                oFase.Proyecto=SeleccionarProyecto();
                frmAbmFases frm = new frmAbmFases(oFase);
                frm.Modificar = true;
                frm.ShowDialog();
                CargarDgvProyectos();

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnEliminarFase_Click(object sender, EventArgs e)
        {
            try
            {

                oFase= SeleccionarFase();
                oProyecto=SeleccionarProyecto();

                DialogResult confirmacion = MessageBox.Show($"Esta seguro de eliminar la fase {oFase}? Esto eliminará todos sus work items hijos", "Confirmar baja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    gestorWorkItems.EliminarWorkItem(oFase);

                    MessageBox.Show($"La fase y todos sus work items hijos han sido eliminados de forma exitosa", "Baja exitosa",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gestorProyecto.SumarizarHoras(oProyecto);
                    DespoblarInputs();
                    CargarDgvProyectos();
                    CargarTvwWorkItems(oProyecto);
                }

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnModificarTarea_Click_1(object sender, EventArgs e)
        {
            try
            {

                oTarea = SeleccionarTarea();
                frmAbmTareas frm = new frmAbmTareas(oTarea);
                frm.Modificar = true;
                frm.ShowDialog();
                gestorWorkItems.SumarizarHoraFase(oTarea.Fase);
                gestorProyecto.SumarizarHoras(SeleccionarProyecto());
                DespoblarInputs();
                CargarDgvProyectos();
                CargarTvwWorkItems(oProyecto);

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnRegistrarTarea_Click_1(object sender, EventArgs e)
        {
            try
            {
                oProyecto=SeleccionarProyecto();
                oFase=SeleccionarFase();
                frmAbmTareas frm = new frmAbmTareas(oFase);
                frm.ShowDialog();
                gestorWorkItems.SumarizarHoraFase(oFase);
                gestorProyecto.SumarizarHoras(SeleccionarProyecto());
                DespoblarInputs();
                CargarDgvProyectos();
                CargarTvwWorkItems(oProyecto);
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            try
            {

                oTarea= SeleccionarTarea();
                oProyecto=SeleccionarProyecto();

                DialogResult confirmacion = MessageBox.Show($"Esta seguro de eliminar la tarea {oTarea} ?", "Confirmar baja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    gestorWorkItems.EliminarWorkItem(oTarea);


                    MessageBox.Show($"La tarea ha sido eliminada de forma exitosa", "Baja exitosa",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gestorWorkItems.SumarizarHoraFase(oTarea.Fase);
                    gestorProyecto.SumarizarHoras(oProyecto);
                    DespoblarInputs();
                    CargarDgvProyectos();
                    CargarTvwWorkItems(oProyecto);

                }

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void frmModuloBacklog_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarEstiloDGV(dgvListaProyectos);
                CargarDgvProyectos();
                OcultarBotones();
                btnRegistrarFase.Visible=true;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void dgvListaProyectos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                CargarTvwWorkItems(SeleccionarProyecto());
                DespoblarInputs();
                OcultarBotones();
                btnRegistrarFase.Visible=true;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void tvwBacklog_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (tvwBacklog.SelectedNode == null)
                    return;

                var workItem = SeleccionarWorkItem();
                if (workItem == null)
                    return;

                if (workItem is BEFase faseSeleccionada)
                {
                    VisualizarBotonesFase();
                    grbDatosWI.Text = "Datos de la fase";
                    PoblarInputs(faseSeleccionada);
                }
                else if (workItem is BETarea tareaSeleccionada)
                {
                    VisualizarBotonesTarea();
                    grbDatosWI.Text = "Datos de la tarea";
                    PoblarInputs(tareaSeleccionada);
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
