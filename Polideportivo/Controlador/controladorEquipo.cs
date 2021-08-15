using Modelo.DAO;
using Modelo.DTO;
using System;
using System.Windows.Forms;
using Vista;
using static Vista.utilidadForms;

namespace Controlador
{
    /// <summary>
    /// Clase que gestiona la tabla de equipos de la base de datos
    /// </summary>
    public class controladorEquipo
    {
        private formEquipo vista;
        private daoEquipo daoEquipo = new daoEquipo();
        public dtoEquipo modeloFila = new dtoEquipo();
        public controladorEquipo()
        {
        }
        /// <summary>
        /// Método que sirve para cargar los eventos que van dentro de cada elemento en el formEquipo
        /// </summary>
        /// <param name="Vista"></param>
        public controladorEquipo(formEquipo Vista)
        {
            vista = Vista;
            // Creación de eventos
            vista.Load += new EventHandler(cargarForm);
            vista.tablaEquipo.CellClick += new DataGridViewCellEventHandler(clickCeldaDeLaTabla);
            vista.btnActualizarEquipo.Click += new EventHandler(clickActualizarEquipo);
            vista.btnAgregarEquipo.Click += new EventHandler(clickAgregarEquipo);
            vista.btnModificarEquipo.Click += new EventHandler(clickModificarEquipo);
            vista.btnEliminarEquipo.Click += new EventHandler(clickEliminarEquipo);
            vista.txtFiltrar.TextChanged += new EventHandler(cambioEnTextoFiltrarEquipo);
            vista.cboBuscar.SelectedIndexChanged += new EventHandler(opcionSeleccionadaBuscarEquipo);
        }
        /// <summary>
        /// Método que manda a llamar el método actualizarTablaJugadores para actualizar los datos dentro de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickActualizarEquipo(object sender, EventArgs e)
        {
            actualizarTablaJugadores();
        }
        /// <summary>
        /// Método que manda a llamar la función filtrarTabla para filtrar los datos dentro de la tabla 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cambioEnTextoFiltrarEquipo(object sender, EventArgs e)
        {
            filtrarTabla();
        }
        /// <summary>
        /// Filtra la tablaEquipo con lo que el usuario ingrese en el textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opcionSeleccionadaBuscarEquipo(object sender, EventArgs e)
        {
            vista.txtFiltrar.Text = "";
        }
        /// <summary>
        /// Manda a llamar al daoEquipo al metodo eliminarEqipo que sirve para eliminar equipos de la tablaEquipos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickEliminarEquipo(object sender, EventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            daoEquipo.eliminarEquipo(modeloFila);
            actualizarTablaJugadores();
        }
        /// <summary>
        /// Método que abre el formulario forEquipoEventos para modificar equipos de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickModificarEquipo(object sender, EventArgs e)
        {
            abrirForm(new formEquipoEventos(this, "MODIFICAR JUGADOR"));
        }
        /// <summary>
        /// Método que abre el formulario forEquipoEventos para agregar nuevos equipos a la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickAgregarEquipo(object sender, EventArgs e)
        {
            abrirForm(new formEquipoEventos(this, "AGREGAR JUGADOR"));
        }
        /// <summary>
        /// Método que manda a llamar la función de llenarModeloConFilaSeleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickCeldaDeLaTabla(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
        }
        /// <summary>
        /// Método que manda a llamar la función actualizarTablaJugadores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargarForm(object sender, EventArgs e)
        {
            actualizarTablaJugadores();
        }
        /// <summary>
        /// Método que filtra la tablaEquipo con lo ingresado en el txtFiltrar 
        /// </summary>
        private void filtrarTabla()
        {
            if (string.IsNullOrEmpty(vista.txtFiltrar.Text))
            {
                vista.vwequipoBindingSource.Filter = string.Empty;
            }
            else
            {
                vista.vwequipoBindingSource.Filter = string.Format("{0}='{1}'", vista.cboBuscar.Text, vista.txtFiltrar.Text);
            }
        }
        /// <summary>
        /// Actualiza la tablaJugadores y la llena con las tablas
        /// </summary>
        public void actualizarTablaJugadores()
        {
            vista.vwequipoTableAdapter.Fill(vista.vwEquipo.vwequipo);
        }
        /// <summary>
        /// Método que llena la tabla de equipo con lo que se tiene ingresado en el dtoEquipo
        /// </summary>
        public void llenarModeloConFilaSeleccionada()
        {
            modeloFila.pkId = stringAInt(vista.tablaEquipo.SelectedRows[0].Cells[0].Value.ToString());
            modeloFila.nombre = vista.tablaEquipo.SelectedRows[0].Cells[1].Value.ToString();
            modeloFila.fkIdDeporte = stringAInt(vista.tablaEquipo.SelectedRows[0].Cells[2].Value.ToString());
        }
    }
}