using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmModuloRestores : Form
    {
        BEUsuario oUsuario;
        BERestore oRestore;
        BLLRestore gestorRestores;
        BLLBackup gestorBackups;
        BEBitacora oBitacora;
        BLLBitacora gestorBitacoras;
        public frmModuloRestores(BEUsuario oUsuario)
        {
            InitializeComponent();
            oRestore = new BERestore();
            gestorRestores = new BLLRestore();
            gestorBackups = new BLLBackup();
            oBitacora=new BEBitacora();
            gestorBitacoras=new BLLBitacora();
            this.oUsuario=oUsuario;
        }

        #region Métodos
        void CargarLtbArchivosBackup()
        {
            ltbListaArchivosBackup.DataSource=null;
            ltbListaArchivosBackup.DataSource=gestorBackups.ListarArchivosBackups();
        }
        public BERestore AsignarRestore()
        {
            oRestore.Detalle="restore";
            oRestore.Fecha=DateTime.Now;
            oRestore.Usuario=oUsuario;
            return oRestore;
        }

        public BEBitacora AsignarBitacora(BERestore oRestore)
        {
            oBitacora.Detalle=oRestore.Detalle;
            oBitacora.Fecha=oRestore.Fecha;
            oBitacora.Usuario=oRestore.Usuario;
            return oBitacora;
        }

        public string SeleccionarArchivosBackup()
        {
            string archivoBackup = ltbListaArchivosBackup.SelectedItem.ToString();
            return archivoBackup;
        }

        public void VerificarSeleccionArchivosBackup()
        {
            if (ltbListaArchivosBackup.SelectedItem==null)
            {
                throw new InvalidOperationException("Debe seleccionar un backup para restorear");
            }
        }
        #endregion
        #region Eventos
        private void frmModuloRestores_Load(object sender, EventArgs e)
        {
            try
            {
                CargarLtbArchivosBackup();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }

        }

        private void btnRealizarRestore_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionArchivosBackup();
                string nombreBackup = SeleccionarArchivosBackup();

                oRestore= AsignarRestore();
                oBitacora=AsignarBitacora(oRestore);

                gestorRestores.RealizarRestore(nombreBackup, oRestore);
                gestorBitacoras.AgregarBitacora(oBitacora);
                MessageBox.Show($"El restore se ha realizado de forma exitosa!", "Restore exitoso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
