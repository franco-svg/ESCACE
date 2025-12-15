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
    public partial class frmAbmRoles : Form
    {
        public bool Modificar { get; set; }

        BERol oRol;
        BLLRol gestorRoles;
        public frmAbmRoles(BERol oRol)//CONSTRUCTOR PARA MOD
        {
            InitializeComponent();
            this.oRol = oRol;
            gestorRoles = new BLLRol();
        }

        public frmAbmRoles()//constructor para alta
        {
            InitializeComponent();
            oRol=new BERol();
            gestorRoles = new BLLRol();
        }

        #region Métodos
        void PoblarInputsMod(BERol oRol)
        {
            txtNombreMod.Text=oRol.Nombre;
            txtDescripcionMod.Text=oRol.Descripcion;
            cbxCategoriaMod.Text=oRol.Categoria.ToString();
        }

        public BERol AsignarRol()
        {
            if (Modificar)
            {
                //
                UIHelper.ValidarNombreRol(txtNombreMod.Text);
                UIHelper.ValidarDescripcion(txtDescripcionMod.Text);
                UIHelper.ValidarCategoria(cbxCategoriaMod.Text);
                //
                oRol.Nombre= txtNombreMod.Text;
                oRol.Descripcion= txtDescripcionMod.Text;
                oRol.Categoria=(BEECategoria)cbxCategoriaMod.SelectedItem;

                return oRol;
            }
            else
            {
                //
                UIHelper.ValidarNombreRol(txtNombreAlta.Text);
                UIHelper.ValidarDescripcion(txtDescripcionAlta.Text);
                UIHelper.ValidarCategoria(cbxCategoriaAlta.Text);
                //

                oRol.Nombre= txtNombreAlta.Text;
                oRol.Descripcion= txtDescripcionAlta.Text;
                oRol.Categoria=(BEECategoria)cbxCategoriaAlta.SelectedItem;
                return oRol;
            }
        }
        #endregion
        #region Eventos
        private void frmAbmRoles_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modificar)
                {
                    grbRegistrar.Visible = false;
                    grbModificar.Visible = true;
                    cbxCategoriaMod.DataSource = Enum.GetValues(typeof(BEECategoria));
                    PoblarInputsMod(oRol);
                }
                else
                {
                    grbModificar.Visible = false;
                    grbRegistrar.Visible = true;
                    cbxCategoriaAlta.DataSource = Enum.GetValues(typeof(BEECategoria));
                    cbxCategoriaAlta.SelectedIndex = 0;
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnLimpiarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombreAlta.Text = null;
                txtDescripcionAlta.Text = null;
                cbxCategoriaAlta.SelectedIndex = 0;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnLimpiarMod_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombreMod.Text = null;
                txtDescripcionMod.Text = null;
                cbxCategoriaMod.SelectedIndex = 0;
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
                    oRol = AsignarRol();
                    gestorRoles.ModificarRol(oRol);
                    MessageBox.Show($"El rol ha sido modificado de forma exitosa", "Modificación exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    oRol = AsignarRol();
                    gestorRoles.AgregarRol(oRol);
                    MessageBox.Show($"El rol se ha agregado de forma exitosa!", "Alta exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
