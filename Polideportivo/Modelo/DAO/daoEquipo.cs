using Dapper;
using Conexion;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using Modelo.DTO;

namespace Modelo.DAO
{
    /// <summary>
    /// Clase utilizada para agregar, modificar, eliminar o mostrar los campos de equipos en la base de datos.
    /// </summary>
    public class daoEquipo
    {
        private ConexionODBC ODBC = new ConexionODBC();

        /// <summary>
        /// Método que sirve para agregar nuevos equipos a la base de datos
        /// </summary>
        /// <param name="modelo">Recibe el modelo de equipo que se desea ingresar</param>
        /// <returns>Recibe el modelo de equipo que se desea ingresar</returns>
        public dtoEquipo agregarEquipo(dtoEquipo modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO equipo (pkId, nombre, fkIdDeporte) " +
                "VALUES (NULL, ?nombre?, ?fkIdDeporte?);";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre,
                    fkIdDeporte = modelo.fkIdDeporte
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        /// <summary>
        /// Método que sirve para modificar equipos
        /// </summary>
        /// <param name="modelo">Recibe el modelo de equipo para poder modificarlo</param>
        /// <returns>Retorna el equipo modificado para ser modificado en la tabla</returns>
        public dtoEquipo modificarEquipo(dtoEquipo modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE equipo SET nombre = ?nombre?, fkIdDeporte = ?fkIdDeporte? " +
                "WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre,
                    fkIdDeporte = modelo.fkIdDeporte,
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        /// <summary>
        /// Metodo que sirve para eliminar el equipo seleccionado de la base de datos
        /// </summary>
        /// <param name="modelo">Recibe el modelo del equipo seleccionado</param>
        /// <returns>Retorna el modelo del equipo seleccionado para eliminarlo</returns>
        public dtoEquipo eliminarEquipo(dtoEquipo modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM equipo WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    pkId = modelo.pkId
                };
                var resultadoinsertar = conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        /// <summary>
        /// Metodo que sirve para mostrar los equipos
        /// </summary>
        /// <returns>Retorna la consulta a la base de datos que son los jugadores de la tablaEquipos</returns>
        public List<dtoEquipo> mostrarEquipos()
        {
            List<dtoEquipo> sqlresultado = new List<dtoEquipo>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tablajugadores;";
                sqlresultado = conexionODBC.Query<dtoEquipo>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }

            return sqlresultado;
        }
        /// <summary>
        /// Metodo que sirve para mostrar los equipos
        /// </summary>
        /// <returns>Retorna la consulta a la base de datos que son los jugadores de la tablaEquipos</returns>
        public List<dtoEquipo> mostrarEquipo()
        {
            List<dtoEquipo> sqlresultado = new List<dtoEquipo>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM equipo;";
                sqlresultado = conexionODBC.Query<dtoEquipo>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
        /// <summary>
        /// Metodo que sirve para mostrar los jugadores por el deporte que se seleccionó
        /// </summary>
        /// <returns>Retorna el equipo ingresado para ser agregado a la tabla</returns>
        public List<dtoEquipo> mostrarEquipoPorDeporte(dtoEquipo modelo)
        {
            List<dtoEquipo> sqlresultado = new List<dtoEquipo>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT pkId, nombre, fkIdDeporte FROM equipo WHERE fkIdDeporte = ?fkIdDeporte?;";
                var valorDeVariables = new
                {
                    fkIdDeporte = modelo.fkIdDeporte
                };
                sqlresultado = conexionODBC.Query<dtoEquipo>(sqlconsulta, valorDeVariables).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}