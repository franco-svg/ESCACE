using BE;
using BLL;
using SEC;
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
    public partial class frmAbmUsuarios : Form
    {
        public bool Modificar { get; set; }

        BEUsuario oUsuario;
        BLLUsuario gestorUsuarios;

        public frmAbmUsuarios(BEUsuario oUsuario)//constructor para mod
        {
            InitializeComponent();
            this.oUsuario=oUsuario;
            gestorUsuarios = new BLLUsuario();
        }
        public frmAbmUsuarios()//constructor para alta
        {
            InitializeComponent();
            oUsuario=new BEUsuario();
            gestorUsuarios = new BLLUsuario();
        }

        #region Métodos
        void PoblarInputsMod(BEUsuario oUsuario)
        {
            txtUsernameMod.Text=oUsuario.Username;
            txtPasswordMod.Text=oUsuario.Password;
        }
        public BEUsuario AsignarUsuario()
        {
            if (Modificar)
            {
                //
                UIHelper.ValidarUsername(txtUsernameMod.Text);
                UIHelper.ValidarPassword(txtPasswordMod.Text);
                //
                oUsuario.Username = txtUsernameMod.Text;
                gestorUsuarios.VerificarUsernameExistente(oUsuario);
                oUsuario.Password= Encriptador.Encriptar(txtPasswordMod.Text); //aca entra en juego el encriptador 
                oUsuario.Activo=1;
                return oUsuario;
            }
            else
            {
                //
                UIHelper.ValidarUsername(txtUsernameAlta.Text);
                UIHelper.ValidarPassword(txtPasswordAlta.Text);
                //
                oUsuario.Username = txtUsernameAlta.Text;
                gestorUsuarios.VerificarUsernameExistente(oUsuario);
                oUsuario.Password= Encriptador.Encriptar(txtPasswordAlta.Text); //aca entra en juego el encriptador 
                oUsuario.Activo=1;
                return oUsuario;
            }
        }
        #endregion
        #region Eventos
        private void btnLimpiarMod_Click(object sender, EventArgs e)
        {
            try
            {
                txtUsernameMod.Text=null;
                txtPasswordMod.Text=null;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnLimpiarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                txtUsernameAlta.Text=null;
                txtPasswordAlta.Text=null;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void frmAbmUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modificar)
                {
                    grbRegistrar.Visible = false;
                    grbModificar.Visible = true;
                    PoblarInputsMod(oUsuario);
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Modificar)
                {
                    oUsuario = AsignarUsuario();
                    gestorUsuarios.ModificarUsuario(oUsuario);
                    MessageBox.Show($"El usuario ha sido modificado de forma exitosa", "Modificación exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    oUsuario = AsignarUsuario();
                    gestorUsuarios.AgregarUsuario(oUsuario);
                    MessageBox.Show($"El usuario se ha agregado de forma exitosa!", "Alta exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
