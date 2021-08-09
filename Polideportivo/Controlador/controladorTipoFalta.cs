using System;
using System.Windows.Forms;
using Vista;
using Modelo.DAO;
using static Vista.utilidadForms;
using Modelo.DTO;

namespace Controlador
{
    class controladorTipoFalta
    {
        private formTipoFalta vista;
        private int id;
        private string nombre;
        private dtoTipoFalta modeloFila = new dtoTipoFalta();

        public controladorTipoFalta()
        {
        }

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

        private void clickEliminarJugador(object sender, EventArgs e)
        {
            int id = stringAInt(vista.tablaTipoFalta.SelectedRows[0].Cells[0].Value.ToString());
            daoTipoFalta controlador = new daoTipoFalta();
            dtoTipoFalta modelo = new dtoTipoFalta();
            modelo.pkId = id;
            controlador.eliminarTipoFalta(modelo);
            actualizarTablaTipoFalta();
        }

        private void clickActualizarJugador(object sender, EventArgs e)
        {
            actualizarTablaTipoFalta();
        }

        private void opcionSeleccionadaBuscarJugador(object sender, EventArgs e)
        {
            vista.txtFiltrar.Text = "";
        }

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

        private void clickModificarJugador(object sender, EventArgs e)
        {
            daoTipoFalta modeloModificar = new daoTipoFalta();
            dtoTipoFalta modelo = new dtoTipoFalta();
            modeloFila.tipo = vista.txtNombre.Text;
            modeloFila.fkIdDeporte = stringAInt(vista.cboDeporte.SelectedValue.ToString());
            modeloModificar.modificarTipoFalta(modeloFila);
            actualizarTablaTipoFalta();
        }

        private void clickAgregarJugador(object sender, EventArgs e)
        {
            daoTipoFalta modeloAgregar = new daoTipoFalta();
            dtoTipoFalta modelo = new dtoTipoFalta();
            modelo.tipo = vista.txtNombre.Text;
            modelo.fkIdDeporte = stringAInt(vista.cboDeporte.SelectedValue.ToString());
            modeloAgregar.agregarTipoFalta(modelo);
            actualizarTablaTipoFalta();
        }

        private void clickCeldaDeLaTabla(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            vista.txtNombre.Text = nombre;
        }

        private void cargarForm(object sender, EventArgs e)
        {
            vista.vwtipofaltaTableAdapter.Fill(vista.vwTipoFalta.vwtipofalta);
            vista.cboBuscar.SelectedIndex = 0;
        }

        public void actualizarTablaTipoFalta()
        {
            vista.vwtipofaltaTableAdapter.Fill(vista.vwTipoFalta.vwtipofalta);
        }

        private void llenarModeloConFilaSeleccionada()
        {
            id = stringAInt(vista.tablaTipoFalta.SelectedRows[0].Cells[0].Value.ToString());
            nombre = vista.tablaTipoFalta.SelectedRows[0].Cells[1].Value.ToString();
            modeloFila.pkId = id;
        }
    }
}