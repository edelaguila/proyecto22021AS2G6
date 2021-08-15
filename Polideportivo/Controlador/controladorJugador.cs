using Vista;
using System;
using static Vista.utilidadForms;
using System.Windows.Forms;
using Modelo.DTO;
using Modelo.DAO;

namespace Controlador
{
    /// <summary>
    /// Clase que gestiona la tabla de jugadores de la base de datos
    /// </summary>
    public class controladorJugador
    {
        private formJugador vista;
        private int id;
        private string nombre;
        private int anotaciones;
        private int fkIdEquipo;
        private int fkIdRol;
        private int fkIdDeporte;

        private dtoJugador modeloFila = new dtoJugador();

        public controladorJugador()
        {
        }
        /// <summary>
        /// Método que sirve para cargar los eventos que van dentro de cada elemento en el formJugador
        /// </summary>
        /// <param name="Vista"></param>
        public controladorJugador(formJugador Vista)
        {
            vista = Vista;
            // Creación de eventos
            vista.Load += new EventHandler(cargarForm);
            vista.tablaJugadores.CellClick += new DataGridViewCellEventHandler(clickCeldaDeLaTabla);
            vista.btnActualizarJugador.Click += new EventHandler(clickActualizarJugador);
            vista.btnAgregarJugador.Click += new EventHandler(clickAgregarJugador);
            vista.btnModificarJugador.Click += new EventHandler(clickModificarJugador);
            vista.btnEliminarJugador.Click += new EventHandler(clickEliminarJugador);
            vista.txtFiltrar.TextChanged += new EventHandler(cambioEnTextoFiltrarJugador);
            vista.cboBuscar.SelectedIndexChanged += new EventHandler(opcionSeleccionadaBuscarJugador);
        }
        /// <summary>
        /// Método que sirve para cargar en las tablas las vistas creadas en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargarForm(object sender, EventArgs e)
        {
            vista.vwjugadorTableAdapter.Fill(vista.vwJugador.vwjugador);
            // Se asigna la primera opción posible en la combobox de filtración
            vista.cboBuscar.SelectedIndex = 0;
            // Se asigna la primera fila posible de la tabla y se llena el modelo
            vista.tablaJugadores.CurrentCell = vista.tablaJugadores.Rows[0].Cells[1];
            llenarModeloConFilaSeleccionada();
        }
        /// <summary>
        /// Método que sirve para llenar los modelos creados con los datos que estan seleccionados en la tabla 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickCeldaDeLaTabla(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
        }
        /// <summary>
        /// Método que manda a llamar la función de actualizarTablaJugadores para actualizar la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickActualizarJugador(object sender, EventArgs e)
        {
            actualizarTablaJugadores();
        }
        /// <summary>
        /// Método que manda a llamar el formJugadorEventos para poder agregar nuevos jugadores a la tabla 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickAgregarJugador(object sender, EventArgs e)
        {
            abrirForm(new formJugadorEventos(this));
        }
        /// <summary>
        /// Método que manda a llamar el formJugadorEventos para poder modificar jugadores de la tabla 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickModificarJugador(object sender, EventArgs e)
        {
            abrirForm(new formJugadorEventos(modeloFila, this));
        }
        /// <summary>
        /// Método para buscar dentro de la tabla el dato ingresado en el textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opcionSeleccionadaBuscarJugador(object sender, EventArgs e)
        {
            vista.txtFiltrar.Text = "";
        }
        /// <summary>
        /// Método que sirve para eliminar la opción seleccionada de la tabla 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickEliminarJugador(object sender, EventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            daoJugador daoJugador = new daoJugador();
            daoJugador.eliminarJugador(modeloFila);
            actualizarTablaJugadores();
        }
        /// <summary>
        /// Método que manda a llamar la función de filtrarTabla para filtrar los datos de la tabla 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cambioEnTextoFiltrarJugador(object sender, EventArgs e)
        {
            filtrarTabla();
        }
        /// <summary>
        /// Método para actualizar los datos de la tablaJugadores
        /// </summary>
        public void actualizarTablaJugadores()
        {
            vista.vwjugadorTableAdapter.Fill(vista.vwJugador.vwjugador);
        }
        /// <summary>
        /// Metodo que sirve para llenar la tablaJugadores con los datos que tenemos dentro del dtoJugadores
        /// </summary>
        public void llenarModeloConFilaSeleccionada()
        {
            id = stringAInt(vista.tablaJugadores.SelectedRows[0].Cells[0].Value.ToString());
            nombre = vista.tablaJugadores.SelectedRows[0].Cells[1].Value.ToString();
            anotaciones = stringAInt(vista.tablaJugadores.SelectedRows[0].Cells[2].Value.ToString());
            fkIdEquipo = stringAInt(vista.tablaJugadores.SelectedRows[0].Cells[3].Value.ToString());
            fkIdRol = stringAInt(vista.tablaJugadores.SelectedRows[0].Cells[5].Value.ToString());
            fkIdDeporte = stringAInt(vista.tablaJugadores.SelectedRows[0].Cells[7].Value.ToString());
            modeloFila.pkId = id;
            modeloFila.nombre = nombre;
            modeloFila.anotaciones = anotaciones;
            modeloFila.fkIdEquipo = fkIdEquipo;
            modeloFila.fkIdRol = fkIdRol;
            modeloFila.fkIdDeporte = fkIdDeporte;
        }
        /// <summary>
        /// Método que sirve para filtrar los datos dentro de la tablaJugadores
        /// </summary>
        private void filtrarTabla()
        {
            if (string.IsNullOrEmpty(vista.txtFiltrar.Text))
            {
                vista.vwjugadorBindingSource.Filter = string.Empty;
            }
            else
            {
                vista.vwjugadorBindingSource.Filter = string.Format("{0}='{1}'", vista.cboBuscar.Text, vista.txtFiltrar.Text);
            }
        }
    }
}