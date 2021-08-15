using System;
using Vista;
using Modelo.DAO;
using Modelo.DTO;
using static Vista.utilidadForms;
using System.Windows.Forms;

namespace Controlador
{
    /// <summary>
    /// Clase que gestiona la tabla de roles de la base de datos
    /// </summary>
    class controladorRol
    {
        private int id;
        private string nombre;
        private int fkIdDeporte;

        private formRol vista;
        private dtoRol modeloFila = new dtoRol();

        public controladorRol()
        {
        }
        /// <summary>
        /// Método que sirve para cargar los eventos que van dentro de cada elemento en el formRol
        /// </summary>
        /// <param name="Vista"></param>
        public controladorRol(formRol Vista)
        {
            vista = Vista;
            // Llenar combobox de deportes
            daoDeporte daoDeporte = new daoDeporte();
            vista.cboDeporte.DataSource = daoDeporte.mostrarDeportes();
            vista.cboDeporte.DisplayMember = "nombre";
            vista.cboDeporte.ValueMember = "pkId";
            vista.cboDeporte.SelectedItem = vista.cboDeporte.Items[0];
            // Creación de eventos
            vista.Load += new EventHandler(cargarForm);
            vista.tablaRol.CellClick += new DataGridViewCellEventHandler(clickCeldaDeLaTabla);
            vista.btnActualizarRol.Click += new EventHandler(clickActualizarRol);
            vista.btnAgregarRol.Click += new EventHandler(clickAgregarRol);
            vista.btnModificarRol.Click += new EventHandler(clickModificarRol);
            vista.btnEliminarRol.Click += new EventHandler(clickEliminarRol);
            vista.txtFiltrarRol.TextChanged += new EventHandler(cambioEnTextoFiltrarRol);
            vista.cboBuscarRol.SelectedIndexChanged += new EventHandler(opcionSeleccionadaBuscarRol);
        }
        /// <summary>
        /// Método que sirve para cargar en las tablas las vistas creadas en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargarForm(object sender, EventArgs e)
        {
            vista.vwrolTableAdapter.Fill(vista.vwRol.vwrol);
        }
        /// <summary>
        /// Método que sirve para eliminar la opción seleccionada de la tabla 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickEliminarRol(object sender, EventArgs e)
        {
            int id = stringAInt(vista.tablaRol.SelectedRows[0].Cells[0].Value.ToString());
            daoRol controlador = new daoRol();
            dtoRol modelo = new dtoRol();
            modelo.pkId = id;
            controlador.eliminarRol(modelo);
            actualizarTablaRol();
        }
        /// <summary>
        /// Método que manda a llamar la función de actualizar tabla, para que se actualice la tablaRoles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickActualizarRol(object sender, EventArgs e)
        {
            actualizarTablaRol();
        }
        /// <summary>
        /// Método que sirve para buscar en la tabla roles lo ingresado en el txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opcionSeleccionadaBuscarRol(object sender, EventArgs e)
        {
            vista.txtFiltrarRol.Text = "";
        }
        /// <summary>
        /// Método que sirve para filtrar los datos que están dentro dentro de la tabla roles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cambioEnTextoFiltrarRol(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vista.txtFiltrarRol.Text))
            {
                vista.vwrolBindingSource.Filter = string.Empty;
            }
            else
            {
                vista.vwrolBindingSource.Filter = string.Format("{0}='{1}'", vista.cboBuscarRol.Text, vista.txtFiltrarRol.Text);
            }
        }
        /// <summary>
        /// Método que manda a llamar al daoRol que contiene el método modificarRol que sirve para modificar roles dentro de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickModificarRol(object sender, EventArgs e)
        {
            daoRol modeloModificar = new daoRol();
            dtoRol modelo = new dtoRol();
            modeloFila.nombre = vista.txtNombreRol.Text;
            modeloFila.fkIdDeporte = stringAInt(vista.cboDeporte.SelectedValue.ToString());
            modeloModificar.modificarRol(modeloFila);
            actualizarTablaRol();
        }
        /// <summary>
        /// Método que manda a llamar al daoRol al método agregarRol que sirve para agregar roles dentro de la tablaRoles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickAgregarRol(object sender, EventArgs e)
        {
            daoRol modeloAgregar = new daoRol();
            dtoRol modelo = new dtoRol();
            modelo.nombre = vista.txtNombreRol.Text;
            modelo.fkIdDeporte = stringAInt(vista.cboDeporte.SelectedValue.ToString());
            modeloAgregar.agregarRol(modelo);
            actualizarTablaRol();
        }
        /// <summary>
        /// Método que sirve para llenar el modelo con lo que se ingresó dentro del textox de rol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickCeldaDeLaTabla(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            vista.txtNombreRol.Text = nombre;
        }
        /// <summary>
        /// Método que sirve para actualizar la tablaRoles
        /// </summary>
        public void actualizarTablaRol()
        {
            vista.vwrolTableAdapter.Fill(vista.vwRol.vwrol);
        }
        /// <summary>
        /// Llena la tabla de deporte con lo que se tiene ingresado en el dtoRol
        /// </summary>
        private void llenarModeloConFilaSeleccionada()
        {
            id = stringAInt(vista.tablaRol.SelectedRows[0].Cells[0].Value.ToString());
            nombre = vista.tablaRol.SelectedRows[0].Cells[1].Value.ToString();
            modeloFila.pkId = id;
        }
    }
}