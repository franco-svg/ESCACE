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
    public partial class frmMenu : Form
    {
        BEUsuario oUsuario;
        BLLUsuario gestorUsuarios;
        BLLPermiso gestorPermisos;
        BLLRolArq gestorRoles;
        List<BEPermiso> listaPermisos;

        public frmMenu(BEUsuario oUsuario)
        {
            InitializeComponent();
            this.oUsuario=oUsuario;
            gestorUsuarios = new BLLUsuario();
            gestorRoles = new BLLRolArq();
            gestorPermisos = new BLLPermiso();
            listaPermisos = new List<BEPermiso>();
            OcultarTodosLosItemsDelMenu();
            MostrarItemsSegunPermisos(oUsuario);
        }

        #region Métodos
        public void OcultarTodosLosItemsDelMenu()
        {
            foreach (ToolStripMenuItem item in mstBarraPestanas.Items)
            {
                item.Visible = false;
                if (item.DropDownItems.Count > 0)
                    OcultarSubItems(item.DropDownItems);//oculto todos los subtimes del item iterado
            }
        }

        private void OcultarSubItems(ToolStripItemCollection items)
        {
            foreach (ToolStripMenuItem subItem in items)
            {
                subItem.Visible = false;
                if (subItem.DropDownItems.Count > 0)
                    OcultarSubItems(subItem.DropDownItems);//oculto recursivamente todos los subitems, del subitem iterado
            }
        }

        public void MostrarItemsSegunPermisos(BEUsuario usuario)
        {
            foreach (ToolStripMenuItem item in mstBarraPestanas.Items)
            {
                if (item.DropDownItems.Count > 0)
                    MostrarSubItemsSegunPermisos(item, usuario);//muestro los subitems, del item iterado

                //Muestro el item iterado
                if (usuario.Roles.Any(r => r.TienePermiso(item.Text)) ||//si dentro del arbol de los roles
                    usuario.PermisosDirectos.Any(p => p.TienePermiso(item.Text)))//si esta como permiso directo
                {
                    item.Visible = true;
                }
            }
        }

        private void MostrarSubItemsSegunPermisos(ToolStripMenuItem menuItem, BEUsuario usuario)
        {
         //   bool algunSubVisible = false;

            foreach (ToolStripMenuItem subItem in menuItem.DropDownItems)
            {
                if (subItem.DropDownItems.Count > 0)
                    MostrarSubItemsSegunPermisos(subItem, usuario);//muestro recursivamente todos los subitems, del subitem iterado

                if (usuario.Roles.Any(r => r.TienePermiso(subItem.Text)) ||//si dentro del arbol de los roles
                    usuario.PermisosDirectos.Any(p => p.TienePermiso(subItem.Text)))//si esta como permiso directo
                {
                    subItem.Visible = true;
                    //algunSubVisible = true;
                }
            }

          //  if (algunSubVisible)
            // menuItem.Visible = true;
            // si se descomenta, no habria necesidad de asignar permisos para los items, solo para los subitems.
        }
        #endregion
        #region Eventos
        private void registrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmModuloClientes frm = new frmModuloClientes();
                frm.ShowDialog();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }


        private void registrarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmModuloColaboradores frm = new frmModuloColaboradores();
                frm.ShowDialog();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void registrarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmModuloRoles frm = new frmModuloRoles();
                frm.ShowDialog();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void asignarPersonaAProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAsignacionProyectos frm = new frmAsignacionProyectos();
                frm.ShowDialog();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void registrarContratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmModuloContratos frm = new frmModuloContratos();
                frm.ShowDialog();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void registrarFichasDeProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmModuloFichasProyecto frm = new frmModuloFichasProyecto();
                frm.ShowDialog();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void registrarProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmModuloProyectos frm = new frmModuloProyectos();
                frm.ShowDialog();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void gestionarBacklogDeProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmModuloBacklog frm = new frmModuloBacklog();
                frm.ShowDialog();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void gestionarCronogramasDeProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmModuloCronograma frm = new frmModuloCronograma();
                frm.ShowDialog();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void reporteriaDeRecursosHumanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmReporteriaRRHH frm = new frmReporteriaRRHH();
                frm.ShowDialog();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void reporteriaDeAdministraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmReporteriaAdministracion frm = new frmReporteriaAdministracion();
                frm.ShowDialog();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void reporteríaDeProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmReporteriaPlaneacion frm = new frmReporteriaPlaneacion();
                frm.ShowDialog();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }


        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmModuloUsuarios frm = new frmModuloUsuarios(oUsuario);
                frm.ShowDialog();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            try
            {
                if (oUsuario!=null)
                {
                    lblUsuario.Text=oUsuario.Username;
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }

        }

        private void btnCancelar_Click(object sender, EventArgs e)//cerrar sesión
        {
            try
            {
                this.Hide();
                frmLogin frm = new frmLogin();
                frm.Show();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void rolesYPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmModuloPermisos frm = new frmModuloPermisos();
                frm.ShowDialog();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmModuloBackups frm = new frmModuloBackups(oUsuario);
                frm.ShowDialog();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }


        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmModuloRestores frm = new frmModuloRestores(oUsuario);
                frm.ShowDialog();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmModuloBitacora frm = new frmModuloBitacora();
                frm.ShowDialog();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }
        #endregion
    }
}
