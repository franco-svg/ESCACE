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
    public partial class frmDescargaContrato : Form
    {
        BEContrato oContrato;
        BLLContrato gestorContratos;

        public frmDescargaContrato(BEContrato oContrato)
        {
            InitializeComponent();
            this.oContrato = oContrato;
            gestorContratos = new BLLContrato();

        }

        #region Métodos

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
        #endregion
        #region Eventos
        private void frmDescargaContrato_Load(object sender, EventArgs e)
        {
            try { PoblarInputs(oContrato); }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try { this.Close(); }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Archivo PDF (*.pdf)|*.pdf";
                sfd.FileName = $"Contrato_{oContrato}.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    UIPdfGenerator.DescargarContratoPdf(oContrato, sfd.FileName);
                    MessageBox.Show("El contrato se descargó correctamente.", "Descarga completada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
