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
    public partial class frmModuloFichasProyecto : Form
    {

        BLLFichaProyecto gestorFichas;
        BEFichaProyecto oFicha;
        public frmModuloFichasProyecto()
        {
            InitializeComponent();
            gestorFichas = new BLLFichaProyecto();
            oFicha = new BEFichaProyecto();
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

        public BEFichaProyecto SeleccionarFicha()
        {
            oFicha = (BEFichaProyecto)dgvListaFichas.CurrentRow.DataBoundItem;
            return oFicha;
        }

        void CargarDgvFichas()
        {
            this.dgvListaFichas.DataSource=null;
            this.dgvListaFichas.DataSource= gestorFichas.ListarFichasProyecto();
            this.dgvListaFichas.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        public void VerificarSeleccionFicha()
        {
            if (dgvListaFichas.SelectedRows.Count==0)
            {
                throw new InvalidOperationException("Debe seleccionar una ficha de proyecto");
            }
        }

        public void PoblarInputs(BEFichaProyecto oFicha)
        {
            txtTitulo.Text=oFicha.Titulo;
            txtDescripcion.Text=oFicha.Descripcion;
            txtContrato.Text = oFicha.Contrato.ToString();
            dtpFechaInicio.Value=oFicha.FechaInicioPrevista;
            dtpFechaFin.Value = oFicha.FechaFinPrevista;
            txtHoras.Text=oFicha.Horas.ToString();
            txtEstado.Text =oFicha.Estado.ToString();
            txtPresupuesto.Text=oFicha.Presupuesto.ToString();
        }
        void DespoblarInputs()
        {
            if (dgvListaFichas.Rows.Count==0)
            {
                txtTitulo.Text=null;
                txtDescripcion.Text=null;
                txtContrato.Text = null;
                dtpFechaFin.Value=DateTime.Today;
                dtpFechaInicio.Value = DateTime.Today;
                txtHoras.Text=null;
                txtEstado.Text =null;
                txtPresupuesto.Text=null;
            }
        }
        #endregion
        #region Eventos
        private void frmModuloFichasProyecto_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarEstiloDGV(dgvListaFichas);
                CargarDgvFichas();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void dgvListaFichas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                oFicha = SeleccionarFicha();
                PoblarInputs(oFicha);
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmAbmFichaProyecto frm = new frmAbmFichaProyecto();
                frm.ShowDialog();
                CargarDgvFichas();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionFicha();
                oFicha = SeleccionarFicha();
                frmAbmFichaProyecto frm = new frmAbmFichaProyecto(oFicha);
                frm.Modificar = true;
                frm.ShowDialog();
                CargarDgvFichas();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionFicha();
                oFicha = SeleccionarFicha();

                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro de eliminar la ficha de proyecto {oFicha}?",
                    "Confirmar baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    gestorFichas.VerificarPresenciaProyecto(oFicha);
                    gestorFichas.EliminarFichaProyecto(oFicha);
                    CargarDgvFichas();

                    MessageBox.Show("La ficha de proyecto ha sido eliminada de forma exitosa",
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
