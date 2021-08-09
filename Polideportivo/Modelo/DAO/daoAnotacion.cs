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
    /// Controlador para anotaciones
    /// </summary>
    public class daoAnotacion
    {
        private ConexionODBC ODBC = new ConexionODBC();

        /// <summary>
        /// Controlador para anotaciones
        /// </summary>
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