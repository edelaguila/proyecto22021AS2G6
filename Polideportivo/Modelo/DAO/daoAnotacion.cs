using Dapper;
using Conexion;
using Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using Modelo.DTO;

namespace Modelo.DAO
{
    /// <summary>
    /// Clase utilizada para agregar, modificar, eliminar o mostrar los campos de anotaciones en la base de datos.
    /// </summary>
    public class daoAnotacion
    {
        private ConexionODBC ODBC = new ConexionODBC();

        /// <summary>
        /// Método que sirve para agregar nuevas anotaciones según el jugador
        /// </summary>
        /// <param name="modelo">Se ingresa el modelo de anotaciones que se va a agregar</param>
        /// <returns>Devuelve el modelo agregado si tuvo éxito para añadirlo a la tabla</returns>
        public dtoAnotacion agregarAnotacion(dtoAnotacion modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO anotacion (pkId, cantidad, fkIdJugador, fkIdPartido) " +
                "VALUES (NULL, ?cantidad?, ?fkIdJugador?, ?fkIdPartido?);";
                var ValorDeVariables = new
                {
                    cantidad = modelo.cantidad,
                    fkIdJugador = modelo.fkIdJugador,
                    fkIdPartido = modelo.fkIdPartido
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }

            return modelo;
        }

        /// <summary>
        /// Método que sirve para modificar las anotaciones de algún jugador
        /// </summary>
        /// <param name="modelo">Se ingresa el modelo del jugador que se quiere modificar</param>
        /// <returns>Retorna el modelo modificado para actualizar la tabla</returns>
        public dtoAnotacion modificarAnotacion(dtoAnotacion modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE anotacion SET cantidad = ?cantidad? ," +
                "fkIdJugador = ?fkIdJugador?, fkIdPartido = ?fkIdPartido?, " +
                "WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    cantidad = modelo.cantidad,
                    fkIdJugador = modelo.fkIdJugador,
                    fkIdPartido = modelo.fkIdPartido,
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }

            return modelo;
        }

        /// <summary>
        /// Método que sirve para eliminar anotaciones
        /// </summary>
        /// <param name="modelo">Se ingresa el modelo que se quiere eliminar</param>
        /// <returns>Devuelve el modelo que eliminó</returns>
        public dtoAnotacion eliminarAnotacion(dtoAnotacion modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM anotacion WHERE pkId = ?pkId?;";

                var ValorDeVariables = new
                {
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }

            return modelo;
        }

        /// <summary>
        /// Método que sirve para ver las anotaciones de cada jugador
        /// </summary>
        /// <returns>Devuelve una lista ordenada según las anotaciones de cada jugador</returns>
        public List<dtoAnotacion> mostrarAnotacion()
        {
            List<dtoAnotacion> sqlresultado = new List<dtoAnotacion>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM anotacion;";
                sqlresultado = conexionODBC.Query<dtoAnotacion>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}