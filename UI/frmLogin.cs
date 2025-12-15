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
    public partial class frmLogin : Form
    {
        BLLUsuario gestorUsuarios;
        BEUsuario oUsuario;
        public frmLogin()
        {
            InitializeComponent();
            gestorUsuarios = new BLLUsuario();
            oUsuario = new BEUsuario();
        }

        #region Métodos
        BEUsuario AsignarUsuario()
        {
            oUsuario.Username=txtUsername.Text;
            oUsuario.Password=Encriptador.Encriptar(txtPassword.Text);
            return oUsuario;
        }

        #endregion
        #region Eventos
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
              Application.Exit();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnLimpiarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                txtUsername.Text=null;
                txtPassword.Text=null;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                oUsuario=AsignarUsuario();
                gestorUsuarios.VerificarUsuarioExistente(oUsuario);
                oUsuario= gestorUsuarios.TraerUsuario(oUsuario);
                txtUsername.Text=null;
                txtPassword.Text=null;

                this.Hide();
                frmMenu frm = new frmMenu(oUsuario);
                frm.Show();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                txtUsername.Text = null;
                txtPassword.Text = null;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void picEyeOpen_Click(object sender, EventArgs e)
        {
            try
            {
                picEyeOpen.Visible= false;
                picEyeClosed.Visible= true;
                txtPassword.UseSystemPasswordChar=true;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void picEyeClosed_Click(object sender, EventArgs e)
        {
            try
            {
                picEyeClosed.Visible= false;
                picEyeOpen.Visible= true;
                txtPassword.UseSystemPasswordChar=false;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
