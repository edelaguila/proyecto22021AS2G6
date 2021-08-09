using Modelo.DAO;
using Modelo.DTO;
using System;
using System.Windows.Forms;
using Vista;
using static Vista.utilidadForms;

namespace Controlador
{
    class controladorEmpleado
    {
        private int id;
        private string nombre;
        private dtoEmpleado modeloFila = new dtoEmpleado();
        private formEmpleado vista;

        public controladorEmpleado()
        {
        }

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

        private void clickActualizarEmpleado(object sender, EventArgs e)
        {
            actualizarTablaEmpleado();
        }

        private void clickEliminarEmpleado(object sender, EventArgs e)
        {
            int id = stringAInt(vista.tablaEmpleado.SelectedRows[0].Cells[0].Value.ToString());
            daoEmpleado controlador = new daoEmpleado();
            dtoEmpleado modelo = new dtoEmpleado();
            modelo.pkId = id;
            controlador.eliminarEmpleado(modelo);
            actualizarTablaEmpleado();
        }

        private void cargarForm(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vwEmpleado.vwempleado' Puede moverla o quitarla según sea necesario.
            vista.vwempleadoTableAdapter.Fill(vista.vwEmpleado.vwempleado);

            vista.cboBuscar.SelectedIndex = 0;
        }

        private void opcionSeleccionadaBuscarEmpleado(object sender, EventArgs e)
        {
            vista.txtFiltrar.Text = "";
        }

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

        private void clickModificarEmpleado(object sender, EventArgs e)
        {
            daoEmpleado modeloModificar = new daoEmpleado();
            modeloFila.nombre = vista.txtNombre.Text;
            modeloFila.fkIdPuestoEmpleado = stringAInt(vista.cboPuesto.SelectedValue.ToString());
            modeloModificar.modificarEmpleado(modeloFila);
            actualizarTablaEmpleado();
        }

        private void clickAgregarEmpleado(object sender, EventArgs e)
        {
            daoEmpleado modeloAgregar = new daoEmpleado();
            dtoEmpleado modelo = new dtoEmpleado();
            modelo.nombre = vista.txtNombre.Text;
            modelo.fkIdPuestoEmpleado = stringAInt(vista.cboPuesto.SelectedValue.ToString());
            modeloAgregar.agregarEmpleado(modelo);
            actualizarTablaEmpleado();
        }

        private void clickCeldaDeLaTabla(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            vista.txtNombre.Text = nombre;
        }

        public void actualizarTablaEmpleado()
        {
            vista.vwempleadoTableAdapter.Fill(vista.vwEmpleado.vwempleado);
        }

        private void llenarModeloConFilaSeleccionada()
        {
            id = stringAInt(vista.tablaEmpleado.SelectedRows[0].Cells[0].Value.ToString());
            nombre = vista.tablaEmpleado.SelectedRows[0].Cells[1].Value.ToString();
            modeloFila.pkId = id;
        }
    }
}