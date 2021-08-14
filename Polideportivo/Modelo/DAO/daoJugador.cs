using Conexion;
using Dapper;
using Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.DAO
{
    class daoJugador
    {
        private ConexionODBC ODBC = new ConexionODBC();

        /// <summary>
        /// Método que sirve para agregar nuevos jugadores a la base de datos
        /// </summary>
        /// <param name="modelo">Recibe el modelo de jugador que se desea ingresar</param>
        /// <returns>Retorna el jugador ingresado para ser agregado a la tabla</returns>
        public dtoJugador agregarJugador(dtoJugador modelo)
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
        /// <param name="modelo">Recibe el modelo de jugador para poder modificarlo</param>
        /// <returns>Retorna el jugador modificado para ser modificado en la tabla</returns>
        public dtoJugador modificarJugador(dtoJugador modelo)
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
        /// <summary>
        /// Método que sirve para mostrar los jugadores 
        /// </summary>
        /// <returns>Retorna la consulta a la base de datos que son los jugadores de la tablaJugadores</returns>
        public List<dtoJugador> mostrarJugadores()
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            List<dtoJugador> sqlresultado = new List<dtoJugador>();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tablajugadores;";
                sqlresultado = conexionODBC.Query<dtoJugador>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
        /// <summary>
        /// Metodo que sirve para mostrar los jugadores por el deporte que se seleccionó
        /// </summary>
        /// <returns>Retorna la consulta a la base de datos</returns>
        public List<dtoJugador> mostrarJugadoresPorDeporte()
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            List<dtoJugador> sqlresultado = new List<dtoJugador>();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tablajugadores;";
                sqlresultado = conexionODBC.Query<dtoJugador>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
        /// <summary>
        /// Metodo que sirve para eliminar el jugador seleccionado de la base de datos
        /// </summary>
        /// <param name="modelo">Recibe el modelo del jugador seleccionado</param>
        /// <returns>Retorna el modelo del jugador seleccionado para eliminarlo</returns>
        public dtoJugador eliminarJugador(dtoJugador modelo)
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