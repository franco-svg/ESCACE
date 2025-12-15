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
    public partial class frmAbmContratos : Form
    {
        public bool Modificar { get; set; }

        BEContrato oContrato;
        BLLContrato gestorContratos;
        BLLCliente gestoClientes;
        BECliente oCliente;


        public frmAbmContratos(BEContrato oContrato) //constructor para modificacion
        {
            InitializeComponent();
            this.oContrato = oContrato;
            gestorContratos = new BLLContrato();
        }

        public frmAbmContratos() //constructor para alta
        {
            InitializeComponent();
            oContrato = new BEContrato();
            gestorContratos = new BLLContrato();
            gestoClientes = new BLLCliente();
            oCliente = new BECliente();
        }

        #region Métodos
        void CargarLtbClientes()
        {
            ltbListaClientes.DataSource=null;
            ltbListaClientes.DataSource=gestoClientes.ListarClientes();
        }


        void SetearDtps()
        {
            dtpFechaFirmaAlta.Value=DateTime.Today;
            dtpFechaVigenciaAlta.Value=DateTime.Today;
        }


        public void PoblarInputsMod(BEContrato oContrato)
        {
            txtTituloMod.Text=oContrato.Titulo;
            txtDescripcionMod.Text=oContrato.Descripcion;
            txtTerminosCondicionesMod.Text = oContrato.TerminosCondiciones;
            txtClienteMod.Text=oContrato.Cliente.ToString();
            dtpFechaFirmaMod.Value=oContrato.FechaFirma;
            dtpFechaVigenciaMod.Value=oContrato.FechaInicio;
            cbxEstadoMod.Text =oContrato.Estado.ToString();
            txtMontoMod.Text =oContrato.Monto.ToString();
        }


        public BECliente SeleccionarCliente()
        {
            oCliente = (BECliente)ltbListaClientes.SelectedItem;
            return oCliente;
        }


        public void VerificarSeleccionCliente()
        {
            if (ltbListaClientes.SelectedItem==null)
            {
                throw new InvalidOperationException("Debe seleccionar un cliente");
            }
        }



        public BEContrato AsignarContrato()
        {
            if (Modificar)
            {
                //distintas validaciones con regex
                UIHelper.ValidarTitulo(txtTituloMod.Text);
                UIHelper.ValidarDescripcion(txtDescripcionMod.Text);
                UIHelper.ValidarTerminosYCondiciones(txtTerminosCondicionesMod.Text);
                UIHelper.ValidarEstado(cbxEstadoMod.Text);
                UIHelper.ValidarMonto(txtMontoMod.Text);
                //\distintas validaciones con regex

                gestorContratos.VerificarTraspasoPendiente(oContrato, cbxEstadoMod.Text);
                gestorContratos.VerificarEstadoFichaAsociada(oContrato, cbxEstadoMod.Text);
                oContrato.Titulo = txtTituloMod.Text;
                oContrato.Descripcion= txtDescripcionMod.Text;
                oContrato.TerminosCondiciones = txtTerminosCondicionesMod.Text;
                oContrato.Estado = (BEEEstadoContrato)cbxEstadoMod.SelectedItem;
                oContrato.Monto = decimal.Parse(txtMontoMod.Text);

                return oContrato;
            }
            else
            {
                VerificarSeleccionCliente();
                //distintas validaciones con regex
                UIHelper.ValidarTitulo(txtTituloAlta.Text);
                UIHelper.ValidarDescripcion(txtDescripcionAlta.Text);
                UIHelper.ValidarTerminosYCondiciones(txtTerminosCondicionesAlta.Text);
                UIHelper.ValidarDiferenciaFechasContrato(dtpFechaFirmaAlta.Value, dtpFechaVigenciaAlta.Value);
                UIHelper.ValidarMonto(txtMontoAlta.Text);
                //\distintas validaciones con regex

                oContrato.Titulo = txtTituloAlta.Text;
                oContrato.Descripcion= txtDescripcionAlta.Text;
                oContrato.TerminosCondiciones = txtTerminosCondicionesAlta.Text;
                oContrato.Cliente = SeleccionarCliente();
                oContrato.FechaFirma=dtpFechaFirmaAlta.Value;
                oContrato.FechaInicio=dtpFechaVigenciaAlta.Value;
                oContrato.Estado = BEEEstadoContrato.Pendiente;
                oContrato.Monto = decimal.Parse(txtMontoAlta.Text);
                return oContrato;
            }


        }
        #endregion
        #region Eventos
        private void btnLimpiarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                txtTituloAlta.Text = null;
                txtDescripcionAlta.Text = null;
                txtTerminosCondicionesAlta.Text = null;
                dtpFechaFirmaAlta.Value = DateTime.Today;
                dtpFechaVigenciaAlta.Value = DateTime.Today;
                txtMontoAlta.Text = null;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }


        private void frmAbmContratos_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modificar)
                {
                    grbRegistrar.Visible = false;
                    grbModificar.Visible = true;
                    grbClientesDisponibles.Visible = false;
                    this.Width = 600;
                    pnlHeader.Width = 560;
                    cbxEstadoMod.DataSource = Enum.GetValues(typeof(BEEEstadoContrato));
                    PoblarInputsMod(oContrato);
                }
                else
                {
                    grbModificar.Visible = false;
                    grbRegistrar.Visible = true;
                    grbClientesDisponibles.Visible = true;
                    this.Width = 850;
                    pnlHeader.Width = 810;
                    SetearDtps();
                    CargarLtbClientes();
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }


        private void btnLimpiarMod_Click(object sender, EventArgs e)
        {
            try
            {
                txtTituloMod.Text = null;
                txtDescripcionMod.Text = null;
                txtTerminosCondicionesMod.Text = null;
                cbxEstadoMod.SelectedIndex = 0;
                txtMontoMod.Text = null;
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
                    oContrato = AsignarContrato();
                    gestorContratos.ModificarContrato(oContrato);
                    MessageBox.Show($"El contrato ha sido modificado de forma exitosa", "Modificación exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    oContrato = AsignarContrato();
                    gestorContratos.AgregarContrato(oContrato);
                    MessageBox.Show($"El contrato se ha agregado de forma exitosa!", "Alta exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
