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
    public partial class frmAbmClientes : Form
    {
        internal bool Modificar { get; set; }

        BECliente oCliente;
        BLLCliente gestorCliente;
        Dictionary<BEEPais, (string IdFiscal, string PrefijoTel)> dDiccionarioFiscal;

        public frmAbmClientes(BECliente oCliente, Dictionary<BEEPais, (string IdFiscal, string PrefijoTel)> dDiccionarioFiscal)
        {
            InitializeComponent();
            this.oCliente=oCliente;
            this.dDiccionarioFiscal = dDiccionarioFiscal;
            gestorCliente = new BLLCliente();
        }

        public frmAbmClientes(Dictionary<BEEPais, (string IdFiscal, string PrefijoTel)> dDiccionarioFiscal)
        {
            InitializeComponent();
            oCliente = new BECliente();
            gestorCliente = new BLLCliente();
            this.dDiccionarioFiscal = dDiccionarioFiscal;
        }

        #region Métodos
        void PoblarInputsMod(BECliente oCliente)
        {

            txtRazonSocialMod.Text=oCliente.RazonSocial;
            cbxPaisMod.Text=oCliente.Pais.ToString();
            txtIdFiscalMod.Text=oCliente.IdFiscal;
            txtPrefijoTelefonoMod.Text=dDiccionarioFiscal[oCliente.Pais].PrefijoTel;
            txtNumeroTelefonoMod.Text = oCliente.Telefono.Substring(oCliente.Telefono.IndexOf("-") + 1);
            txtEmailMod.Text = oCliente.Email;
            cbxIndustriaMod.Text=oCliente.Industria.ToString();
        }

        public BECliente AsignarCliente()
        {

            if (Modificar)
            {
                //distintas validaciones con regex
                UIHelper.ValidarRazonSocial(txtRazonSocialMod.Text);
                UIHelper.ValidarPais(cbxPaisMod.Text);
                UIHelper.ValidarIdFiscal(txtIdFiscalMod.Text, lblIdFiscalMod.Text);
                UIHelper.ValidarEmail(txtEmailMod.Text);
                UIHelper.ValidarTelefono(txtNumeroTelefonoMod.Text, txtPrefijoTelefonoMod.Text);
                UIHelper.ValidarIndustria(cbxIndustriaMod.Text);
                //\distintas validaciones con regex

                oCliente.RazonSocial = txtRazonSocialMod.Text;
                oCliente.Pais = (BEEPais)cbxPaisMod.SelectedItem;
                oCliente.IdFiscal = txtIdFiscalMod.Text;
                oCliente.Email = txtEmailMod.Text;
                oCliente.Telefono = $"{txtPrefijoTelefonoMod.Text}-{txtNumeroTelefonoMod.Text}";
                oCliente.Industria = (BEEIndustria)cbxIndustriaMod.SelectedItem;
                return oCliente;
            }
            else
            {
                //distintas validaciones con regex
                UIHelper.ValidarRazonSocial(txtRazonSocialAlta.Text);
                UIHelper.ValidarPais(cbxPaisAlta.Text);
                UIHelper.ValidarIdFiscal(txtIdFiscalAlta.Text, lblIdFiscalAlta.Text);
                UIHelper.ValidarEmail(txtEmailAlta.Text);
                UIHelper.ValidarTelefono(txtNumeroTelefonoAlta.Text, txtPrefijoTelefonoAlta.Text);
                UIHelper.ValidarIndustria(cbxIndustraAlta.Text);
                //\distintas validaciones con regex

                oCliente.RazonSocial = txtRazonSocialAlta.Text;
                oCliente.Pais = (BEEPais)cbxPaisAlta.SelectedItem;
                oCliente.IdFiscal = txtIdFiscalAlta.Text;
                oCliente.Email = txtEmailAlta.Text;
                oCliente.Telefono = $"{txtPrefijoTelefonoAlta.Text}-{txtNumeroTelefonoAlta.Text}";
                oCliente.Industria = (BEEIndustria)cbxIndustraAlta.SelectedItem;
                return oCliente;
            }


        }
        #endregion
        #region Eventos
        private void frmAbmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modificar)
                {
                    grbRegistrar.Visible=false; grbModificar.Visible=true;
                    cbxPaisMod.DataSource = Enum.GetValues(typeof(BEEPais));
                    cbxIndustriaMod.DataSource = Enum.GetValues(typeof(BEEIndustria));
                    PoblarInputsMod(oCliente);
                }
                else
                {
                    grbModificar.Visible=false; grbRegistrar.Visible=true;

                    cbxPaisAlta.DataSource = Enum.GetValues(typeof(BEEPais));
                    cbxPaisAlta.SelectedIndex=0;

                    cbxIndustraAlta.DataSource = Enum.GetValues(typeof(BEEIndustria));
                    cbxIndustraAlta.SelectedIndex=0;
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void cbxPaisAlta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxPaisAlta.SelectedItem is BEEPais paisSeleccionado)
                {
                    lblIdFiscalAlta.Text = dDiccionarioFiscal[paisSeleccionado].IdFiscal;
                    txtPrefijoTelefonoAlta.Text = dDiccionarioFiscal[paisSeleccionado].PrefijoTel;
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnLimpiarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                txtRazonSocialAlta.Text=null;
                cbxPaisAlta.SelectedIndex=0;
                txtEmailAlta.Text=null;
                txtIdFiscalAlta.Text=null;
                txtNumeroTelefonoAlta.Text=null;
                cbxIndustraAlta.SelectedIndex = 0;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnLimpiarMod_Click(object sender, EventArgs e)
        {
            try
            {
                txtRazonSocialMod.Text=null;
                cbxPaisMod.SelectedIndex=0;
                txtEmailMod.Text=null;
                txtIdFiscalMod.Text=null;
                txtNumeroTelefonoMod.Text=null;
                cbxIndustriaMod.SelectedIndex = 0;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }

        }

        private void cbxPaisMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxPaisMod.SelectedItem is BEEPais paisSeleccionado)
                {
                    lblIdFiscalMod.Text = dDiccionarioFiscal[paisSeleccionado].IdFiscal;
                    txtPrefijoTelefonoMod.Text = dDiccionarioFiscal[paisSeleccionado].PrefijoTel;
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Modificar)
                {
                    oCliente = AsignarCliente();
                    gestorCliente.ModificarCliente(oCliente);
                    MessageBox.Show($"El cliente ha sido modificado de forma exitosa", "Modificación exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    oCliente = AsignarCliente();
                    gestorCliente.AgregarCliente(oCliente);
                    MessageBox.Show($"El cliente se ha agregado de forma exitosa!", "Alta exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnInfoFiscalMod_Click(object sender, EventArgs e)
        {
            try
            {
                string tipo = lblIdFiscalMod.Text.Trim().ToUpper();

                switch (tipo)
                {
                    case "CUIT": // Argentina
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 11 dígitos en total" + Environment.NewLine +
                                        "• Separados en el formato ##-########-#" + Environment.NewLine +
                                        "Ejemplo: 20-12345678-3",
                                        "Info CUIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "RUT (CHI)": // Chile
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 7 u 8 dígitos + guion + dígito verificador (0-9 o K)" + Environment.NewLine +
                                        "Ejemplo: 12345678-9  |  87654321-K",
                                        "Info RUT (Chile)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "CNPJ": // Brasil
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 14 dígitos en total" + Environment.NewLine +
                                        "• Separados en el formato ##.###.###/####-##" + Environment.NewLine +
                                        "Ejemplo: 12.345.678/0001-95",
                                        "Info CNPJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "EIN": // EEUU
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 9 dígitos en total" + Environment.NewLine +
                                        "• Separados en el formato ##-#######" + Environment.NewLine +
                                        "Ejemplo: 12-3456789",
                                        "Info EIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "NIF": // España
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• Letra/dígito inicial + 7 dígitos + letra final" + Environment.NewLine +
                                        "Ejemplo: 12345678Z  |  X1234567L",
                                        "Info NIF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "RUT (UY)": // Uruguay
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 12 dígitos numéricos sin guiones ni espacios" + Environment.NewLine +
                                        "Ejemplo: 210123456789",
                                        "Info RUT (Uruguay)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "IDFISCAL": // Caso genérico: no hacer nada
                        break;

                    default:
                        MessageBox.Show("Tipo de ID Fiscal no reconocido.",
                                        "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            catch (Exception ex)
            {
                UIHelper.ManejarError(ex);
            }
        }

        private void btnInfoFiscalAlta_Click(object sender, EventArgs e)
        {
            try
            {
                string tipo = lblIdFiscalAlta.Text.Trim().ToUpper();

                switch (tipo)
                {
                    case "CUIT": // Argentina
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 11 dígitos en total" + Environment.NewLine +
                                        "• Separados en el formato ##-########-#" + Environment.NewLine +
                                        "Ejemplo: 20-12345678-3",
                                        "Info CUIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "RUT (CHI)": // Chile
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 7 u 8 dígitos + guion + dígito verificador (0-9 o K)" + Environment.NewLine +
                                        "Ejemplo: 12345678-9  |  87654321-K",
                                        "Info RUT (Chile)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "CNPJ": // Brasil
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 14 dígitos en total" + Environment.NewLine +
                                        "• Separados en el formato ##.###.###/####-##" + Environment.NewLine +
                                        "Ejemplo: 12.345.678/0001-95",
                                        "Info CNPJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "EIN": // EEUU
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 9 dígitos en total" + Environment.NewLine +
                                        "• Separados en el formato ##-#######" + Environment.NewLine +
                                        "Ejemplo: 12-3456789",
                                        "Info EIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "NIF": // España
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• Letra/dígito inicial + 7 dígitos + letra final" + Environment.NewLine +
                                        "Ejemplo: 12345678Z  |  X1234567L",
                                        "Info NIF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "RUT (UY)": // Uruguay
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 12 dígitos numéricos sin guiones ni espacios" + Environment.NewLine +
                                        "Ejemplo: 210123456789",
                                        "Info RUT (Uruguay)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "IDFISCAL": // Caso genérico: no hacer nada
                        break;

                    default:
                        MessageBox.Show("Tipo de ID Fiscal no reconocido.",
                                        "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            catch (Exception ex)
            {
                UIHelper.ManejarError(ex);
            }
        }

        private void btnInfoTelefonoAlta_Click(object sender, EventArgs e)
        {
            try
            {
                string prefijo = txtPrefijoTelefonoAlta.Text.Trim();

                switch (prefijo)
                {
                    case "+54": // Argentina
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 10 dígitos sin el +54" + Environment.NewLine +
                                        "Ejemplo: 1123456789",
                                        "Info Teléfono (Argentina)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "+56": // Chile
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 9 dígitos sin el +56" + Environment.NewLine +
                                        "Ejemplo: 912345678",
                                        "Info Teléfono (Chile)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "+598": // Uruguay
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 8 dígitos sin el +598" + Environment.NewLine +
                                        "Ejemplo: 21234567",
                                        "Info Teléfono (Uruguay)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "+55": // Brasil
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 8 o 9 dígitos sin el +55" + Environment.NewLine +
                                        "Ejemplo: 912345678",
                                        "Info Teléfono (Brasil)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "+1": // EEUU
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 10 dígitos sin el +1" + Environment.NewLine +
                                        "Ejemplo: 2125551234",
                                        "Info Teléfono (EEUU)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "+34": // España
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 9 dígitos sin el +34" + Environment.NewLine +
                                        "Ejemplo: 612345678",
                                        "Info Teléfono (España)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "TELEFONO": // genérico o no seleccionado
                        break;

                    default:
                        MessageBox.Show("Prefijo telefónico no reconocido.",
                                        "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            catch (Exception ex)
            {
                UIHelper.ManejarError(ex);
            }
        }

        private void btnInfoTelefonoMod_Click(object sender, EventArgs e)
        {
            try
            {
                string prefijo = txtPrefijoTelefonoMod.Text.Trim();

                switch (prefijo)
                {
                    case "+54": // Argentina
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 10 dígitos sin el +54" + Environment.NewLine +
                                        "Ejemplo: 1123456789",
                                        "Info Teléfono (Argentina)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "+56": // Chile
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 9 dígitos sin el +56" + Environment.NewLine +
                                        "Ejemplo: 912345678",
                                        "Info Teléfono (Chile)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "+598": // Uruguay
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 8 dígitos sin el +598" + Environment.NewLine +
                                        "Ejemplo: 21234567",
                                        "Info Teléfono (Uruguay)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "+55": // Brasil
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 8 o 9 dígitos sin el +55" + Environment.NewLine +
                                        "Ejemplo: 912345678",
                                        "Info Teléfono (Brasil)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "+1": // EEUU
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 10 dígitos sin el +1" + Environment.NewLine +
                                        "Ejemplo: 2125551234",
                                        "Info Teléfono (EEUU)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "+34": // España
                        MessageBox.Show("Requisitos:" + Environment.NewLine +
                                        "• 9 dígitos sin el +34" + Environment.NewLine +
                                        "Ejemplo: 612345678",
                                        "Info Teléfono (España)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "TELEFONO": // genérico o no seleccionado
                        break;

                    default:
                        MessageBox.Show("Prefijo telefónico no reconocido.",
                                        "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            catch (Exception ex)
            {
                UIHelper.ManejarError(ex);
            }
        }
        #endregion
    }
}
