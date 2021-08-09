using Dapper;
using Conexion;
using Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using Vista;
using System;
using Datos.vwJugadorTableAdapters;
using Datos;
using static Vista.utilidadForms;
using System.Windows.Forms;
using Modelo.DTO;
using Modelo.DAO;

namespace Controlador
{
    /// <summary>
    /// Clase que gestiona la tabla de jugadores de la base de datos
    /// </summary>
    public class controladorJugador
    {
        private formJugador vista;
        private int id;
        private string nombre;
        private int anotaciones;
        private int fkIdEquipo;
        private int fkIdRol;
        private int fkIdDeporte;

        private dtoJugador modeloFila = new dtoJugador();

        public controladorJugador()
        {
        }

        public controladorJugador(formJugador Vista)
        {
            vista = Vista;
            // Creación de eventos
            vista.Load += new EventHandler(cargarForm);
            vista.tablaJugadores.CellClick += new DataGridViewCellEventHandler(clickCeldaDeLaTabla);
            vista.btnActualizarJugador.Click += new EventHandler(clickActualizarJugador);
            vista.btnAgregarJugador.Click += new EventHandler(clickAgregarJugador);
            vista.btnModificarJugador.Click += new EventHandler(clickModificarJugador);
            vista.btnEliminarJugador.Click += new EventHandler(clickEliminarJugador);
            vista.txtFiltrar.TextChanged += new EventHandler(cambioEnTextoFiltrarJugador);
            vista.cboBuscar.SelectedIndexChanged += new EventHandler(opcionSeleccionadaBuscarJugador);
        }

        private void cargarForm(object sender, EventArgs e)
        {
            vista.vwjugadorTableAdapter.Fill(vista.vwJugador.vwjugador);
            // Se asigna la primera opción posible en la combobox de filtración
            vista.cboBuscar.SelectedIndex = 0;
            // Se asigna la primera fila posible de la tabla y se llena el modelo
            vista.tablaJugadores.CurrentCell = vista.tablaJugadores.Rows[0].Cells[1];
            llenarModeloConFilaSeleccionada();
        }

        private void clickCeldaDeLaTabla(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
        }

        private void clickActualizarJugador(object sender, EventArgs e)
        {
            actualizarTablaJugadores();
        }

        private void clickAgregarJugador(object sender, EventArgs e)
        {
            abrirForm(new formJugadorEventos(this));
        }

        private void clickModificarJugador(object sender, EventArgs e)
        {
            abrirForm(new formJugadorEventos(modeloFila, this));
        }

        private void opcionSeleccionadaBuscarJugador(object sender, EventArgs e)
        {
            vista.txtFiltrar.Text = "";
        }

        private void clickEliminarJugador(object sender, EventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            daoJugador daoJugador = new daoJugador();
            daoJugador.eliminarJugador(modeloFila);
            actualizarTablaJugadores();
        }

        private void cambioEnTextoFiltrarJugador(object sender, EventArgs e)
        {
            filtrarTabla();
        }

        public void actualizarTablaJugadores()
        {
            vista.vwjugadorTableAdapter.Fill(vista.vwJugador.vwjugador);
        }

        public void llenarModeloConFilaSeleccionada()
        {
            id = stringAInt(vista.tablaJugadores.SelectedRows[0].Cells[0].Value.ToString());
            nombre = vista.tablaJugadores.SelectedRows[0].Cells[1].Value.ToString();
            anotaciones = stringAInt(vista.tablaJugadores.SelectedRows[0].Cells[2].Value.ToString());
            fkIdEquipo = stringAInt(vista.tablaJugadores.SelectedRows[0].Cells[3].Value.ToString());
            fkIdRol = stringAInt(vista.tablaJugadores.SelectedRows[0].Cells[5].Value.ToString());
            fkIdDeporte = stringAInt(vista.tablaJugadores.SelectedRows[0].Cells[7].Value.ToString());
            modeloFila.pkId = id;
            modeloFila.nombre = nombre;
            modeloFila.anotaciones = anotaciones;
            modeloFila.fkIdEquipo = fkIdEquipo;
            modeloFila.fkIdRol = fkIdRol;
            modeloFila.fkIdDeporte = fkIdDeporte;
        }

        private void filtrarTabla()
        {
            if (string.IsNullOrEmpty(vista.txtFiltrar.Text))
            {
                vista.vwjugadorBindingSource.Filter = string.Empty;
            }
            else
            {
                vista.vwjugadorBindingSource.Filter = string.Format("{0}='{1}'", vista.cboBuscar.Text, vista.txtFiltrar.Text);
            }
        }
    }
}