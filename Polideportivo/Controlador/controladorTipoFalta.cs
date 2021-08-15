using System;
using System.Windows.Forms;
using Vista;
using Modelo.DAO;
using static Vista.utilidadForms;
using Modelo.DTO;

namespace Controlador
{
    /// <summary>
    /// Clase que gestiona la tabla de tipo falta de la base de datos
    /// </summary>
    class controladorTipoFalta
    {
        private formTipoFalta vista;
        private int id;
        private string nombre;
        private dtoTipoFalta modeloFila = new dtoTipoFalta();

        public controladorTipoFalta()
        {
        }
        /// <summary>
        /// Método que sirve para cargar los eventos que van dentro de cada elemento en el formTipoFalta
        /// </summary>
        /// <param name="Vista"></param>
        public controladorTipoFalta(formTipoFalta Vista)
        {
            vista = Vista;
            // Creación de eventos
            vista.Load += new EventHandler(cargarForm);
            vista.tablaTipoFalta.CellClick += new DataGridViewCellEventHandler(clickCeldaDeLaTabla);
            vista.btnActualizarFalta.Click += new EventHandler(clickActualizarJugador);
            vista.btnAgregarFalta.Click += new EventHandler(clickAgregarJugador);
            vista.btnModificarFalta.Click += new EventHandler(clickModificarJugador);
            vista.btnEliminarFalta.Click += new EventHandler(clickEliminarJugador);
            vista.txtFiltrar.TextChanged += new EventHandler(cambioEnTextoFiltrarJugador);
            vista.cboBuscar.SelectedIndexChanged += new EventHandler(opcionSeleccionadaBuscarJugador);
            // Llenar combobox de deportes
            daoDeporte daoDeporte = new daoDeporte();
            vista.cboDeporte.DataSource = daoDeporte.mostrarDeportes();
            vista.cboDeporte.DisplayMember = "nombre";
            vista.cboDeporte.ValueMember = "pkId";
            vista.cboDeporte.SelectedIndex = -1;
        }
        /// <summary>
        /// Método que manda a llamar al daoTipoFalta al metodo eliminarTipoFalta que sirve para eliminar tipos de falta de la tablaTipoFalta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickEliminarJugador(object sender, EventArgs e)
        {
            int id = stringAInt(vista.tablaTipoFalta.SelectedRows[0].Cells[0].Value.ToString());
            daoTipoFalta controlador = new daoTipoFalta();
            dtoTipoFalta modelo = new dtoTipoFalta();
            modelo.pkId = id;
            controlador.eliminarTipoFalta(modelo);
            actualizarTablaTipoFalta();
        }
        /// <summary>
        /// Método que manda a llamar la funcion actualizarTablaTipoFalta para poder actualizar los datos dentro de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickActualizarJugador(object sender, EventArgs e)
        {
            actualizarTablaTipoFalta();
        }
        /// <summary>
        /// Método que llama al txtFiltar para preparar el dato que tiene ingresado dentro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opcionSeleccionadaBuscarJugador(object sender, EventArgs e)
        {
            vista.txtFiltrar.Text = "";
        }
        /// <summary>
        /// Método que sirve para filtrar los datos que están dentro dentro de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cambioEnTextoFiltrarJugador(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vista.txtFiltrar.Text))
            {
                vista.vwtipofaltaBindingSource.Filter = string.Empty;
            }
            else
            {
                vista.vwtipofaltaBindingSource.Filter = string.Format("{0}='{1}'", vista.cboBuscar.Text, vista.txtFiltrar.Text);
            }
        }
        /// <summary>
        /// Método que manda a llamar al daoTipoFalta que contiene el método modificarTipoFalta que sirve para modificar detipos de falta dentro de la tablaTipoFalta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickModificarJugador(object sender, EventArgs e)
        {
            daoTipoFalta modeloModificar = new daoTipoFalta();
            dtoTipoFalta modelo = new dtoTipoFalta();
            modeloFila.tipo = vista.txtNombre.Text;
            modeloFila.fkIdDeporte = stringAInt(vista.cboDeporte.SelectedValue.ToString());
            modeloModificar.modificarTipoFalta(modeloFila);
            actualizarTablaTipoFalta();
        }
        /// <summary>
        /// Método que manda a llamar al daoTipoFalta al método agregarTipoFalta que sirve para agregar tipos de falta dentro de la tablaTipoFalta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickAgregarJugador(object sender, EventArgs e)
        {
            daoTipoFalta modeloAgregar = new daoTipoFalta();
            dtoTipoFalta modelo = new dtoTipoFalta();
            modelo.tipo = vista.txtNombre.Text;
            modelo.fkIdDeporte = stringAInt(vista.cboDeporte.SelectedValue.ToString());
            modeloAgregar.agregarTipoFalta(modelo);
            actualizarTablaTipoFalta();
        }
        /// <summary>
        /// Método que sirve para llenar el modelo con lo que se ingresó dentro del textox de tipofalta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickCeldaDeLaTabla(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            vista.txtNombre.Text = nombre;
        }
        /// <summary>
        /// Método que sirve para cargar los datos dentro del form de tipo falta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargarForm(object sender, EventArgs e)
        {
            vista.vwtipofaltaTableAdapter.Fill(vista.vwTipoFalta.vwtipofalta);
            vista.cboBuscar.SelectedIndex = 0;
        }
        /// <summary>
        /// Método que sirve para actualizar la tablaTipoFalta
        /// </summary>
        public void actualizarTablaTipoFalta()
        {
            vista.vwtipofaltaTableAdapter.Fill(vista.vwTipoFalta.vwtipofalta);
        }
        /// <summary>
        /// Llena la tabla de deporte con lo que se tiene ingresado en el dtoTipoFalta
        /// </summary>
        private void llenarModeloConFilaSeleccionada()
        {
            id = stringAInt(vista.tablaTipoFalta.SelectedRows[0].Cells[0].Value.ToString());
            nombre = vista.tablaTipoFalta.SelectedRows[0].Cells[1].Value.ToString();
            modeloFila.pkId = id;
        }
    }
}