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
    public partial class frmModuloUsuarios : Form
    {
        BEUsuario oUsuario;
        BLLUsuario gestorUsuarios;
        BEUsuario oUsuarioLogeado;
        public frmModuloUsuarios(BEUsuario oUsuarioLogeado)
        {
            InitializeComponent();
            this.oUsuarioLogeado=oUsuarioLogeado;
            oUsuario = new BEUsuario();
            gestorUsuarios = new BLLUsuario();
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

        void CargarDgvUsuarios()
        {
            dgvListaUsuarios.DataSource=null;
            dgvListaUsuarios.DataSource= gestorUsuarios.ListarUsuariosActivos();
            dgvListaUsuarios.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        public BEUsuario SeleccionarUsuario()
        {
            oUsuario = (BEUsuario)dgvListaUsuarios.CurrentRow.DataBoundItem;
            return oUsuario;
        }


        public void VerificarSeleccionUsuario()
        {
            if (dgvListaUsuarios.SelectedRows.Count==0)
            {
                throw new InvalidOperationException("Debe seleccionar un usuario");
            }
        }

        public void PoblarInputs(BEUsuario oUsuario)
        {
            txtUsername.Text=oUsuario.Username;
            txtPassword.Text=oUsuario.Password;
        }

        public void DespoblarInputs()
        {
            if (dgvListaUsuarios.Rows.Count==0)
            {
                txtUsername.Text=null;
                txtPassword.Text=null;
            }
        }
        #endregion
        #region Eventos
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                frmAbmUsuarios frm = new frmAbmUsuarios();
                frm.ShowDialog();
                CargarDgvUsuarios();
                btnDesencriptar.Text="Desencriptar";
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnModificarr_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionUsuario();
                oUsuario=SeleccionarUsuario();
                oUsuario.Password=Encriptador.Desencriptar(oUsuario.Password);
                frmAbmUsuarios frm = new frmAbmUsuarios(oUsuario);
                frm.Modificar = true;
                frm.ShowDialog();
                CargarDgvUsuarios();
                btnDesencriptar.Text="Desencriptar";

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void frmModuloUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarEstiloDGV(dgvListaUsuarios);
                CargarDgvUsuarios();
                btnDesencriptar.Text="Desencriptar";
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void dgvListaUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                oUsuario = SeleccionarUsuario();
                PoblarInputs(oUsuario);
                btnDesencriptar.Text="Desencriptar";
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionUsuario();
                oUsuario = SeleccionarUsuario();

                DialogResult confirmacion = MessageBox.Show($"Esta seguro de eliminar el usuario {oUsuario} ?", "Confirmar baja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {

                    gestorUsuarios.VerificarAdmin(oUsuario);
                    gestorUsuarios.VerificarAutoEliminacion(oUsuario,oUsuarioLogeado);
                    oUsuario.Activo=0;
                    gestorUsuarios.EliminarUsuario(oUsuario);
                    CargarDgvUsuarios();
                    btnDesencriptar.Text="Desencriptar";
                    MessageBox.Show($"El usuario ha sido eliminado de forma exitosa", "Baja exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DespoblarInputs();
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListaUsuarios.Rows.Count!=0)
                {
                    if (btnDesencriptar.Text=="Desencriptar"&&txtPassword.Text!=null)
                    {
                        txtPassword.Text=Encriptador.Desencriptar(txtPassword.Text);
                        btnDesencriptar.Text="Encriptar";
                    }
                    else
                    {
                        txtPassword.Text=Encriptador.Encriptar(txtPassword.Text);
                        btnDesencriptar.Text="Desencriptar";
                    }
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
