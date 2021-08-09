using Modelo.DAO;
using Modelo.DTO;
using System;
using System.Windows.Forms;
using Vista;
using static Vista.utilidadForms;

namespace Controlador
{
    public class controladorEquipo
    {
        private formEquipo vista;
        private daoEquipo daoEquipo = new daoEquipo();
        private dtoEquipo modeloFila = new dtoEquipo();

        public controladorEquipo()
        {
        }

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

        private void clickActualizarEquipo(object sender, EventArgs e)
        {
            actualizarTablaJugadores();
        }

        private void cambioEnTextoFiltrarEquipo(object sender, EventArgs e)
        {
            filtrarTabla();
        }

        private void opcionSeleccionadaBuscarEquipo(object sender, EventArgs e)
        {
            vista.txtFiltrar.Text = "";
        }

        private void clickEliminarEquipo(object sender, EventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            daoEquipo.eliminarEquipo(modeloFila);
            actualizarTablaJugadores();
        }

        private void clickModificarEquipo(object sender, EventArgs e)
        {
            abrirForm(new formEquipoEventos(modeloFila, this));
        }

        private void clickAgregarEquipo(object sender, EventArgs e)
        {
            abrirForm(new formEquipoEventos(this));
        }

        private void clickCeldaDeLaTabla(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
        }

        private void cargarForm(object sender, EventArgs e)
        {
            actualizarTablaJugadores();
        }

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

        public void actualizarTablaJugadores()
        {
            vista.vwequipoTableAdapter.Fill(vista.vwEquipo.vwequipo);
        }

        public void llenarModeloConFilaSeleccionada()
        {
            modeloFila.pkId = stringAInt(vista.tablaEquipo.SelectedRows[0].Cells[0].Value.ToString());
            modeloFila.nombre = vista.tablaEquipo.SelectedRows[0].Cells[1].Value.ToString();
            modeloFila.fkIdDeporte = stringAInt(vista.tablaEquipo.SelectedRows[0].Cells[2].Value.ToString());
        }
    }
}