using Modelo.DTO;
using Modelo.DAO;
using Vista;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Vista.utilidadForms;

namespace Controlador
{
    /// <summary>
    /// Clase que gestiona la tabla de jugadores de la base de datos
    /// </summary>
    public class controladorDeporte
    {
        private int id;
        private string nombre;
        private dtoDeporte modeloFila = new dtoDeporte();
        private formDeporte vista;
        public controladorDeporte()
        {
        }
        /// <summary>
        /// Método que sirve para cargar los eventos que van dentro de cada elemento en el formDeporte
        /// </summary>
        /// <param name="Vista"></param>
        public controladorDeporte(formDeporte Vista)
        {
            vista = Vista;
            // Creación de eventos
            vista.Load += new EventHandler(cargarForm);
            vista.tablaDeportes.CellClick += new DataGridViewCellEventHandler(clickCeldaDeLaTabla);
            vista.btnActualizarDeporte.Click += new EventHandler(clickActualizarDeporte);
            vista.btnAgregarDeporte.Click += new EventHandler(clickAgregarDeporte);
            vista.btnModificarDeporte.Click += new EventHandler(clickModificarDeporte);
            vista.btnEliminarDeporte.Click += new EventHandler(clickEliminarDeporte);
            vista.txtFiltrar.TextChanged += new EventHandler(cambioEnTextoFiltrarDeporte);
            vista.cboBuscar.SelectedIndexChanged += new EventHandler(opcionSeleccionadaBuscarDeporte);
        }
        /// <summary>
        /// Método que manda a llamar al daoDeporte al método agregarDeporte que sirve para agregar deportes dentro de la tablaDeportes
        /// </summary>
        private void clickAgregarDeporte(object sender, EventArgs e)
        {
            daoDeporte daoDeporte = new daoDeporte();
            dtoDeporte dtoDeporte = new dtoDeporte();
            dtoDeporte.nombre = vista.txtNombreDeporte.Text;
            daoDeporte.agregarDeporte(dtoDeporte);
            actualizarTablaDeporte();
        }
        /// <summary>
        /// Método que manda a llamar al daoDeporte que contiene el método modificarDeporte que sirve para modificar deportes dentro de la tablaDeportes
        /// </summary>
        private void clickModificarDeporte(object sender, EventArgs e)
        {
            daoDeporte daoDeporte = new daoDeporte();
            modeloFila.nombre = vista.txtNombreDeporte.Text;
            daoDeporte.modificarDeporte(modeloFila);
            actualizarTablaDeporte();
        }
        /// <summary>
        /// Método que sirve para filtrar los datos que están dentro dentro de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cambioEnTextoFiltrarDeporte(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vista.txtFiltrar.Text))
            {
                vista.vwDeporteBindingSource.Filter = string.Empty;
            }
            else
            {
                vista.vwDeporteBindingSource.Filter = string.Format("{0}='{1}'", vista.cboBuscar.Text, vista.txtFiltrar.Text);
            }
        }
        /// <summary>
        /// Método que manda a llamar la funcion actualizarTablaDeportes para poder actualizar los datos dentro de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickActualizarDeporte(object sender, EventArgs e)
        {
            actualizarTablaDeporte();
        }
        /// <summary>
        ///  Método que manda a llamar al daoDeporte al metodo eliminarDeporte que sirve para eliminar deportes de la tablaDeportes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickEliminarDeporte(object sender, EventArgs e)
        {
            daoDeporte daoDeporte = new daoDeporte();
            dtoDeporte dtoDeporte = new dtoDeporte();
            int id = stringAInt(vista.tablaDeportes.SelectedRows[0].Cells[0].Value.ToString());
            dtoDeporte.pkId = id;
            daoDeporte.eliminarDeporte(dtoDeporte);
            actualizarTablaDeporte();
        }
        /// <summary>
        /// Método que llama al txtFiltar para preparar el dato que tiene ingresado dentro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opcionSeleccionadaBuscarDeporte(object sender, EventArgs e)
        {
            vista.txtFiltrar.Text = "";
        }
        /// <summary>
        /// Método que sirve para llenar el modelo con lo que se ingresó dentro del textox de deporte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickCeldaDeLaTabla(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            vista.txtNombreDeporte.Text = nombre;
        }
        /// <summary>
        /// Llena la tabla de deporte con lo que se tiene ingresado en el dtoDeporte
        /// </summary>
        private void llenarModeloConFilaSeleccionada()
        {
            id = stringAInt(vista.tablaDeportes.SelectedRows[0].Cells[0].Value.ToString());
            nombre = vista.tablaDeportes.SelectedRows[0].Cells[1].Value.ToString();
            modeloFila.pkId = id;
        }
        /// <summary>
        /// Método que sirve para cargar los datos dentro del form de deporte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargarForm(object sender, EventArgs e)
        {
            try
            {
                vista.deporteTableAdapter.Fill(vista.vwDeportes.deporte);
                vista.cboBuscar.SelectedIndex = 0;
            }
            catch (MySqlException error)
            {
                abrirForm(new formError(error));
            }
        }
        /// <summary>
        /// Método que sirve para actualizar la tablaDeportes
        /// </summary>
        public void actualizarTablaDeporte()
        {
            vista.deporteTableAdapter.Fill(vista.vwDeportes.deporte);
        }
    }
}