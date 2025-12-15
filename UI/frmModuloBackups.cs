using BE;
using BLL;
using iText.Kernel.Pdf.Tagutils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmModuloBackups : Form
    {
        BEUsuario oUsuario;
        BEBackup oBackup;
        BLLBackup gestorBackups;
        BEBitacora oBitacora;
        BLLBitacora gestorBitacoras;
        public frmModuloBackups(BEUsuario oUsuario)
        {
            InitializeComponent();
            oBackup=new BEBackup();
            oBitacora=new BEBitacora();
            gestorBitacoras=new BLLBitacora();
            gestorBackups = new BLLBackup();
            this.oUsuario = oUsuario;
        }
        #region Métodos
        public void ConfigurarEstiloDGV(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;

            // Encabezados
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(68, 125, 155);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor=Color.FromArgb(68, 125, 155);
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor=Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 11, FontStyle.Bold);

            // Filas normales
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(118, 175, 205);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font=new Font("Bahnschrift", 10, FontStyle.Regular);


            // Bordes
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        }

        void CargarDgvBackups()
        {
            this.dgvListaBackups.DataSource=null;
            this.dgvListaBackups.DataSource= gestorBackups.ListarBackups();
            this.dgvListaBackups.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        public BEBackup SeleccionarBackup()
        {
            oBackup = (BEBackup)dgvListaBackups.CurrentRow.DataBoundItem;
            return oBackup;
        }

        public void VerificarSeleccionBackup()
        {
            if (dgvListaBackups.SelectedRows.Count==0)
            {
                throw new InvalidOperationException("Debe seleccionar un backup");
            }
        }

        void PoblarInputs(BEBackup oBackup)
        {
                txtUsername.Text=oBackup.Usuario.Username;
        }

        public BEBackup AsignarBackup()
        {
            oBackup.Detalle="backup";
            oBackup.Fecha=DateTime.Now;
            oBackup.Usuario=oUsuario;
            return oBackup;
        }
        public BEBitacora AsignarBitacora(BEBackup oBackup)
        {
            oBitacora.Detalle=oBackup.Detalle;
            oBitacora.Fecha=oBackup.Fecha;
            oBitacora.Usuario=oBackup.Usuario;
            return oBitacora;
        }
        #endregion
        #region Eventos
        private void frmModuloBackups_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarEstiloDGV(dgvListaBackups);
                CargarDgvBackups();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnRegistrarBackup_Click_1(object sender, EventArgs e)
        {
            try
            {
                oBackup= AsignarBackup();
                oBitacora=AsignarBitacora(oBackup);

                gestorBackups.RealizarBackup(oBackup);
                gestorBitacoras.AgregarBitacora(oBitacora);

                CargarDgvBackups();
                MessageBox.Show($"El backup se ha realizado de forma exitosa!", "Backup exitoso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void dgvListaBackups_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                PoblarInputs(SeleccionarBackup());
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
