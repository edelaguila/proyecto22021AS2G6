using System;
using Vista;
using Modelo.DAO;
using Modelo.DTO;
using static Vista.utilidadForms;
using System.Windows.Forms;

namespace Controlador
{
    /// <summary>
    /// Clase que gestiona la tabla de entrenador de la base de datos
    /// </summary>
    class controladorEntrenador
    {
        private formEntrenador vista;
        private dtoEntrenador modeloFila = new dtoEntrenador();

        public controladorEntrenador()
        {
        }
        /// <summary>
        /// Método que sirve para cargar los eventos que van dentro de cada elemento en el formEntrenador
        /// </summary>
        /// <param name="Vista"></param>
        public controladorEntrenador(formEntrenador Vista)
        {
            vista = Vista;
            // Creación de eventos
            vista.Load += new EventHandler(cargarForm);
            vista.tablaEntrenador.CellClick += new DataGridViewCellEventHandler(clickCeldaDeLaTabla);
            vista.btnActualizarEntrenador.Click += new EventHandler(clickActualizarEntrenador);
            vista.btnAgregarEntrenador.Click += new EventHandler(clickAgregarEntrenador);
            vista.btnModificarEntrenador.Click += new EventHandler(clickModificarEntrenador);
            vista.btnEliminarEntrenador.Click += new EventHandler(clickEliminarEntrenador);
            vista.txtFiltrar.TextChanged += new EventHandler(cambioEnTextoFiltrarEntrenador);
            vista.cboBuscar.SelectedIndexChanged += new EventHandler(opcionSeleccionadaBuscarEntrenador);
            vista.cboDeporte.SelectedIndexChanged += new EventHandler(opcionSeleccionadaDeporte);
            // Llenar combobox de deportes
            daoDeporte daoDeporte = new daoDeporte();
            vista.cboDeporte.DataSource = daoDeporte.mostrarDeportes();
            vista.cboDeporte.DisplayMember = "nombre";
            vista.cboDeporte.ValueMember = "pkId";
            vista.cboDeporte.SelectedIndex = -1;
        }
        /// <summary>
        /// Método que manda a llamar al daoEntrenador que sirve para eliminar entrenadores de la tablaEntrenadores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickEliminarEntrenador(object sender, EventArgs e)
        {
            int id = stringAInt(vista.tablaEntrenador.SelectedRows[0].Cells[0].Value.ToString());
            daoEntrenador daoEntrenador = new daoEntrenador();
            dtoEntrenador modelo = new dtoEntrenador();
            modelo.pkId = id;
            daoEntrenador.eliminarEntrenador(modelo);
            actualizarTablaEntrenador();
        }
        /// <summary>
        /// Método que manda a llamar la función de actualizar tabla, para que se actualice la tablaEntrenador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickActualizarEntrenador(object sender, EventArgs e)
        {
            actualizarTablaEntrenador();
        }
        /// <summary>
        /// Método que sirve para filtrar la tabla con lo ingresado en el textbox de filtrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opcionSeleccionadaBuscarEntrenador(object sender, EventArgs e)
        {
            vista.txtFiltrar.Text = "";
        }
        /// <summary>
        /// Método que sirve para filtrar los datos que están dentro dentro de la tabla entrenadores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cambioEnTextoFiltrarEntrenador(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vista.txtFiltrar.Text))
            {
                vista.vwentrenadorBindingSource.Filter = string.Empty;
            }
            else
            {
                vista.vwentrenadorBindingSource.Filter = string.Format("{0}='{1}'", vista.cboBuscar.Text, vista.txtFiltrar.Text);
            }
        }
        /// <summary>
        /// Método que manda a llamar al daoEntrenador al método modificarEntrenador que sirve para modificar entrenadores dentro de la tablaEntrenadores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickModificarEntrenador(object sender, EventArgs e)
        {
            daoEntrenador daoEntrenador = new daoEntrenador();
            dtoEntrenador modelo = new dtoEntrenador();
            modelo.pkId = modeloFila.pkId;
            modelo.nombre = vista.txtNombre.Text;
            modelo.fkIdDeporte = stringAInt(vista.cboDeporte.SelectedValue.ToString());
            modelo.fkIdEquipo = stringAInt(vista.cboEquipo.SelectedValue.ToString());
            daoEntrenador.modificarEntrenador(modelo);
            actualizarTablaEntrenador();
        }
        /// <summary>
        /// Método que manda a llamar al daoEntrenador al método agregarEntrenador que sirve para agregar entrenadores dentro de la tablaEntrenadores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickAgregarEntrenador(object sender, EventArgs e)
        {
            daoEntrenador daoEntrenador = new daoEntrenador();
            dtoEntrenador modelo = new dtoEntrenador();
            modelo.nombre = vista.txtNombre.Text;
            modelo.fkIdDeporte = stringAInt(vista.cboDeporte.SelectedValue.ToString());
            modelo.fkIdEquipo = stringAInt(vista.cboEquipo.SelectedValue.ToString());
            daoEntrenador.agregarEntrenador(modelo);
            actualizarTablaEntrenador();
        }
        /// <summary>
        /// Método que sirve cuando se quiere modificar un dato de la tabla, envía los datos a los 
        /// textbox y los combos del elemento seleccionado en la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opcionSeleccionadaDeporte(object sender, EventArgs e)
        {
            if (vista.cboDeporte.SelectedIndex > -1)
            {
                // Llenar la combobox de equipo dependiendo del deporte elegido
                dtoEquipo dtoEquipo = new dtoEquipo();
                dtoEquipo.fkIdDeporte = stringAInt(vista.cboDeporte.SelectedValue.ToString());
                daoEquipo equipo = new daoEquipo();
                vista.cboEquipo.DataSource = equipo.mostrarEquipoPorDeporte(dtoEquipo);
                vista.cboEquipo.DisplayMember = "nombre";
                vista.cboEquipo.ValueMember = "pkId";
            }
            vista.txtFiltrar.Text = "";
        }
        /// <summary>
        /// Método que sirve para que se pueda seleccionar los datos que están dentro de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickCeldaDeLaTabla(object sender, DataGridViewCellEventArgs e)
        {
            int id = stringAInt(vista.tablaEntrenador.SelectedRows[0].Cells[0].Value.ToString());
            string nombre = vista.tablaEntrenador.SelectedRows[0].Cells[1].Value.ToString();
            vista.txtNombre.Text = nombre;
            modeloFila.pkId = id;
        }
        /// <summary>
        /// Método que sirve para cargar los datos que van dentro de la tabla de entrenador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargarForm(object sender, EventArgs e)
        {
            vista.vwentrenadorTableAdapter.Fill(vista.vwEntrenador.vwentrenador);
            vista.cboBuscar.SelectedIndex = 0;
        }
        /// <summary>
        /// Método que sirve para actualizar los datos que están dentro de la tablaEntrenador
        /// </summary>
        public void actualizarTablaEntrenador()
        {
            vista.vwentrenadorTableAdapter.Fill(vista.vwEntrenador.vwentrenador);
        }
    }
}