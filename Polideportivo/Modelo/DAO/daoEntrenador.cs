using Dapper;
using Conexion;
using Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using Modelo.DTO;

namespace Modelo.DAO
{
    public class daoEntrenador
    {
        private ConexionODBC ODBC = new ConexionODBC();

        /// <summary>
        /// Método que sirve para agregar nuevos entrenadores a la base de datos 
        /// </summary>
        /// <param name="modelo">Recibe el modelo del entrenador que se desea ingresar</param>
        /// <returns>Retorna el entrenador ingresado para ser agregado a la tabla</returns>
        public dtoEntrenador agregarEntrenador(dtoEntrenador modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();

            if (conexionODBC != null)
            {
                var sqlinsertar =

                "INSERT INTO entrenador (pkId, nombre, fkIdEquipo) " +

                "VALUES (NULL, ?nombre?, ?fkIdEquipo?);";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre,
                    fkIdEquipo = modelo.fkIdEquipo,
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);

                ODBC.cerrarConexion(conexionODBC);
            }

            return modelo;
        }

        /// <summary>
        /// Método que sirve para modificar a los entrenadores
        /// </summary>
        /// <param name="modelo">Recibe el modelo de entrenador para modificarlo</param>
        /// <returns>Retorna el entrenador modificado para ser modificado en la tabla</returns>
        public dtoEntrenador modificarEntrenador(dtoEntrenador modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE entrenador SET nombre = ?nombre? ," +
                "fkIdEquipo = ?fkIdEquipo? " +
                "WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre,
                    fkIdEquipo = modelo.fkIdEquipo,
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        /// <summary>
        /// Método que sirve para eliminar el entrenador seleccionado de la base de datos
        /// </summary>
        /// <param name="modelo">Recibe el modelo del entrenador seleccionado</param>
        /// <returns>Retorna el modelo del entrenador seleccionado para eliminarlo </returns>
        public dtoEntrenador eliminarEntrenador(dtoEntrenador modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM entrenador WHERE pkId = ?pkId?;";

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
        /// Método que sirve para mostrar los jugadores
        /// </summary>
        /// <returns>Retorna la consulta a la base de datos que son los jugadores de la tablaEntrenador</returns>
        public List<dtoEntrenador> mostrarEntrenador()
        {
            List<dtoEntrenador> sqlresultado = new List<dtoEntrenador>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM entrenador;";
                sqlresultado = conexionODBC.Query<dtoEntrenador>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}