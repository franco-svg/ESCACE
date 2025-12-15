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
    public partial class frmAbmColaboradores : Form
    {

        public bool Modificar { get; set; }

        BEColaborador oColaborador;
        BLLColaborador gestorColaboradores;
        BLLRol gestorRoles;

        public frmAbmColaboradores(BEColaborador oColaborador)//constructor para mod
        {
            InitializeComponent();
            this.oColaborador=oColaborador;
            gestorColaboradores=new BLLColaborador();
            gestorRoles=new BLLRol();
        }

        public frmAbmColaboradores()//constructor para alta
        {
            InitializeComponent();
            gestorColaboradores=new BLLColaborador();
            oColaborador=new BEColaborador();
            gestorRoles=new BLLRol();

        }

        #region Métodos
        void PoblarInputsMod(BEColaborador oColaborador)
        {
            txtNombreMod.Text=oColaborador.Nombre;
            txtApellidoMod.Text=oColaborador.Apellido;
            txtDniMod.Text= oColaborador.Dni;
            txtEmailMod.Text= oColaborador.Email;
            txtTelefonoMod.Text= oColaborador.Telefono;
            cbxRolMod.Text=oColaborador.Rol.ToString();
            cbxSeniorityMod.Text=oColaborador.Seniority.ToString();
        }

        public BEColaborador AsignarColaborador()
        {
            if (Modificar)
            {
                //validaciones regex
                UIHelper.ValidarNombreColaborador(txtNombreMod.Text);
                UIHelper.ValidarApellido(txtApellidoMod.Text);
                UIHelper.ValidarEmail(txtEmailMod.Text);
                UIHelper.ValidarDni(txtDniMod.Text);
                UIHelper.ValidarTelefono(txtTelefonoMod.Text, "+54");
                UIHelper.ValidarRol(cbxRolMod.Text);
                UIHelper.ValidarSeniority(cbxSeniorityMod.Text);
                //\validaciones regex

                oColaborador.Nombre=txtNombreMod.Text;
                oColaborador.Apellido=txtApellidoMod.Text;
                oColaborador.Dni=txtDniMod.Text;
                gestorColaboradores.ValidarDniCargado(oColaborador);
                oColaborador.Email=txtEmailMod.Text;
                oColaborador.Telefono=txtTelefonoMod.Text;
                oColaborador.Rol=(BERol)cbxRolMod.SelectedItem;
                oColaborador.Seniority=(BEESeniority)cbxSeniorityMod.SelectedItem;
                return oColaborador;
            }
            else
            {
                //validaciones regex
                UIHelper.ValidarNombreColaborador(txtNombreAlta.Text);
                UIHelper.ValidarApellido(txtApellidoAlta.Text);
                UIHelper.ValidarEmail(txtEmailAlta.Text);
                UIHelper.ValidarDni(txtDniAlta.Text);
                UIHelper.ValidarTelefono(txtTelefonoAlta.Text, "+54");
                UIHelper.ValidarRol(cbxRolAlta.Text);
                UIHelper.ValidarSeniority(cbxSeniorityAlta.Text);
                //\validaciones regex

                oColaborador.Nombre=txtNombreAlta.Text;
                oColaborador.Apellido=txtApellidoAlta.Text;
                oColaborador.Dni=txtDniAlta.Text;
                gestorColaboradores.ValidarDniCargado(oColaborador);
                oColaborador.Email=txtEmailAlta.Text;
                oColaborador.Telefono=txtTelefonoAlta.Text;
                oColaborador.Rol=(BERol)cbxRolAlta.SelectedItem;
                oColaborador.Seniority=(BEESeniority)cbxSeniorityAlta.SelectedItem;
                return oColaborador;
            }
        }

        #endregion
        #region Eventos
        private void frmAbmColaboradores_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modificar)
                {
                    grbRegistrar.Visible = false;
                    grbModificar.Visible = true;
                    cbxRolMod.DataSource = gestorRoles.ListarRoles();
                    cbxSeniorityMod.DataSource = Enum.GetValues(typeof(BEESeniority));
                    PoblarInputsMod(oColaborador);
                }
                else
                {
                    grbModificar.Visible = false;
                    grbRegistrar.Visible = true;
                    cbxRolAlta.DataSource = gestorRoles.ListarRoles();
                    cbxRolAlta.Text = null;

                    cbxSeniorityAlta.DataSource = Enum.GetValues(typeof(BEESeniority));
                    cbxSeniorityAlta.SelectedIndex = 0;
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnLimpiarAlta_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtNombreAlta.Text = null;
                txtApellidoAlta.Text = null;
                txtEmailAlta.Text = null;
                txtDniAlta.Text = null;
                txtTelefonoAlta.Text = null;
                cbxRolAlta.Text = null;
                cbxSeniorityAlta.SelectedIndex = 0;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnLimpiarMod_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombreMod.Text = null;
                txtApellidoMod.Text = null;
                txtEmailMod.Text = null;
                txtTelefonoMod.Text = null;
                txtDniMod.Text = null;
                cbxRolMod.Text = null;
                cbxSeniorityMod.SelectedIndex = 0;
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
                    oColaborador = AsignarColaborador();
                    gestorColaboradores.ModificarColaborador(oColaborador);
                    MessageBox.Show($"El colaborador ha sido modificado de forma exitosa", "Modificación exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    oColaborador = AsignarColaborador();
                    gestorColaboradores.AgregarColaborador(oColaborador);
                    MessageBox.Show($"El colaborador se ha agregado de forma exitosa!", "Alta exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}

