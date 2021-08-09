using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista;
using Modelo.DAO;
using Modelo.DTO;
using static Vista.utilidadForms;
using System.Windows.Forms;

namespace Controlador
{
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

        private void cargarForm(object sender, EventArgs e)
        {
            vista.vwrolTableAdapter.Fill(vista.vwRol.vwrol);
        }

        private void clickEliminarRol(object sender, EventArgs e)
        {
            int id = stringAInt(vista.tablaRol.SelectedRows[0].Cells[0].Value.ToString());
            daoRol controlador = new daoRol();
            dtoRol modelo = new dtoRol();
            modelo.pkId = id;
            controlador.eliminarRol(modelo);
            actualizarTablaRol();
        }

        private void clickActualizarRol(object sender, EventArgs e)
        {
            actualizarTablaRol();
        }

        private void opcionSeleccionadaBuscarRol(object sender, EventArgs e)
        {
            vista.txtFiltrarRol.Text = "";
        }

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

        private void clickModificarRol(object sender, EventArgs e)
        {
            daoRol modeloModificar = new daoRol();
            dtoRol modelo = new dtoRol();
            modeloFila.nombre = vista.txtNombreRol.Text;
            modeloFila.fkIdDeporte = stringAInt(vista.cboDeporte.SelectedValue.ToString());
            modeloModificar.modificarRol(modeloFila);
            actualizarTablaRol();
        }

        private void clickAgregarRol(object sender, EventArgs e)
        {
            daoRol modeloAgregar = new daoRol();
            dtoRol modelo = new dtoRol();
            modelo.nombre = vista.txtNombreRol.Text;
            modelo.fkIdDeporte = stringAInt(vista.cboDeporte.SelectedValue.ToString());
            modeloAgregar.agregarRol(modelo);
            actualizarTablaRol();
        }

        private void clickCeldaDeLaTabla(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            vista.txtNombreRol.Text = nombre;
        }

        public void actualizarTablaRol()
        {
            vista.vwrolTableAdapter.Fill(vista.vwRol.vwrol);
        }

        private void llenarModeloConFilaSeleccionada()
        {
            id = stringAInt(vista.tablaRol.SelectedRows[0].Cells[0].Value.ToString());
            nombre = vista.tablaRol.SelectedRows[0].Cells[1].Value.ToString();
            modeloFila.pkId = id;
        }
    }
}