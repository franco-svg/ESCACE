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
    public partial class frmAbmFases : Form
    {
        public bool Modificar { get; set; }

        BEFase oFase;
        BLLWorkItem gestorWorkItems;
        BEProyecto oProyecto;
        public frmAbmFases(BEFase oFase)//constructor para mod
        {
            InitializeComponent();
            this.oFase = oFase;
            gestorWorkItems=new BLLWorkItem();
        }
        public frmAbmFases(BEProyecto oProyecto)//constructor para alta
        {
            InitializeComponent();
            this.oProyecto = oProyecto;
            oFase=new BEFase();
            gestorWorkItems=new BLLWorkItem();

        }
        #region Métodos

        void PoblarInputsMod(BEFase oFase)
        {
            txtTituloMod.Text=oFase.Titulo;
            txtDescripcionMod.Text=oFase.Descripcion;
            txtHorasEstimadasMod.Text=oFase.HorasEstimadas.ToString();
            txtHorasCompletadasMod.Text=oFase.HorasCompletadas.ToString();
            txtHorasRestantesMod.Text=oFase.HorasRestantes.ToString();
            cbxEstadoMod.Text=oFase.Estado.ToString();
        }

        public BEFase AsignarFase()
        {
            if (Modificar)
            {
                //
                UIHelper.ValidarTitulo(txtTituloMod.Text);
                UIHelper.ValidarDescripcion(txtDescripcionMod.Text);
                UIHelper.ValidarHorasEnteros(txtHorasEstimadasMod.Text);
                UIHelper.ValidarEstado(cbxEstadoMod.Text);
                //

                oFase.Titulo=txtTituloMod.Text;
                oFase.Descripcion=txtDescripcionMod.Text;
                oFase.HorasEstimadas=decimal.Parse(txtHorasEstimadasMod.Text);
                oFase.HorasRestantes=decimal.Parse(txtHorasRestantesMod.Text);
                oFase.HorasCompletadas=decimal.Parse(txtHorasCompletadasMod.Text);
                oFase.Estado = (BEEEstadoWI)cbxEstadoMod.SelectedItem;
                return oFase;
            }
            else
            {
                //
                UIHelper.ValidarTitulo(txtTituloAlta.Text);
                UIHelper.ValidarDescripcion(txtDescripcionAlta.Text);
                UIHelper.ValidarHorasEnteros(txtHorasEstimadasAlta.Text);
                //

                oFase.Titulo=txtTituloAlta.Text;
                oFase.Descripcion=txtDescripcionAlta.Text;
                oFase.HorasEstimadas=decimal.Parse(txtHorasEstimadasAlta.Text);
                oFase.HorasRestantes=0;
                oFase.HorasCompletadas=0;
                oFase.Estado = BEEEstadoWI.Pendiente;
                oFase.Proyecto=oProyecto;
                return oFase;
            }
        }

        #endregion
        #region Eventos
        private void frmAbmFases_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modificar)
                {
                    grbRegistrar.Visible = false;
                    grbModificar.Visible = true;
                    cbxEstadoMod.DataSource = Enum.GetValues(typeof(BEEEstadoWI));
                    PoblarInputsMod(oFase);
                }
                else
                {
                    grbModificar.Visible = false;
                    grbRegistrar.Visible = true;
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

        private void btnLimpiarMod_Click(object sender, EventArgs e)
        {
            try
            {
                txtTituloMod.Text = null;
                txtDescripcionMod.Text = null;
                txtHorasEstimadasMod.Text = null;
                cbxEstadoMod.SelectedIndex = 0;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnLimpiarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                txtTituloAlta.Text = null;
                txtDescripcionAlta.Text = null;
                txtHorasEstimadasAlta.Text = null;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Modificar)
                {
                    oFase = AsignarFase();
                    gestorWorkItems.ModificarWorkItem(oFase);
                    MessageBox.Show($"La fase ha sido modificada de forma exitosa", "Modificación exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    oFase = AsignarFase();
                    gestorWorkItems.AgregarWorkItem(oFase);
                    MessageBox.Show($"La fase se ha agregado de forma exitosa!", "Alta exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
