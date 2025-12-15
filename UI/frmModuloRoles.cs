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
    public partial class frmModuloRoles : Form
    {

        BERol oRol;
        BLLRol gestorRoles;
        public frmModuloRoles()
        {
            InitializeComponent();
            oRol= new BERol();
            gestorRoles = new BLLRol();
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
        void CargarDgvRoles()
        {
            this.dgvListaRoles.DataSource=null;
            this.dgvListaRoles.DataSource= gestorRoles.ListarRoles();
            this.dgvListaRoles.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        public BERol SeleccionarRol()
        {
            oRol = (BERol)dgvListaRoles.CurrentRow.DataBoundItem;
            return oRol;
        }


        public void VerificarSeleccionRol()
        {
            if (dgvListaRoles.SelectedRows.Count==0)
            {
                throw new InvalidOperationException("Debe seleccionar un rol");
            }
        }

        public void PoblarInputs(BERol oRol)
        {
            txtNombre.Text=oRol.Nombre;
            txtDescripcion.Text=oRol.Descripcion;
            txtCategoria.Text=oRol.Categoria.ToString();
        }

        void DespoblarInputs()
        {
            if (dgvListaRoles.Rows.Count==0)
            {
                txtNombre.Text=null;
                txtDescripcion.Text=null;
                txtCategoria.Text=null;
            }
        }
        #endregion
        #region Eventos
        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmAbmRoles frm = new frmAbmRoles();
                frm.ShowDialog();
                CargarDgvRoles();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionRol();
                frmAbmRoles frm = new frmAbmRoles(SeleccionarRol());
                frm.Modificar = true;
                frm.ShowDialog();
                CargarDgvRoles();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void frmModuloRoles_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarEstiloDGV(dgvListaRoles);
                CargarDgvRoles();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }


        private void dgvListaRoles_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                oRol = SeleccionarRol();
                PoblarInputs(oRol);
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionRol();
                oRol = SeleccionarRol();

                DialogResult confirmacion = MessageBox.Show($"Esta seguro de eliminar el rol {oRol} ?", "Confirmar baja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    gestorRoles.VerificarPresenciaColaborador(oRol);
                    gestorRoles.EliminarRol(oRol);
                    CargarDgvRoles();
                    MessageBox.Show($"El rol ha sido eliminado de forma exitosa", "Baja exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DespoblarInputs();
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
