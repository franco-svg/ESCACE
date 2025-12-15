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
    public partial class frmModuloColaboradores : Form
    {
        BLLColaborador gestorColaboradores;
        BEColaborador oColaborador;

        public frmModuloColaboradores()
        {
            InitializeComponent();
            gestorColaboradores = new BLLColaborador();
            oColaborador = new BEColaborador();
        }

        #region Métodos
        public void ConfigurarEstiloDGV(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(68, 125, 155);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor=Color.FromArgb(68, 125, 155);
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor=Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 11, FontStyle.Bold);

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(118, 175, 205);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font=new Font("Bahnschrift", 10, FontStyle.Regular);


            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

        }


        public BEColaborador SeleccionarColaborador()
        {
            oColaborador = (BEColaborador)dgvListaColaboradores.CurrentRow.DataBoundItem;
            return oColaborador;
        }

        void CargarDgvColaborador()
        {
            this.dgvListaColaboradores.DataSource=null;
            this.dgvListaColaboradores.DataSource= gestorColaboradores.ListarColaboradores();
            this.dgvListaColaboradores.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        public void VerificarSeleccionColaborador()
        {
            if (dgvListaColaboradores.SelectedRows.Count==0)
            {
                throw new InvalidOperationException("Debe seleccionar un colaborador");
            }
        }

        public void PoblarInputs(BEColaborador oColaborador)
        {
            txtNombre.Text=oColaborador.Nombre;
            txtApellido.Text=oColaborador.Apellido;
            txtDni.Text=oColaborador.Dni;
            txtEmail.Text=oColaborador.Email;
            txtTelefono.Text=oColaborador.Telefono;
            txtRol.Text=oColaborador.Rol.ToString();
            txtSeniority.Text=oColaborador.Seniority.ToString();
        }

        void DespoblarInputs()
        {
            if (dgvListaColaboradores.Rows.Count==0)
            {
                txtNombre.Text=null;
                txtApellido.Text=null;
                txtDni.Text=null;
                txtEmail.Text=null;
                txtTelefono.Text=null;
                txtRol.Text=null;
                txtSeniority.Text=null;
            }
        }
        #endregion
        #region Eventos
        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmAbmColaboradores frm = new frmAbmColaboradores();
                frm.ShowDialog();
                CargarDgvColaborador();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionColaborador();
                frmAbmColaboradores frm = new frmAbmColaboradores(SeleccionarColaborador());
                frm.Modificar=true;
                frm.ShowDialog();
                CargarDgvColaborador();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void frmModuloColaboradores_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarEstiloDGV(dgvListaColaboradores);
                CargarDgvColaborador();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void dgvListaColaboradores_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                PoblarInputs(SeleccionarColaborador());
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionColaborador();
                oColaborador = SeleccionarColaborador();

                DialogResult confirmacion = MessageBox.Show($"Esta seguro de eliminar el colaborador {oColaborador} ?", "Confirmar baja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    gestorColaboradores.VerificarPresenciaProyecto(oColaborador);

                    gestorColaboradores.EliminarColaborador(oColaborador);
                    CargarDgvColaborador();
                    MessageBox.Show($"El colaborador ha sido eliminado de forma exitosa", "Baja exitosa",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DespoblarInputs();
                }

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
