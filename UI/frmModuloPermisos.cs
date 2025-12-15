using BE;
using BLL;
using Org.BouncyCastle.Asn1;
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
    public partial class frmModuloPermisos : Form
    {
        BLLUsuario gestorUsuarios;
        BLLRolArq gestorRoles;
        BLLPermiso gestorPermisos;
        BERolArq oRol;
        BEUsuario oUsuario;
        BEPermiso oPermiso;
        public frmModuloPermisos()
        {
            InitializeComponent();
            gestorUsuarios = new BLLUsuario();
            gestorRoles = new BLLRolArq();
            gestorPermisos = new BLLPermiso();
            oRol=new BERolArq();
            oUsuario = new BEUsuario();
            oPermiso = new BEPermiso();
        }

        #region Métodos
        void CargarLtbUsuarios()
        {
            ltbListaUsuarios.DataSource=null;
            ltbListaUsuarios.DataSource=gestorUsuarios.ListarUsuariosActivos();
        }

        void CargarLtbRoles()
        {
            ltbListaRoles.DataSource=null;
            ltbListaRoles.DataSource=gestorRoles.ListarRoles();
        }

        void CargarLtbPermisos()
        {
            ltbListaPermisos.DataSource=null;
            ltbListaPermisos.DataSource=gestorPermisos.ListarPermisos();
        }

        void CargarTvwRolesPermisosRol(BERolArq oRol)
        {
            tvwRolesPermisosRol.Nodes.Clear();
            //Nodo raíz = Rol seleccionado
            TreeNode nodoRolPrincipal = new TreeNode(oRol.Nombre);
            nodoRolPrincipal.Tag = oRol;
            nodoRolPrincipal.ForeColor = Color.RoyalBlue;//nodo raiz siempre rol


            //carga recursivamente subroles y permisos
            AgregarHijosRecursivosColoreado(nodoRolPrincipal, oRol);

            // agrega al treeview y expandir todo
            tvwRolesPermisosRol.Nodes.Add(nodoRolPrincipal);
            tvwRolesPermisosRol.ExpandAll();
        }

        void CargarTvwRolesPermisosUsuario(BEUsuario oUsuario)
        {
            tvwRolesPermisosUsuario.Nodes.Clear();


            //Nodo raíz = Usuario seleccionado
            TreeNode nodoUsuario = new TreeNode(oUsuario.Username);
            nodoUsuario.Tag = oUsuario;
            nodoUsuario.ForeColor = Color.Black; //se configura el nodo raiz

            //Agregar los roles (con su jerarquía completa)
            if (oUsuario.Roles != null)
            {
                foreach (var rol in oUsuario.Roles)
                {
                    TreeNode nodoRol = new TreeNode(rol.Nombre);
                    nodoRol.Tag = rol;
                    nodoRol.ForeColor = Color.RoyalBlue; // azul = rol

                    // Reutiliza el método recursivo
                    AgregarHijosRecursivosColoreado(nodoRol, rol);//se rellena la rama del rol iterado

                    nodoUsuario.Nodes.Add(nodoRol);//se agrega al nodo raiz
                }
            }

            //Agregar los permisos directos del usuario
            if (oUsuario.PermisosDirectos != null)
            {
                foreach (var permiso in oUsuario.PermisosDirectos)
                {
                    TreeNode nodoPermiso = new TreeNode(permiso.Nombre);
                    nodoPermiso.Tag = permiso;
                    nodoPermiso.ForeColor = Color.SeaGreen; // verde = permiso
                    nodoUsuario.Nodes.Add(nodoPermiso);//se agrega al nodo raiz
                }
            }

            tvwRolesPermisosUsuario.Nodes.Add(nodoUsuario);
            tvwRolesPermisosUsuario.ExpandAll();
        }


        // Método recursivo con color según tipo. Al ser recursivo, permite trabajar sin tope de niveles.
        private void AgregarHijosRecursivosColoreado(TreeNode nodoPadre, BEComponente componente)//se trabaja con componente. 
        {
            var hijos = componente.ObtenerHijos();
            if (hijos == null || hijos.Count == 0)
                return;//si se trata de permiso

            foreach (var hijo in hijos)//si se trata de rol
            {
                TreeNode nodoHijo = new TreeNode(hijo.Nombre);
                nodoHijo.Tag = hijo;

                //Distinción visual
                if (hijo is BERolArq)
                    nodoHijo.ForeColor = Color.RoyalBlue; // Rol = azul
                else if (hijo is BEPermiso)
                    nodoHijo.ForeColor = Color.SeaGreen;  // Permiso = verde

                // Recurre para seguir expandiendo subroles
                AgregarHijosRecursivosColoreado(nodoHijo, hijo);

                nodoPadre.Nodes.Add(nodoHijo);
            }
        }

        public BERolArq SeleccionarRol()
        {
            oRol=(BERolArq)ltbListaRoles.SelectedItem;
            return oRol;
        }
        public void VerificarSeleccionRol()
        {
            if (ltbListaRoles.SelectedItem==null)
            {
                throw new InvalidOperationException("Debe seleccionar un rol");
            }
        }
        public BEUsuario SeleccionarUsuario()
        {
            oUsuario=(BEUsuario)ltbListaUsuarios.SelectedItem;
            return oUsuario;
        }
        public void VerificarSeleccionUsuario()
        {
            if (ltbListaUsuarios.SelectedItem==null)
            {
                throw new InvalidOperationException("Debe seleccionar un usuario");
            }
        }
        public BEPermiso SeleccionarPermiso()
        {
            oPermiso=(BEPermiso)ltbListaPermisos.SelectedItem;
            return oPermiso;
        }
        public void VerificarSeleccionPermiso()
        {
            if (ltbListaPermisos.SelectedItem==null)
            {
                throw new InvalidOperationException("Debe seleccionar un permiso");
            }
        }

        private BERolArq SeleccionarRolDirectoUsuario() //ya tiene las validaciones 
        {
            // Verificar que haya algo seleccionado
            if (tvwRolesPermisosUsuario.SelectedNode == null)
                throw new InvalidOperationException("Debe seleccionar un rol del usuario.");

            TreeNode nodoSeleccionado = tvwRolesPermisosUsuario.SelectedNode;

            // Validar que el nodo sea un rol
            if (!(nodoSeleccionado.Tag is  BERolArq))
                throw new InvalidOperationException("El nodo seleccionado no corresponde a un rol.");


            // Validar que sea un rol asignado directamente al usuario
            if (nodoSeleccionado.Parent == null || !(nodoSeleccionado.Parent.Tag is BEUsuario))
                throw new InvalidOperationException("Solo puede desasignar roles directamente asociados al usuario.");

            BERolArq oRolSeleccionado = (BERolArq)nodoSeleccionado.Tag;

            return oRolSeleccionado;
        }

        private BEPermiso SeleccionarPermisoDirectoUsuario() //ya tiene las validaciones 
        {
            // Verificar que haya algo seleccionado
            if (tvwRolesPermisosUsuario.SelectedNode == null)
                throw new InvalidOperationException("Debe seleccionar un permiso del usuario.");

            TreeNode nodoSeleccionado = tvwRolesPermisosUsuario.SelectedNode;

            // Validar que el nodo sea un permiso
            if (!(nodoSeleccionado.Tag is  BEPermiso))
                throw new InvalidOperationException("El nodo seleccionado no corresponde a un permiso.");


            // Validar que sea un permiso asignado directamente al usuario
            if (nodoSeleccionado.Parent == null || !(nodoSeleccionado.Parent.Tag is BEUsuario))
                throw new InvalidOperationException("Solo puede desasignar permisos directamente asociados al usuario.");

            BEPermiso oPermisoSeleccionado = (BEPermiso)nodoSeleccionado.Tag;

            return oPermisoSeleccionado;
        }

        private BEPermiso SeleccionarPermisoDirectoRol()
        {
            // Verificar selección
            if (tvwRolesPermisosRol.SelectedNode == null)
                throw new InvalidOperationException("Debe seleccionar un permiso del rol.");

            TreeNode nodoSeleccionado = tvwRolesPermisosRol.SelectedNode;

            // Verificar que sea un permiso
            if (!(nodoSeleccionado.Tag is BEPermiso))
                throw new InvalidOperationException("El nodo seleccionado no corresponde a un permiso.");

            BEPermiso permisoSeleccionado = (BEPermiso)nodoSeleccionado.Tag;


            // Validar que el padre sea un rol
            if (!(nodoSeleccionado.Parent.Tag is BERolArq rolPadre))
                throw new InvalidOperationException("El permiso no pertenece a un rol válido.");

            // Validar que el rol padre sea el rol raíz del treeview (rol principal)
            TreeNode nodoRaiz = tvwRolesPermisosRol.Nodes.Count > 0 ? tvwRolesPermisosRol.Nodes[0] : null;

            if (nodoRaiz == null || !ReferenceEquals(nodoSeleccionado.Parent, nodoRaiz))
                throw new InvalidOperationException("Solo puede desasignar permisos directamente asociados al rol principal.");

            return permisoSeleccionado;
        }

        private BERolArq SeleccionarRolDirectoRol()
        {
            // Verificar selección
            if (tvwRolesPermisosRol.SelectedNode == null)
                throw new InvalidOperationException("Debe seleccionar un rol.");

            TreeNode nodoSeleccionado = tvwRolesPermisosRol.SelectedNode;

            // Verificar que sea un rol
            if (!(nodoSeleccionado.Tag is BERolArq))
                throw new InvalidOperationException("El nodo seleccionado no corresponde a un rol.");

            BERolArq rolSeleccionado = (BERolArq)nodoSeleccionado.Tag;

            // Evitar seleccionar el rol principal (raíz)
            if (nodoSeleccionado.Parent == null)
                throw new InvalidOperationException("No puede seleccionar el rol principal.");

            // Verificar que el padre sea un rol
            if (!(nodoSeleccionado.Parent.Tag is BERolArq))
                throw new InvalidOperationException("El rol seleccionado no pertenece a un rol válido.");

            // Verificar que el rol padre sea el rol raíz del treeview
            TreeNode nodoRaiz = tvwRolesPermisosRol.Nodes.Count > 0 ? tvwRolesPermisosRol.Nodes[0] : null;

            if (nodoRaiz == null || !ReferenceEquals(nodoSeleccionado.Parent, nodoRaiz))
                throw new InvalidOperationException("Solo puede desasignar roles directamente asociados al rol principal.");

            return rolSeleccionado;
        }

        #endregion
        #region Eventos
        private void frmModuloPermisos_Load(object sender, EventArgs e)
        {
            try
            {
                CargarLtbUsuarios();
                CargarLtbRoles();
                CargarLtbPermisos();
                cbxRoles.DataSource = gestorRoles.ListarRoles();
                cbxRoles.Text=null;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void ltbListaRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ltbListaRoles.DataSource != null)
                {
                    CargarTvwRolesPermisosRol(SeleccionarRol());
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void ltbListaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ltbListaUsuarios.DataSource != null)
                {
                    CargarTvwRolesPermisosUsuario(SeleccionarUsuario());
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnAsignarRolUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionUsuario();
                oUsuario=SeleccionarUsuario();

                VerificarSeleccionRol();
                oRol=SeleccionarRol();

                gestorUsuarios.AsignarUsuarioRol(oUsuario, oRol);

                CargarLtbUsuarios();
                CargarTvwRolesPermisosUsuario(SeleccionarUsuario());
                MessageBox.Show("Para que los cambios sean visibles, debe reabrir la sesión", "Notificación de cierre de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnAsignarPermisoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionUsuario();
                oUsuario=SeleccionarUsuario();

                VerificarSeleccionPermiso();
                oPermiso=SeleccionarPermiso();

                gestorUsuarios.AsignarUsuarioPermiso(oUsuario, oPermiso);

                CargarLtbUsuarios();
                CargarTvwRolesPermisosUsuario(SeleccionarUsuario());
                MessageBox.Show("Para que los cambios sean visibles, debe reabrir la sesión", "Notificación de cierre de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnAsignarPermisoRol_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionRol();
                oRol=SeleccionarRol();

                VerificarSeleccionPermiso();
                oPermiso=SeleccionarPermiso();

                gestorRoles.AsignarRolPermiso(oRol, oPermiso);

                CargarLtbRoles();
                CargarLtbUsuarios();
                CargarTvwRolesPermisosUsuario(SeleccionarUsuario());
                CargarTvwRolesPermisosRol(SeleccionarRol());
                MessageBox.Show("Para que los cambios sean visibles, debe reabrir la sesión", "Notificación de cierre de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnAsignarRolRol_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionRol();
                oRol=SeleccionarRol();

                UIHelper.ValidarRol(cbxRoles.Text);
                BERolArq oRolAux = (BERolArq)cbxRoles.SelectedItem;

                gestorRoles.AsignarRolRol(oRol, oRolAux);

                CargarLtbRoles();
                CargarLtbUsuarios();
                CargarTvwRolesPermisosUsuario(SeleccionarUsuario());
                CargarTvwRolesPermisosRol(SeleccionarRol());
                MessageBox.Show("Para que los cambios sean visibles, debe reabrir la sesión", "Notificación de cierre de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnDesasignarRolUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionUsuario();
                oUsuario=SeleccionarUsuario();

                oRol=SeleccionarRolDirectoUsuario();

                gestorUsuarios.DesasignarUsuarioRol(oUsuario, oRol);

                CargarLtbUsuarios();
                CargarTvwRolesPermisosUsuario(SeleccionarUsuario());
                MessageBox.Show("Para que los cambios sean visibles, debe reabrir la sesión", "Notificación de cierre de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnDesasignarPermisoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionUsuario();
                oUsuario=SeleccionarUsuario();

                oPermiso=SeleccionarPermisoDirectoUsuario();

                gestorUsuarios.DesasignarUsuarioPermiso(oUsuario, oPermiso);

                CargarLtbUsuarios();
                CargarTvwRolesPermisosUsuario(SeleccionarUsuario());
                MessageBox.Show("Para que los cambios sean visibles, debe reabrir la sesión", "Notificación de cierre de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnDesasignarPermisoRol_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionRol();
                oRol=SeleccionarRol();

                oPermiso=SeleccionarPermisoDirectoRol();

                gestorRoles.DesasignarRolPermiso(oRol, oPermiso);

                CargarLtbRoles();
                CargarLtbUsuarios();
                CargarTvwRolesPermisosRol(SeleccionarRol());
                CargarTvwRolesPermisosUsuario(SeleccionarUsuario());
                MessageBox.Show("Para que los cambios sean visibles, debe reabrir la sesión", "Notificación de cierre de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnDesasignarRolRol_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionRol();
                oRol=SeleccionarRol();

                BERolArq oRolAux = SeleccionarRolDirectoRol();

                gestorRoles.DesasignarRolRol(oRol, oRolAux);

                CargarLtbRoles();
                CargarLtbUsuarios();
                CargarTvwRolesPermisosRol(SeleccionarRol());
                CargarTvwRolesPermisosUsuario(SeleccionarUsuario());
                MessageBox.Show("Para que los cambios sean visibles, debe reabrir la sesión", "Notificación de cierre de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnAgregarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                frmAbmPermisos frm = new frmAbmPermisos();
                frm.ShowDialog();
                CargarLtbPermisos();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnEliminarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionPermiso();
                oPermiso = SeleccionarPermiso();

                DialogResult confirmacion = MessageBox.Show($"Esta seguro de eliminar el permiso {oPermiso} ?", "Confirmar baja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    gestorPermisos.VerificarPresenciaUsuario(oPermiso);
                    gestorPermisos.VerificarPresenciaRol(oPermiso);

                    gestorPermisos.EliminarPermiso(oPermiso);
                    CargarLtbPermisos();
                    MessageBox.Show($"El permiso ha sido eliminado de forma exitosa", "Baja exitosa",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionRol();
                oRol= SeleccionarRol();

                DialogResult confirmacion = MessageBox.Show($"Esta seguro de eliminar el rol {oRol} ?", "Confirmar baja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    gestorRoles.VerificarPresenciaUsuario(oRol);
                    gestorRoles.VerificarPresenciaRol(oRol);

                    gestorRoles.EliminarRolArq(oRol);
                    CargarLtbRoles();
                    CargarLtbUsuarios();
                    tvwRolesPermisosRol.Nodes.Clear();
                    tvwRolesPermisosUsuario.Nodes.Clear();
                    cbxRoles.DataSource = gestorRoles.ListarRoles();
                    cbxRoles.Text=null;
                    MessageBox.Show($"El rol ha sido eliminado de forma exitosa", "Baja exitosa",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnModificarRol_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionRol();
                oRol = SeleccionarRol();
                frmAbmRolesArq frm = new frmAbmRolesArq(oRol);
                frm.Modificar = true;
                frm.ShowDialog();

                CargarLtbRoles();
                CargarLtbUsuarios();
                CargarTvwRolesPermisosRol(SeleccionarRol());
                cbxRoles.DataSource = gestorRoles.ListarRoles();
                cbxRoles.Text = null;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }


        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            try
            {
                frmAbmRolesArq frm = new frmAbmRolesArq();
                frm.ShowDialog();

                CargarLtbRoles();
                CargarLtbUsuarios();
                cbxRoles.DataSource = gestorRoles.ListarRoles();
                cbxRoles.Text = null;
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
