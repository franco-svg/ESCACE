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
    public partial class frmAbmRolesArq : Form
    {
        public bool Modificar { get; set; }

        BERolArq oRol;
        BLLRolArq gestorRoles;

        public frmAbmRolesArq(BERolArq oRol)//constructor para modificar
        {
            InitializeComponent();
            this.oRol = oRol;
            gestorRoles = new BLLRolArq();
        }
        public frmAbmRolesArq()//constructor para registrar
        {
            InitializeComponent();
            oRol=new BERolArq();
            gestorRoles = new BLLRolArq();
        }

        #region Métodos
        void PoblarInputsMod(BERolArq oRol)
        {
            txtTituloMod.Text=oRol.Nombre;
        }

        public BERolArq AsignarRol()
        {
            if (Modificar)
            {
                UIHelper.ValidarTitulo(txtTituloMod.Text);
                oRol.Nombre=txtTituloMod.Text;
                return oRol;
            }
            else
            {
                UIHelper.ValidarTitulo(txtTituloAlta.Text);
                oRol.Nombre=txtTituloAlta.Text;
                return oRol;
            }
        }
        #endregion
        #region Eventos
        private void frmAbmRolesArq_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modificar)
                {
                    grbRegistrar.Visible = false;
                    grbModificar.Visible = true;
                    PoblarInputsMod(oRol);
                }
                else
                {
                    grbModificar.Visible = false;
                    grbRegistrar.Visible = true;
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnLimpiarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                txtTituloAlta.Text = null;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnLimpiarMod_Click(object sender, EventArgs e)
        {
            try
            {
                txtTituloMod.Text = null;
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
                    gestorRoles.ModificarRolArq(oRol);
                    MessageBox.Show($"El rol ha sido modificado de forma exitosa", "Modificación exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    oRol = AsignarRol();
                    gestorRoles.AgregarRolArq(oRol);
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
