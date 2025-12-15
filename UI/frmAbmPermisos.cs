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
    public partial class frmAbmPermisos : Form
    {
        BEPermiso oPermiso;
        BLLPermiso gestorPermisos;
        public frmAbmPermisos()
        {
            InitializeComponent();
            oPermiso= new BEPermiso();
            gestorPermisos= new BLLPermiso();
        }

        #region Métodos
        public BEPermiso AsignarPermiso()
        {
            UIHelper.ValidarTitulo(txtTitulo.Text);
            oPermiso.Nombre=txtTitulo.Text;
            return oPermiso;
        }
        #endregion
        #region Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                txtTitulo.Text=null;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                oPermiso=AsignarPermiso();
                gestorPermisos.AgregarPermiso(oPermiso);
                MessageBox.Show($"El permiso se ha agregado de forma exitosa!", "Alta exitosa",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
