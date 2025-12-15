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
    public partial class frmAbmTareas : Form
    {
        public bool Modificar { get; set; }


        BETarea oTarea;
        BEFase oFase;
        BLLWorkItem gestorWorkItems;

        public frmAbmTareas(BETarea oTarea)//constructor para mod
        {
            InitializeComponent();
            this.oTarea = oTarea;
            gestorWorkItems=new BLLWorkItem();
        }
        public frmAbmTareas(BEFase oFase)//constructor para alta
        {
            InitializeComponent();
            this.oFase = oFase;
            oTarea=new BETarea();
            gestorWorkItems=new BLLWorkItem();
        }

        #region Métodos
        void PoblarInputsMod(BETarea oTarea)
        {
            txtTituloMod.Text=oTarea.Titulo;
            txtDescripcionMod.Text=oTarea.Descripcion;
            txtHorasRestantesMod.Text=oTarea.HorasRestantes.ToString();
            txtHorasCompletadasMod.Text=oTarea.HorasCompletadas.ToString();
            txtHorasEstimadasMod.Text=oTarea.HorasEstimadas.ToString();
            cbxEstadoMod.Text=oTarea.Estado.ToString();
        }

        public BETarea AsignarTarea()
        {
            if (Modificar)
            {
                //
                UIHelper.ValidarTitulo(txtTituloMod.Text);
                UIHelper.ValidarDescripcion(txtDescripcionMod.Text);
                UIHelper.ValidarHorasDecimales(txtHorasEstimadasMod.Text);
                UIHelper.ValidarHorasDecimales(txtHorasRestantesMod.Text);
                UIHelper.ValidarHorasDecimales(txtHorasCompletadasMod.Text);
                UIHelper.ValidarEstado(cbxEstadoMod.Text);
                //
                oTarea.Titulo=txtTituloMod.Text;
                oTarea.Descripcion=txtDescripcionMod.Text;
                oTarea.HorasEstimadas=decimal.Parse(txtHorasEstimadasMod.Text);
                oTarea.HorasRestantes=decimal.Parse(txtHorasRestantesMod.Text);
                oTarea.HorasCompletadas=decimal.Parse(txtHorasCompletadasMod.Text);
                oTarea.Estado=(BEEEstadoWI)cbxEstadoMod.SelectedItem;
                return oTarea;
            }
            else
            {
                //
                UIHelper.ValidarTitulo(txtTituloAlta.Text);
                UIHelper.ValidarDescripcion(txtDescripcionAlta.Text);
                UIHelper.ValidarHorasDecimales(txtHorasEstimadasAlta.Text);
                UIHelper.ValidarHorasDecimales(txtHorasRestantesAlta.Text);
                UIHelper.ValidarHorasDecimales(txtHorasCompletadasAlta.Text);

                //
                oTarea.Titulo=txtTituloAlta.Text;
                oTarea.Descripcion=txtDescripcionAlta.Text;
                oTarea.HorasEstimadas=decimal.Parse(txtHorasEstimadasAlta.Text);
                oTarea.HorasRestantes=decimal.Parse(txtHorasRestantesAlta.Text);
                oTarea.HorasCompletadas=0;
                oTarea.Estado=BEEEstadoWI.Pendiente;
                oTarea.Fase=oFase;
                return oTarea;
            }
        }

        #endregion
        #region Eventos
        private void frmAbmTareas_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modificar)
                {
                    grbRegistrar.Visible = false;
                    grbModificar.Visible = true;
                    cbxEstadoMod.DataSource = Enum.GetValues(typeof(BEEEstadoWI));
                    PoblarInputsMod(oTarea);
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
                txtHorasRestantesMod.Text = null;
                txtHorasCompletadasMod.Text = null;
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
                txtHorasRestantesAlta.Text = null;
                txtHorasCompletadasAlta.Text = null;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Modificar)
                {
                    oTarea = AsignarTarea();
                    gestorWorkItems.ModificarWorkItem(oTarea);
                    MessageBox.Show($"La tarea ha sido modificada de forma exitosa", "Modificación exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    oTarea = AsignarTarea();
                    gestorWorkItems.AgregarWorkItem(oTarea);
                    MessageBox.Show($"La tarea se ha agregado de forma exitosa!", "Alta exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
