using System;
using Vista;
using Modelo.DAO;
using Modelo.DTO;
using static Vista.utilidadForms;
using System.Windows.Forms;

namespace Controlador
{
    class controladorEntrenador
    {
        private formEntrenador vista;
        private dtoEntrenador modeloFila = new dtoEntrenador();

        public controladorEntrenador()
        {
        }

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
        /// Manda a llamar al daoEntrenador que sirve para eliminar entrenadores de la tablaEntrenadores
        /// </summary>
        private void clickEliminarEntrenador(object sender, EventArgs e)
        {
            int id = stringAInt(vista.tablaEntrenador.SelectedRows[0].Cells[0].Value.ToString());
            daoEntrenador daoEntrenador = new daoEntrenador();
            dtoEntrenador modelo = new dtoEntrenador();
            modelo.pkId = id;
            daoEntrenador.eliminarEntrenador(modelo);
            actualizarTablaEntrenador();
        }

        private void clickActualizarEntrenador(object sender, EventArgs e)
        {
            actualizarTablaEntrenador();
        }

        private void opcionSeleccionadaBuscarEntrenador(object sender, EventArgs e)
        {
            vista.txtFiltrar.Text = "";
        }

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
        /// Manda a llamar al daoEntrenador al método modificarEntrenador que sirve para modificar entrenadores dentro de la tablaEntrenadores
        /// </summary>
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
        /// Manda a llamar al daoEntrenador al método agregarEntrenador que sirve para agregar entrenadores dentro de la tablaEntrenadores
        /// </summary>
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

        private void clickCeldaDeLaTabla(object sender, DataGridViewCellEventArgs e)
        {
            int id = stringAInt(vista.tablaEntrenador.SelectedRows[0].Cells[0].Value.ToString());
            string nombre = vista.tablaEntrenador.SelectedRows[0].Cells[1].Value.ToString();
            vista.txtNombre.Text = nombre;
            modeloFila.pkId = id;
        }

        private void cargarForm(object sender, EventArgs e)
        {
            vista.vwentrenadorTableAdapter.Fill(vista.vwEntrenador.vwentrenador);
            vista.cboBuscar.SelectedIndex = 0;
        }

        public void actualizarTablaEntrenador()
        {
            vista.vwentrenadorTableAdapter.Fill(vista.vwEntrenador.vwentrenador);
        }
    }
}