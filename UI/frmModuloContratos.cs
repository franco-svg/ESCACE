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
    public partial class frmModuloContratos : Form
    {
        BLLContrato gestorContratos;
        BEContrato oContrato;


        public frmModuloContratos()
        {
            InitializeComponent();

            gestorContratos = new BLLContrato();
            oContrato = new BEContrato();
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


        public BEContrato SeleccionarContrato()
        {
            oContrato = (BEContrato)dgvListaContratos.CurrentRow.DataBoundItem;
            return oContrato;
        }

        void CargarDgvContratos()
        {
            this.dgvListaContratos.DataSource=null;
            this.dgvListaContratos.DataSource= gestorContratos.ListarContratos();
            this.dgvListaContratos.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }


        public void VerificarSeleccionContrato()
        {
            if (dgvListaContratos.SelectedRows.Count==0)
            {
                throw new InvalidOperationException("Debe seleccionar un contrato");
            }
        }


        public void PoblarInputs(BEContrato oContrato)
        {
            txtTitulo.Text=oContrato.Titulo;
            txtDescripcion.Text=oContrato.Descripcion;
            txtTerminosCondiciones.Text = oContrato.TerminosCondiciones;
            txtCliente.Text=oContrato.Cliente.ToString();
            dtpFechaFirma.Value=oContrato.FechaFirma;
            dtpFechaVigencia.Value=oContrato.FechaInicio;
            txtEstado.Text =oContrato.Estado.ToString();
            txtMonto.Text =oContrato.Monto.ToString();
        }

        public void DespoblarInputs()
        {
            if (dgvListaContratos.Rows.Count==0)
            {
                txtTitulo.Text=null;
                txtDescripcion.Text=null;
                txtTerminosCondiciones.Text = null;
                txtCliente.Text=null;
                dtpFechaFirma.Value=DateTime.Today;
                dtpFechaVigencia.Value=DateTime.Today;
                txtEstado.Text =null;
                txtMonto.Text =null;
            }
        }
        #endregion
        #region Eventos
        private void frmModuloContratos_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarEstiloDGV(dgvListaContratos);
                CargarDgvContratos();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void dgvListaContratos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                oContrato = SeleccionarContrato();
                PoblarInputs(oContrato);
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmAbmContratos frm = new frmAbmContratos();
                frm.ShowDialog();
                CargarDgvContratos();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }


        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionContrato();
                oContrato = SeleccionarContrato();
                frmAbmContratos frm = new frmAbmContratos(oContrato);
                frm.Modificar = true;
                frm.ShowDialog();
                CargarDgvContratos();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }


        private void btnDescargar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionContrato();
                oContrato = SeleccionarContrato();
                frmDescargaContrato frm = new frmDescargaContrato(oContrato);
                frm.ShowDialog();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionContrato();
                oContrato = SeleccionarContrato();

                DialogResult confirmacion = MessageBox.Show($"Esta seguro de eliminar el contrato {oContrato} ?", "Confirmar baja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    gestorContratos.VerificarPresenciaFicha(oContrato);

                    gestorContratos.EliminarContrato(oContrato);
                    CargarDgvContratos();
                    MessageBox.Show($"El contrato ha sido eliminado de forma exitosa", "Baja exitosa",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DespoblarInputs();
                }

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
