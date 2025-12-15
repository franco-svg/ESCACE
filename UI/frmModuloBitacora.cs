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
    public partial class frmModuloBitacora : Form
    {
        BEBitacora oBitacora;
        BLLBitacora gestorBitacoras;
        public frmModuloBitacora()
        {
            InitializeComponent();
            oBitacora = new BEBitacora();
            gestorBitacoras = new BLLBitacora();
        }

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


        void CargarDgvBitacorasCompleto()
        {
            this.dgvListaBitacoras.DataSource=null;
            this.dgvListaBitacoras.DataSource= gestorBitacoras.ListarBitacorasCompleto();
            this.dgvListaBitacoras.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        void CargarDgvBitacorasBackups()
        {
            this.dgvListaBitacoras.DataSource=null;
            this.dgvListaBitacoras.DataSource= gestorBitacoras.ListarBitacorasBackup();
            this.dgvListaBitacoras.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        void CargarDgvBitacorasRestores()
        {
            this.dgvListaBitacoras.DataSource=null;
            this.dgvListaBitacoras.DataSource= gestorBitacoras.ListarBitacorasRestore();
            this.dgvListaBitacoras.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        public BEBitacora SeleccionarBitacora()
        {
            oBitacora= (BEBitacora)dgvListaBitacoras.CurrentRow.DataBoundItem;
            return oBitacora;
        }

        void PoblarInputs(BEBitacora oBitacora)
        {
            txtUsername.Text=oBitacora.Usuario.Username;
        }

        public void ColorearBotones()
        {
            btnListarBackups.FillColor=Color.FromArgb(68, 125, 155);
            btnListarRestores.FillColor=Color.FromArgb(68, 125, 155);
            btnListarTodo.FillColor=Color.FromArgb(68, 125, 155);
        }

        private void frmModuloBitacora_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarEstiloDGV(dgvListaBitacoras);
                CargarDgvBitacorasCompleto();
                btnListarTodo.FillColor=Color.FromArgb(254, 119, 67);
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnListarTodo_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDgvBitacorasCompleto();
                ColorearBotones();
                btnListarTodo.FillColor=Color.FromArgb(254, 119, 67);
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnListarBackups_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDgvBitacorasBackups();
                ColorearBotones();
                btnListarBackups.FillColor=Color.FromArgb(254, 119, 67);
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnListarRestores_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDgvBitacorasRestores();
                ColorearBotones();
                btnListarRestores.FillColor=Color.FromArgb(254, 119, 67);
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void dgvListaBitacoras_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                PoblarInputs(SeleccionarBitacora());
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
    }
}
