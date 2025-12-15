using BE;
using BLL;
using Guna.UI2.WinForms;
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
    public partial class frmModuloClientes : Form
    {
        BLLCliente gestorClientes;
        BECliente oCliente;


        Dictionary<BEEPais, (string IdFiscal, string PrefijoTel)> diccionarioFiscales = new Dictionary<BEEPais, (string IdFiscal, string PrefijoTel)>
            {
                { BEEPais._, ("Id fiscal", "+nn") },
                { BEEPais.Argentina, ("CUIT", "+54") },
                { BEEPais.Chile,     ("RUT (CHI)",  "+56") },
                { BEEPais.Uruguay,   ("RUT (UY)",  "+598") },
                { BEEPais.Brasil,    ("CNPJ", "+55") },
                { BEEPais.EEUU,      ("EIN",  "+1") },
                { BEEPais.España,    ("NIF",  "+34") }
            };

        public frmModuloClientes()
        {
            InitializeComponent();

            oCliente=new BECliente();
            gestorClientes = new BLLCliente();
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

        void CargarDgvClientes()
        {
            this.dgvListaClientes.DataSource=null;
            this.dgvListaClientes.DataSource= gestorClientes.ListarClientes();
            this.dgvListaClientes.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        public BECliente SeleccionarCliente()
        {
            oCliente = (BECliente)dgvListaClientes.CurrentRow.DataBoundItem;
            return oCliente;
        }

        public void VerificarSeleccionCliente()
        {
            if (dgvListaClientes.SelectedRows.Count==0)
            {
                throw new InvalidOperationException("Debe seleccionar un cliente");
            }
        }

        public void PoblarInputs(BECliente oCliente)
        {
            lblIdFiscal.Text=diccionarioFiscales[oCliente.Pais].IdFiscal;
            txtRazonSocial.Text=oCliente.RazonSocial;
            txtPaís.Text=oCliente.Pais.ToString();
            txtIdFiscal.Text=oCliente.IdFiscal;
            txtPrefijoTelefono.Text=diccionarioFiscales[oCliente.Pais].PrefijoTel;
            txtNumeroTelefono.Text = oCliente.Telefono.Substring(oCliente.Telefono.IndexOf("-") + 1);
            txtEmail.Text = oCliente.Email;
            txtIndustria.Text=oCliente.Industria.ToString();
        }

        void DespoblarInputs()
        {
            if (dgvListaClientes.Rows.Count==0)
            {
                lblIdFiscal.Text="IdFiscal";
                txtRazonSocial.Text=null; ;
                txtPaís.Text=null;
                txtIdFiscal.Text=null;
                txtPrefijoTelefono.Text=null;
                txtNumeroTelefono.Text =null;
                txtEmail.Text = null;
                txtIndustria.Text=null;
            }

        }
        #endregion
        #region Eventos
        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmAbmClientes frm = new frmAbmClientes(diccionarioFiscales);
                frm.ShowDialog();
                CargarDgvClientes();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionCliente();
                oCliente = SeleccionarCliente();
                frmAbmClientes frm = new frmAbmClientes(oCliente, diccionarioFiscales);
                frm.Modificar=true;
                frm.ShowDialog();
                CargarDgvClientes();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void frmModuloClientes_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarEstiloDGV(dgvListaClientes);
                CargarDgvClientes();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void dgvListaClientes_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                oCliente = SeleccionarCliente();
                PoblarInputs(oCliente);
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionCliente();
                oCliente = SeleccionarCliente();

                DialogResult confirmacion = MessageBox.Show($"Esta seguro de eliminar al cliente {oCliente} ?", "Confirmar baja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    gestorClientes.VerificarPresenciaContrato(oCliente);
                    gestorClientes.EliminarCliente(oCliente);
                    CargarDgvClientes();
                    MessageBox.Show($"El cliente ha sido eliminado de forma exitosa", "Baja exitosa",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DespoblarInputs();
                }

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion

    }
}
