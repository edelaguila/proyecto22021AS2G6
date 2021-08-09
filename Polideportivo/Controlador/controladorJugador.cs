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

        private modeloJugador modeloFila = new modeloJugador();

        public controladorJugador()
        {
        }

        public controladorJugador(formJugador Vista)
        {
            vista = Vista;
            // Creación de eventos
            Vista.Load += new EventHandler(cargarForm);
            vista.tablaJugadores.CellClick += new DataGridViewCellEventHandler(clickCeldaDeLaTabla);
            vista.btnActualizar.Click += new EventHandler(clickActualizarJugador);
            vista.btnAgregarJugador.Click += new EventHandler(clickAgregarJugador);
        }

        private void cargarForm(object sender, EventArgs e)
        {
            vista.vwjugadorTableAdapter.Fill(vista.vwJugador.vwjugador);
            // Se asigna la primera opción posible en la combobox de filtración
            vista.cboBuscar.SelectedIndex = 0;
            // Se asigna la primera fila posible de la tabla y se llena el modelo
            vista.tablaJugadores.CurrentCell = vista.tablaJugadores.Rows[0].Cells[1];
            vista.llenarModeloConFilaSeleccionada();
        }

        private void clickCeldaDeLaTabla(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
        }

        private void clickActualizarJugador(object sender, EventArgs e)
        {
            actualizarTablaJugadores();
        }

        private void clickAgregarJugador(object sender, EventArgs e)
        {
            abrirForm(new formJugadorEventos(vista));
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

        private ConexionODBC ODBC = new ConexionODBC();

        /// <summary>
        /// Método que sirve para agregar nuevos jugadores a la base de datos
        /// </summary>
        /// <param name="modelo"></param>
        /// <returns></returns>
        public modeloJugador agregarJugador(modeloJugador modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO jugador (pkId, nombre, anotaciones, fkIdEquipo, fkIdRol) " +
                "VALUES (NULL, ?nombre?, ?anotaciones?, ?fkIdEquipo?, ?fkIdRol?);";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre,
                    anotaciones = modelo.anotaciones,
                    fkIdEquipo = modelo.fkIdEquipo,
                    fkIdRol = modelo.fkIdRol
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
                return modelo;
            }
            return null;
        }

        /// <summary>
        /// Método que sirve para modificar jugadores
        /// </summary>
        /// <param name="modelo"></param>
        /// <returns></returns>
        public modeloJugador modificarJugador(modeloJugador modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE jugador SET nombre = ?nombre?, anotaciones = ?anotaciones?, " +
                "fkIdEquipo = ?fkIdEquipo?, fkIdRol = ?fkIdRol?" +
                " WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre,
                    anotaciones = modelo.anotaciones,
                    fkIdEquipo = modelo.fkIdEquipo,
                    fkIdRol = modelo.fkIdRol,
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public List<modeloJugador> mostrarJugadores()
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            List<modeloJugador> sqlresultado = new List<modeloJugador>();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tablajugadores;";
                sqlresultado = conexionODBC.Query<modeloJugador>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }

        public List<modeloJugador> mostrarJugadoresPorDeporte()
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            List<modeloJugador> sqlresultado = new List<modeloJugador>();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tablajugadores;";
                sqlresultado = conexionODBC.Query<modeloJugador>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }

        public modeloJugador eliminarJugador(modeloJugador modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM jugador WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }
    }
}