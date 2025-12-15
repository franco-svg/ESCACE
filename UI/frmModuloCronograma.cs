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
    public partial class frmModuloCronograma : Form
    {

        BLLProyecto gestorProyectos;
        BEProyecto oProyecto;
        BEHito oHito;
        BLLHito gestorHitos;

        public frmModuloCronograma()
        {
            InitializeComponent();
            gestorProyectos = new BLLProyecto();
            oProyecto = new BEProyecto();
            oHito = new BEHito();
            gestorHitos=new BLLHito();
        }
        #region Métodos
        public void ConfigurarEstiloDGV(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(68, 125, 155);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor=Color.FromArgb(68, 125, 155);
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor=Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 11, FontStyle.Bold);

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(118, 175, 205);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font=new Font("Bahnschrift", 10, FontStyle.Regular);


            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

        }

        public BEProyecto SeleccionarProyecto()
        {
            oProyecto=(BEProyecto)dgvListaProyectos.CurrentRow.DataBoundItem;
            return oProyecto;
        }

        public BEHito SeleccionarHito()
        {
            oHito=(BEHito)ltbHitos.SelectedItem;
            return oHito;
        }

        void CargarDgvProyectos()
        {
            this.dgvListaProyectos.DataSource=null;
            this.dgvListaProyectos.DataSource=gestorProyectos.ListarProyectos();
            this.dgvListaProyectos.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        void CargarLtbHitos(BEProyecto oProyecto)
        {
            this.ltbHitos.DataSource=null;
            this.ltbHitos.DataSource=oProyecto.Hitos;
        }

        public void VerificarSeleccionHito()
        {
            if (ltbHitos.SelectedItem ==null)
            {
                throw new InvalidOperationException("Debe seleccionar un hito del proyecto");
            }
        }

        public void VerificarSeleccionProyecto()
        {
            if (dgvListaProyectos.SelectedRows.Count==0)
            {
                throw new InvalidOperationException("Debe seleccionar un proyecto");
            }
        }

        void PoblarInputs(BEHito oHito)
        {
            if (oHito!=null)
            {
                txtTitulo.Text=oHito.Titulo;
                txtCriterioAlcance.Text=oHito.CriterioAlcance;
                dtpFecha.Value=oHito.Fecha;
                ccbAlcanzado.Checked=oHito.Alcanzado;
            }
        }

        void DespoblarInputs()
        {
            if (ltbHitos.Items.Count==0)
            {
                txtTitulo.Text=null;
                txtCriterioAlcance.Text=null;
                dtpFecha.Value=DateTime.Today;
                ccbAlcanzado.Checked=false;
            }
        }
        #endregion
        #region Eventos
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionProyecto();
                frmAbmHitos frm = new frmAbmHitos(SeleccionarProyecto());
                frm.ShowDialog();
                CargarDgvProyectos();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionHito();
                frmAbmHitos frm = new frmAbmHitos(SeleccionarHito());
                frm.Modificar = true;
                frm.ShowDialog();
                CargarDgvProyectos();

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void frmModuloCronograma_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarEstiloDGV(dgvListaProyectos);
                CargarDgvProyectos();
                
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void dgvListaProyectos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                CargarLtbHitos(SeleccionarProyecto());
                DespoblarInputs();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void ltbHitos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ltbHitos.SelectedItem != null)
                {
                    PoblarInputs(SeleccionarHito());
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionHito();
                oHito = SeleccionarHito();

                DialogResult confirmacion = MessageBox.Show($"Esta seguro de eliminar el hito {oHito} ?", "Confirmar baja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    gestorHitos.EliminarHito(oHito);
                    CargarDgvProyectos();
                    MessageBox.Show($"El hito ha sido eliminado de forma exitosa", "Baja exitosa",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DespoblarInputs();
                }

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
