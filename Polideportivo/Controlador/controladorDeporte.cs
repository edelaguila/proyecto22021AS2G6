using Dapper;
using Conexion;
using Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using Modelo.DTO;
using Modelo.DAO;
using Vista;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Vista.utilidadForms;

namespace Controlador
{
    public class controladorDeporte
    {
        private int id;
        private string nombre;
        private dtoDeporte modeloFila = new dtoDeporte();
        private formDeporte vista;

        public controladorDeporte()
        {
        }

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

        private void clickAgregarDeporte(object sender, EventArgs e)
        {
            daoDeporte daoDeporte = new daoDeporte();
            dtoDeporte dtoDeporte = new dtoDeporte();
            dtoDeporte.nombre = vista.txtNombreDeporte.Text;
            daoDeporte.agregarDeporte(dtoDeporte);
            actualizarTablaDeporte();
        }

        private void clickModificarDeporte(object sender, EventArgs e)
        {
            daoDeporte daoDeporte = new daoDeporte();
            modeloFila.nombre = vista.txtNombreDeporte.Text;
            daoDeporte.modificarDeporte(modeloFila);
            actualizarTablaDeporte();
        }

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

        private void clickActualizarDeporte(object sender, EventArgs e)
        {
            actualizarTablaDeporte();
        }

        private void clickEliminarDeporte(object sender, EventArgs e)
        {
            daoDeporte daoDeporte = new daoDeporte();
            dtoDeporte dtoDeporte = new dtoDeporte();
            int id = stringAInt(vista.tablaDeportes.SelectedRows[0].Cells[0].Value.ToString());
            dtoDeporte.pkId = id;
            daoDeporte.eliminarDeporte(dtoDeporte);
            actualizarTablaDeporte();
        }

        private void opcionSeleccionadaBuscarDeporte(object sender, EventArgs e)
        {
            vista.txtFiltrar.Text = "";
        }

        private void clickCeldaDeLaTabla(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            vista.txtNombreDeporte.Text = nombre;
        }

        private void llenarModeloConFilaSeleccionada()
        {
            id = stringAInt(vista.tablaDeportes.SelectedRows[0].Cells[0].Value.ToString());
            nombre = vista.tablaDeportes.SelectedRows[0].Cells[1].Value.ToString();
            modeloFila.pkId = id;
        }

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

        public void actualizarTablaDeporte()
        {
            vista.deporteTableAdapter.Fill(vista.vwDeportes.deporte);
        }
    }
}