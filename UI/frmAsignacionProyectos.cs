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
    public partial class frmAsignacionProyectos : Form
    {

        BEColaborador oColaborador;
        BLLColaborador gestorColaboradores;
        BEProyecto oProyecto;
        BLLProyecto gestorProyectos;
        public frmAsignacionProyectos()
        {
            InitializeComponent();
            oColaborador=new BEColaborador();
            gestorColaboradores=new BLLColaborador();
            oProyecto=new BEProyecto();
            gestorProyectos=new BLLProyecto();
        }
        #region Métodos
        void CargarLtbColaboradores()
        {
            ltbColaboradoresDisponibles.DataSource=null;
            ltbColaboradoresDisponibles.DataSource=gestorColaboradores.ListarColaboradores();
        }

        void CargarLtbProyectos()
        {
            ltbProyectosDisponibles.DataSource=null;
            ltbProyectosDisponibles.DataSource=gestorProyectos.ListarProyectos();
        }

        void CargarLtbColaboradoresProyecto(BEProyecto oProyecto)
        {
            ltbColaboradoresProyecto.DataSource=null;
            ltbColaboradoresProyecto.DataSource=oProyecto.Colaboradores;
        }

        void CargarLtbProyectosColaborador(BEColaborador oColaborador)
        {
            ltbProyectosColaborador.DataSource=null;
            ltbProyectosColaborador.DataSource=gestorProyectos.ListarProyectosColaborador(oColaborador);
        }

        public BEProyecto SeleccionarProyectoDisponible()
        {
            oProyecto = (BEProyecto)ltbProyectosDisponibles.SelectedItem;
            return oProyecto;
        }

        public void VerificarSeleccionProyecto()
        {
            if (ltbProyectosDisponibles.SelectedItem == null)
            {
                throw new InvalidOperationException("Debe seleccionar un proyecto de la lista de proyectos disponibles");
            }
        }

        public BEColaborador SeleccionarColaboradorDisponible()
        {
            oColaborador = (BEColaborador)ltbColaboradoresDisponibles.SelectedItem;
            return oColaborador;
        }

        public void VerificarSeleccionColaboradorDisponible()
        {
            if (ltbColaboradoresDisponibles.SelectedItem == null)
            {
                throw new InvalidOperationException("Debe seleccionar un colaborador de la lista de colaboradores disponibles");
            }
        }

        public BEColaborador SeleccionarColaboradorProyecto()
        {
            oColaborador = (BEColaborador)ltbColaboradoresProyecto.SelectedItem;
            return oColaborador;
        }

        public void VerificarSeleccionColaboradorProyecto()
        {
            if (ltbColaboradoresProyecto.SelectedItem == null)
            {
                throw new InvalidOperationException("Debe seleccionar un colaborador de la lista de colaboradores del proyecto seleccionado");
            }
        }

        #endregion
        #region Eventos
        private void frmAsignacionProyectos_Load(object sender, EventArgs e)
        {
            try
            {
                CargarLtbColaboradores();
                CargarLtbProyectos();
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void ltbProyectosDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ltbProyectosDisponibles.DataSource != null)
                {
                    CargarLtbColaboradoresProyecto(SeleccionarProyectoDisponible());
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void ltbColaboradoresDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ltbColaboradoresDisponibles.DataSource != null)
                {
                    CargarLtbProyectosColaborador(SeleccionarColaboradorDisponible());
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionColaboradorDisponible();
                oColaborador = SeleccionarColaboradorDisponible();

                VerificarSeleccionProyecto();
                oProyecto = SeleccionarProyectoDisponible();

                DialogResult confirmacion = MessageBox.Show($"Esta seguro de querer asignar al colaborador {oColaborador} al proyecto {oProyecto}?", "Confirmar asignación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    bool respuesta = gestorProyectos.AsignarColaboradorProyecto(oProyecto, oColaborador);

                    if (respuesta)
                    {
                        CargarLtbProyectos();
                        MessageBox.Show($"El colaborador ha sido asignado de forma exitosa", "Asignación exitosa",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"El colaborador ya esta asignado a ese proyecto", "Asignación rechazada",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        private void btnDesasignar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarSeleccionProyecto();
                oProyecto = SeleccionarProyectoDisponible();

                VerificarSeleccionColaboradorProyecto();
                oColaborador = SeleccionarColaboradorProyecto();

                DialogResult confirmacion = MessageBox.Show($"Esta seguro de querer desasignar al colaborador {oColaborador} del proyecto {oProyecto}?", "Confirmar desasignación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    gestorProyectos.DesasignarColaboradorProyecto(oProyecto, oColaborador);
                    CargarLtbProyectos();
                    MessageBox.Show($"El colaborador ha sido desasignado de forma exitosa", "Desasignación exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { UIHelper.ManejarError(ex); }
        }

        #endregion
    }
}
