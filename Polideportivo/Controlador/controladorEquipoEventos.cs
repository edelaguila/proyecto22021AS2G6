using Modelo.DAO;
using Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista;
using static Vista.utilidadForms;

namespace Controlador
{
    class controladorEquipoEventos
    {
        private daoEquipo daoEquipo = new daoEquipo();
        private dtoEquipo modelo = new dtoEquipo();
        private formEquipoEventos vista;
        private dtoEquipo modeloOriginal = new dtoEquipo();
        private controladorEquipo formoriginal;
        //Modificar

        public controladorEquipoEventos(dtoEquipo modelo, formEquipoEventos Vista, controladorEquipo formOriginal)
        {
            vista = Vista;
            formoriginal = formOriginal;
            vista.btnModificarEquipo.Visible = true;
            vista.btnAgregarEquipo.Visible = false;
            vista.txtNombre.Text = modelo.nombre;
            // Llenar combobox de deportes
            vista.llenarCboDeporte();
            // Para obtener el Id original que se va a modificar
            modeloOriginal = modelo;
            // Modificar el texto del label
            vista.lblEquipoEvento.Text = "MODIFICAR JUGADOR";
            ////// Creación de eventos
            //vista.Load += new EventHandler(cargarForm);
            //vista.tablaEquipo.CellClick += new DataGridViewCellEventHandler(clickCeldaDeLaTabla);
            //vista.btnActualizarEquipo.Click += new EventHandler(clickActualizarEquipo);
            //vista.btnModificarEquipo.Click += new EventHandler(clickModificarEquipo);
            //vista.btnEliminarEquipo.Click += new EventHandler(clickEliminarEquipo);
            //vista.txtFiltrar.TextChanged += new EventHandler(cambioEnTextoFiltrarEquipo);
            //vista.cboBuscar.SelectedIndexChanged += new EventHandler(opcionSeleccionadaBuscarEquipo);
        }

        //agregar
        public controladorEquipoEventos(formEquipoEventos Vista, controladorEquipo formOriginal)
        {
            vista = Vista;
            formoriginal = formOriginal;
            vista.btnAgregarEquipo.Visible = true;
            vista.btnModificarEquipo.Visible = false;
            // Llenar combobox de deportes
            vista.llenarCboDeporte();
            vista.cboDeporte.SelectedIndex = -1;
            // Modificar el texto del título
            vista.lblEquipoEvento.Text = "AGREGAR JUGADOR";
            vista.btnAgregarEquipo.Click += new EventHandler(clickAgregarEquipo);
        }

        private void clickAgregarEquipo(object sender, EventArgs e)
        {
            llenarModeloConOpcionesSeleccionadas();
            daoEquipo.agregarEquipo(modelo);
            formoriginal.actualizarTablaJugadores();
            cerrarForm(vista);
        }

        public void llenarCboDeporte()
        {
            daoDeporte daoDeporte = new daoDeporte();
            vista.cboDeporte.DataSource = daoDeporte.mostrarDeportes();
            vista.cboDeporte.DisplayMember = "nombre";
            vista.cboDeporte.ValueMember = "pkId";
        }

        private void llenarModeloConOpcionesSeleccionadas()
        {
            modelo.pkId = modeloOriginal.pkId;
            modelo.nombre = vista.txtNombre.Text;
            modelo.fkIdDeporte = stringAInt(vista.cboDeporte.SelectedValue.ToString());
        }
    }
}