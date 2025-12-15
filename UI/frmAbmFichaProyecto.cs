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
    public partial class frmAbmFichaProyecto : Form
    {

        public bool Modificar { get; set; }


        BEFichaProyecto oFicha;
        BLLFichaProyecto gestorFichas;
        BEContrato oContrato;
        BLLContrato gestorContratos;

        public frmAbmFichaProyecto(BEFichaProyecto oFicha)//constructor para modificacion
        {
            InitializeComponent();
            this.oFicha = oFicha;
            gestorFichas = new BLLFichaProyecto();
        }

        public frmAbmFichaProyecto() //constructor para modificacion
        {
            InitializeComponent();
            oContrato = new BEContrato();
            gestorContratos = new BLLContrato();
            gestorFichas = new BLLFichaProyecto();
            oFicha = new BEFichaProyecto();
        }

        #region Métodos
        void CargarLtbContratos()
        {
            ltbListaContratos.DataSource=null;
            ltbListaContratos.DataSource=gestorContratos.ListarContratosDisponibles();
        }

        void SetearDtps()
        {
            dtpFechaFinAlta.Value=DateTime.Today;
            dtpFechaInicioAlta.Value=DateTime.Today;
        }

        public void PoblarInputsMod(BEFichaProyecto oFichaProyecto)
        {
            txtTituloMod.Text=oFichaProyecto.Titulo;
            txtDescripcionMod.Text=oFichaProyecto.Descripcion;
            txtContrato.Text = oFichaProyecto.Contrato.ToString();
            dtpFechaFinMod.Value=oFichaProyecto.FechaFinPrevista;
            dtpFechaInicioMod.Value=oFichaProyecto.FechaInicioPrevista;
            txtHorasMod.Text=oFichaProyecto.Horas.ToString();
            cbxEstadoMod.Text =oFichaProyecto.Estado.ToString();
            txtPresupuestoMod.Text =oFichaProyecto.Presupuesto.ToString();
        }

        public BEContrato SeleccionarContrato()
        {
            oContrato = (BEContrato)ltbListaContratos.SelectedItem;
            return oContrato;
        }

        public void VerificarSeleccionContrato()
        {
            if (ltbListaContratos.SelectedItem==null)
            {
                throw new InvalidOperationException("Debe seleccionar un contrato");
            }
        }


        public BEFichaProyecto AsignarFicha()
        {
            if (Modificar)
            {
                //distintas validacioens con regex
                UIHelper.ValidarTitulo(txtTituloMod.Text);
                UIHelper.ValidarDescripcion(txtDescripcionMod.Text);
                UIHelper.ValidarHorasEnteros(txtHorasMod.Text);
                UIHelper.ValidarEstado(cbxEstadoMod.Text);
                UIHelper.ValidarPresupuesto(txtPresupuestoMod.Text);
                //\distintas validacioens con regex

                gestorFichas.VerificarTraspasoPendiente(oFicha, cbxEstadoMod.Text);
                gestorFichas.VerificarEstadoProyectoAsociado(oFicha, cbxEstadoMod.Text);

                oFicha.Titulo=txtTituloMod.Text;
                oFicha.Descripcion=txtDescripcionMod.Text;
                oFicha.Horas=int.Parse(txtHorasMod.Text);
                oFicha.Estado=(BEEEstadoFicha)cbxEstadoMod.SelectedItem;
                oFicha.Presupuesto=decimal.Parse(txtPresupuestoMod.Text);
                return oFicha;
            }
            else
            {
                VerificarSeleccionContrato();

                //distintas validacioens con regex
                UIHelper.ValidarTitulo(txtTituloAlta.Text);
                UIHelper.ValidarDescripcion(txtDescripcionAlta.Text);
                UIHelper.ValidarHorasEnteros(txtHorasAlta.Text);
                UIHelper.ValidarPresupuesto(txtPresupuestoAlta.Text);
                UIHelper.ValidarDiferenciaFechasFichas(dtpFechaInicioAlta.Value, dtpFechaFinAlta.Value);
                //\distintas validacioens con regex

                oFicha.Titulo=txtTituloAlta.Text;
                oFicha.Descripcion=txtDescripcionAlta.Text;
                oFicha.FechaInicioPrevista=dtpFechaInicioAlta.Value;
                oFicha.FechaFinPrevista=dtpFechaFinAlta.Value;
                oFicha.Horas=int.Parse(txtHorasAlta.Text);
                oFicha.Estado=BEEEstadoFicha.Pendiente;
                oFicha.Presupuesto=decimal.Parse(txtPresupuestoAlta.Text);

                oFicha.Contrato=SeleccionarContrato();

                return oFicha;
            }
        }

        #endregion
        #region Eventos

        private void frmAbmFichaProyecto_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modificar)
                {
                    grbRegistrar.Visible = false;
                    grbModificar.Visible = true;
                    grbContratosDisponibles.Visible = false;
                    this.Width = 600;
                    this.Height = 750;
                    pnlHeader.Width = 560;
                    cbxEstadoMod.DataSource = Enum.GetValues(typeof(BEEEstadoFicha));
                    PoblarInputsMod(oFicha);
                }
                else
                {
                    grbModificar.Visible = false;
                    grbRegistrar.Visible = true;
                    grbContratosDisponibles.Visible = true;
                    this.Width = 850;
                    this.Height = 750;
                    pnlHeader.Width = 810;
                    SetearDtps();
                    CargarLtbContratos();
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }


        private void btnLimpiarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                txtTituloAlta.Text = null;
                txtDescripcionAlta.Text = null;
                dtpFechaInicioAlta.Value = DateTime.Today;
                dtpFechaFinAlta.Value = DateTime.Today;
                txtHorasAlta.Text = null;
                txtPresupuestoAlta.Text = null;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnLimpiarMod_Click(object sender, EventArgs e)
        {
            try
            {
                txtTituloMod.Text = null;
                txtDescripcionMod.Text = null;
                cbxEstadoMod.SelectedIndex = 0;
                txtHorasMod.Text = null;
                txtPresupuestoMod.Text = null;
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
                    oFicha = AsignarFicha();
                    gestorFichas.ModificarFichaProyecto(oFicha);
                    MessageBox.Show($"La ficha de proyecto ha sido modificada de forma exitosa", "Modificación exitosa",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    oFicha = AsignarFicha();
                    gestorFichas.AgregarFichaProyecto(oFicha);
                    MessageBox.Show($"La ficha de proyecto se ha agregado de forma exitosa!", "Alta exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
