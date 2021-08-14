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
        private controladorEquipo padre;
        /// <summary>
        /// Metodo en el cual se configura lo que es el form dependiendo de lo que se selecciono en el formEquipo
        /// en el cual llama 
        /// </summary>
        public controladorEquipoEventos(formEquipoEventos Vista, controladorEquipo Padre, string tipo)
        {
            vista = Vista;
            padre = Padre;
            // Llenar combobox de deportes
            llenarCboDeporte();
            vista.cboDeporte.SelectedIndex = -1;
            vista.lblEquipoEvento.Text = tipo;
            if (tipo == "MODIFICAR EQUIPO")
            {
                vista.btnModificarEquipo.Visible = true;
                vista.btnAgregarEquipo.Visible = false;
                vista.btnModificarEquipo.Click += new EventHandler(clickModificarEquipo);
                modelo = padre.modeloFila;
                vista.txtNombre.Text = modelo.nombre;
            }
            else if (tipo == "AGREGAR EQUIPO")
            {
                vista.btnAgregarEquipo.Visible = true;
                vista.btnModificarEquipo.Visible = false;
                vista.btnAgregarEquipo.Click += new EventHandler(clickAgregarEquipo);
            }
            vista.btnSalir.Click += new EventHandler(clickSalir);
        }

        private void clickModificarEquipo(object sender, EventArgs e)
        {
            llenarModeloConOpcionesSeleccionadas();
            daoEquipo.modificarEquipo(modelo);
            padre.actualizarTablaJugadores();
            cerrarForm(vista);
        }

        private void clickAgregarEquipo(object sender, EventArgs e)
        {
            llenarModeloConOpcionesSeleccionadas();
            daoEquipo.agregarEquipo(modelo);
            padre.actualizarTablaJugadores();
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
            modelo.pkId = modelo.pkId;
            modelo.nombre = vista.txtNombre.Text;
            modelo.fkIdDeporte = stringAInt(vista.cboDeporte.SelectedValue.ToString());
        }

        private void clickSalir(object sender, EventArgs e)
        {
            cerrarForm(vista);
        }
    }
}