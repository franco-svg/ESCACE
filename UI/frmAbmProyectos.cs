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
    public partial class frmAbmProyectos : Form
    {

        public bool Modificar { get; set; }

        BEProyecto oProyecto;
        BLLProyecto gestorProyectos;
        BEFichaProyecto oFicha;
        BLLFichaProyecto gestorFichas;

        public frmAbmProyectos(BEProyecto oProyecto)//constructor para modificacion
        {

            InitializeComponent();
            this.oProyecto=oProyecto;
            gestorProyectos =new BLLProyecto();

        }

        public frmAbmProyectos()//constructor para modificacion
        {
            InitializeComponent();
            oProyecto = new BEProyecto();
            gestorProyectos=new BLLProyecto();
            oFicha=new BEFichaProyecto();
            gestorFichas = new BLLFichaProyecto();

        }

        #region Métodos
        void CargarLtbFichas()
        {
            ltbListaFichas.DataSource=null;
            ltbListaFichas.DataSource=gestorFichas.ListarFichasDisponibles();
        }

        void PoblarInputsMod(BEProyecto oProyecto)
        {
            txtTituloMod.Text=oProyecto.Titulo;
            txtDescripcionMod.Text=oProyecto.Descripcion;
            txtFichaMod.Text=oProyecto.FichaProyecto.ToString();
            txtHorasMod.Text=oProyecto.HorasEstimadas.ToString();
            cbxEstadoMod.Text =oProyecto.Estado.ToString();

        }

        public BEFichaProyecto SeleccionarFicha()
        {
            oFicha=(BEFichaProyecto)ltbListaFichas.SelectedItem;
            return oFicha;
        }

        void PoblarHoras(BEFichaProyecto oFicha)
        {
            txtHorasAlta.Text=oFicha.Horas.ToString();
        }

        public void VerificarSeleccionFicha()
        {
            if (ltbListaFichas.SelectedItem==null)
            {
                throw new InvalidOperationException("Debe seleccionar una ficha de proyecto");
            }
        }

        public BEProyecto AsignarProyecto()
        {
            if (Modificar)
            {
                //validaciones con regex
                UIHelper.ValidarTitulo(txtTituloMod.Text);
                UIHelper.ValidarDescripcion(txtDescripcionMod.Text);
                UIHelper.ValidarEstado(cbxEstadoMod.Text);
                //\validaciones con regex

                oProyecto.Titulo=txtTituloMod.Text;
                oProyecto.Descripcion=txtDescripcionMod.Text;
                //oProyecto.HorasEstimadas=oProyecto.HorasEstimadas;
                oProyecto.Estado=(BEEEstadoProyecto)cbxEstadoMod.SelectedItem;
                return oProyecto;
            }
            else
            {
                //validaciones con regex
                UIHelper.ValidarTitulo(txtTituloAlta.Text);
                UIHelper.ValidarDescripcion(txtDescripcionAlta.Text);
                //\validaciones con regex

                VerificarSeleccionFicha();
                oProyecto.Titulo=txtTituloAlta.Text;
                oProyecto.Descripcion=txtDescripcionAlta.Text;
                oProyecto.Estado=BEEEstadoProyecto.Pendiente;
                oProyecto.FichaProyecto=SeleccionarFicha();
                oProyecto.HorasEstimadas=oProyecto.FichaProyecto.Horas;
                oProyecto.HorasCompletadas=0;
                oProyecto.HorasRestantes=0;
                return oProyecto;
            }

        }
        #endregion

        #region Eventos
        private void frmAbmProyectos_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modificar)
                {
                    grbRegistrar.Visible = false;
                    grbModificar.Visible = true;
                    grbFichasDisponibles.Visible = false;
                    this.Width = 600;
                    this.Height = 600;
                    pnlHeader.Width = 555;
                    cbxEstadoMod.DataSource = Enum.GetValues(typeof(BEEEstadoProyecto));
                    PoblarInputsMod(oProyecto);
                }
                else
                {
                    grbModificar.Visible = false;
                    grbRegistrar.Visible = true;
                    grbFichasDisponibles.Visible = true;
                    this.Width = 850;
                    this.Height = 600;
                    pnlHeader.Width = 810;
                    CargarLtbFichas();
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void ltbListaFichas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PoblarHoras(SeleccionarFicha());
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnLimpiarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                txtTituloAlta.Text = null;
                txtDescripcionAlta.Text = null;
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
                    gestorProyectos.ModificarProyecto(AsignarProyecto());
                    MessageBox.Show($"El proyecto ha sido modificado de forma exitosa",
                        "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    gestorProyectos.AgregarProyecto(AsignarProyecto());
                    MessageBox.Show($"El proyecto se ha agregado de forma exitosa!",
                        "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
