using Modelo.DAO;
using Modelo.DTO;
using System;
using System.Windows.Forms;
using Vista;
using static Vista.utilidadForms;

namespace Controlador
{
    /// <summary>
    /// Clase que gestiona la tabla de jugadores de la base de datos
    /// </summary>
    class controladorEmpleado
    {
        private int id;
        private string nombre;
        private dtoEmpleado modeloFila = new dtoEmpleado();
        private formEmpleado vista;

        public controladorEmpleado()
        {
        }
        /// <summary>
        /// Método que sirve para cargar los eventos que van dentro de cada elemento en el formEmpleado
        /// </summary>
        /// <param name="Vista"></param>
        public controladorEmpleado(formEmpleado Vista)
        {
            vista = Vista;
            // Creación de eventos
            vista.Load += new EventHandler(cargarForm);
            vista.tablaEmpleado.CellClick += new DataGridViewCellEventHandler(clickCeldaDeLaTabla);
            vista.btnActualizarEmpleado.Click += new EventHandler(clickActualizarEmpleado);
            vista.btnAgregarEmpleado.Click += new EventHandler(clickAgregarEmpleado);
            vista.btnModificarEmpleado.Click += new EventHandler(clickModificarEmpleado);
            vista.btnEliminarEmpleado.Click += new EventHandler(clickEliminarEmpleado);
            vista.txtFiltrar.TextChanged += new EventHandler(cambioEnTextoFiltrarEmpleado);
            vista.cboBuscar.SelectedIndexChanged += new EventHandler(opcionSeleccionadaBuscarEmpleado);
        }
        /// <summary>
        /// Método que manda a llamar la función de actualizar tabla, para que se actualice la tablaEmpleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickActualizarEmpleado(object sender, EventArgs e)
        {
            actualizarTablaEmpleado();
        }
        /// <summary>
        /// Método que sirve para eliminar empleados de la tablaEmpleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickEliminarEmpleado(object sender, EventArgs e)
        {
            int id = stringAInt(vista.tablaEmpleado.SelectedRows[0].Cells[0].Value.ToString());
            daoEmpleado controlador = new daoEmpleado();
            dtoEmpleado modelo = new dtoEmpleado();
            modelo.pkId = id;
            controlador.eliminarEmpleado(modelo);
            actualizarTablaEmpleado();
        }
        /// <summary>
        /// Método que sirve para cargar en la tablaEmpleados los datos que van dentro 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargarForm(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vwEmpleado.vwempleado' Puede moverla o quitarla según sea necesario.
            vista.vwempleadoTableAdapter.Fill(vista.vwEmpleado.vwempleado);

            vista.cboBuscar.SelectedIndex = 0;
        }
        /// <summary>
        /// Método que sirve para filtrar la tabla con lo ingresado en el textbox de filtrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opcionSeleccionadaBuscarEmpleado(object sender, EventArgs e)
        {
            vista.txtFiltrar.Text = "";
        }
        /// <summary>
        /// Método que sirve para filtrar los datos dentro de la tabla con lo ingresado en el txtFiltrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cambioEnTextoFiltrarEmpleado(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vista.txtFiltrar.Text))
            {
                vista.vwempleadoBindingSource.Filter = string.Empty;
            }
            else
            {
                vista.vwempleadoBindingSource.Filter = string.Format("{0}='{1}'", vista.cboBuscar.Text, vista.txtFiltrar.Text);
            }
        }
        /// <summary>
        /// Método que sirve para modificar empleados dentro de la tablaEmpleados, llamando al dtoEmpleado, el método modificarEmpleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickModificarEmpleado(object sender, EventArgs e)
        {
            daoEmpleado modeloModificar = new daoEmpleado();
            modeloFila.nombre = vista.txtNombre.Text;
            modeloFila.fkIdPuestoEmpleado = stringAInt(vista.cboPuesto.SelectedValue.ToString());
            modeloModificar.modificarEmpleado(modeloFila);
            actualizarTablaEmpleado();
        }
        /// <summary>
        /// Método que sirve para agregar empleados a la tablaEmpleados llamando al dtoEmpleado, el método de agregar empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickAgregarEmpleado(object sender, EventArgs e)
        {
            daoEmpleado modeloAgregar = new daoEmpleado();
            dtoEmpleado modelo = new dtoEmpleado();
            modelo.nombre = vista.txtNombre.Text;
            modelo.fkIdPuestoEmpleado = stringAInt(vista.cboPuesto.SelectedValue.ToString());
            modeloAgregar.agregarEmpleado(modelo);
            actualizarTablaEmpleado();
        }
        /// <summary>
        /// Método para llenar el modelo de empleado con el dato seleccionado dentro de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickCeldaDeLaTabla(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            vista.txtNombre.Text = nombre;
        }
        /// <summary>
        /// Método que actualiza los datos dentro de la tabla empleado
        /// </summary>
        public void actualizarTablaEmpleado()
        {
            vista.vwempleadoTableAdapter.Fill(vista.vwEmpleado.vwempleado);
        }
        /// <summary>
        /// Llena la tabla de empleado con lo que se tiene ingresado en el dtoDeporte
        /// </summary>
        private void llenarModeloConFilaSeleccionada()
        {
            id = stringAInt(vista.tablaEmpleado.SelectedRows[0].Cells[0].Value.ToString());
            nombre = vista.tablaEmpleado.SelectedRows[0].Cells[1].Value.ToString();
            modeloFila.pkId = id;
        }
    }
}