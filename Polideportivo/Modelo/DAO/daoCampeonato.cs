using Dapper;
using Conexion;
using System.Data.Odbc;
using System.Linq;
using System.Collections.Generic;
using Modelo.DTO;

namespace Modelo.DAO
{
    /// <summary>
    /// Clase utilizada para agregar, modificar, eliminar o mostrar los campos de campeonatos en la base de datos.
    /// </summary>
    public class daoCampeonato
    {
        private ConexionODBC ODBC = new ConexionODBC();

        /// <summary>
        ///  Método que sirve para agregar nuevos campeonatos a la base de datos
        /// </summary>
        /// <param name="modelo">Recibe el modelo de Campeonato que se desea ingresar</param>
        /// <returns>Retorna el campeonato ingresado para ser agregado a la tabla</returns>
        public dtoCampeonato AgregarCampeonato(dtoCampeonato modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO campeonato(pkId, nombre, fechaInicio, fechaFinal, fkIdDeporte, fkIdTipoCampeonato)" +
                " VALUES  (NULL, ?nombre?, ?fechaInicio?, ?fechaFinal?, ?fkIdDeporte?, " +
                "?fkIdTipoCampeonato?);";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre,
                    fechaInicio = modelo.fechaInicio,
                    fechaFinal = modelo.fechaFinal,
                    fkIdDeporte = modelo.fkIdDeporte,
                    fkIdTipoCampeonato = modelo.fkIdTipoCampeonato
                };

                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        /// <summary>
        /// Método que sirve para modificar campeonatos
        /// </summary>
        /// <param name="modelo">Recibe el modelo de campeonato que se desea modificar</param>
        /// <returns>Retorna el jugador seleccionado para ser modificado en la tabla</returns>
        public dtoCampeonato ModificarCampeonato(dtoCampeonato modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE campeonato SET nombre = ?nombre?, fechaInicio = ?fechaInicio?, " +
                "fechaFinal = ?fechaFinal?, fkIdDeporte = ?fkIdDeporte?, fkIdTipoCampeonato = ?fkIdTipoCampeonato?" +
                " WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    pkId = modelo.pkId,
                    nombre = modelo.nombre,
                    fechaInicio = modelo.fechaInicio,
                    fechaFinal = modelo.fechaFinal,
                    fkIdDeporte = modelo.fkIdDeporte,
                    fkIdTipoCampeonato = modelo.fkIdTipoCampeonato
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }

            return modelo;
        }

        /// <summary>
        /// Método que sirve para eliminar campeonatos
        /// </summary>
        /// <param name="modelo">Reibe el modelo del campeonato seleccionado</param>
        /// <returns>Retorna el modelo del jugador seleccionado para ser eliminado</returns>
        public dtoCampeonato eliminarCampeonato(dtoCampeonato modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM campeonato WHERE pkId = ?pkId?;";
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
        /// Método que sirve para mostrar los campeonatos
        /// </summary>
        /// <returns>Retorna los campeonatos para ser mostrados en la tabla</returns>
        public List<dtoCampeonato> mostrarCampeonato()
        {
            List<dtoCampeonato> sqlresultado = new List<dtoCampeonato>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM campeonato;";
                sqlresultado = conexionODBC.Query<dtoCampeonato>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}