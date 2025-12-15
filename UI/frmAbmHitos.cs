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
    public partial class frmAbmHitos : Form
    {

        public bool Modificar { get; set; }

        BEHito oHito;
        BLLHito gestorHitos;
        BEProyecto oProyecto;
        public frmAbmHitos(BEHito oHito) //constructor para mod
        {
            InitializeComponent();
            this.oHito = oHito;
            gestorHitos = new BLLHito();
        }

        public frmAbmHitos(BEProyecto oProyecto) //constructor para alta
        {
            InitializeComponent();
            this.oProyecto = oProyecto;
            oHito = new BEHito();
            gestorHitos = new BLLHito();
        }
        #region Métodos
        void PoblarInputsMod(BEHito oHito)
        {
            txtTituloMod.Text=oHito.Titulo;
            txtCriterioAlcanceMod.Text=oHito.CriterioAlcance;
            dtpFechaMod.Value=oHito.Fecha;
            ccbAlcanzadoMod.Checked=oHito.Alcanzado;
        }

        public BEHito AsignarHito()
        {
            if (Modificar)
            {
                //
                UIHelper.ValidarTitulo(txtTituloMod.Text);
                UIHelper.ValidarCriterioAlcance(txtCriterioAlcanceMod.Text);
                //
                oHito.Titulo = txtTituloMod.Text;
                oHito.CriterioAlcance=txtCriterioAlcanceMod.Text;
                oHito.Fecha=dtpFechaMod.Value;
                oHito.Alcanzado=ccbAlcanzadoMod.Checked;
                return oHito;
            }
            else
            {
                //
                UIHelper.ValidarTitulo(txtTituloAlta.Text);
                UIHelper.ValidarCriterioAlcance(txtCriterioAlcanceAlta.Text);
                //
                oHito.Titulo = txtTituloAlta.Text;
                oHito.CriterioAlcance=txtCriterioAlcanceAlta.Text;
                oHito.Fecha=dtpFechaAlta.Value;
                oHito.Alcanzado=ccbAlcanzadoAlta.Checked;

                oHito.Proyecto=oProyecto;
                return oHito;
            }
        }

        #endregion
        #region Eventos
        private void frmAbmHitos_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modificar)
                {
                    grbRegistrar.Visible = false;
                    grbModificar.Visible = true;
                    PoblarInputsMod(oHito);
                }
                else
                {
                    grbModificar.Visible = false;
                    grbRegistrar.Visible = true;
                    dtpFechaAlta.Value = DateTime.Today;
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnLimpiarMod_Click(object sender, EventArgs e)
        {
            try
            {
                txtTituloMod.Text = null;
                txtCriterioAlcanceMod.Text = null;
                dtpFechaMod.Value = DateTime.Today;
                ccbAlcanzadoMod.Checked = false;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnLimpiarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                txtTituloAlta.Text = null;
                txtCriterioAlcanceAlta.Text = null;
                dtpFechaAlta.Value = DateTime.Today;
                ccbAlcanzadoAlta.Checked = false;
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
                    oHito = AsignarHito();
                    gestorHitos.ModificarHito(oHito);
                    MessageBox.Show($"El hito ha sido modificado de forma exitosa", "Modificación exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    oHito = AsignarHito();
                    gestorHitos.AgregarHito(oHito);
                    MessageBox.Show($"El hito se ha agregado de forma exitosa!", "Alta exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
