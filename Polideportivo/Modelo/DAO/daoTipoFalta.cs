using Dapper;
using Conexion;
using Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

using Modelo.DTO;

namespace Modelo.DAO
{
    public class daoTipoFalta
    {
        private ConexionODBC ODBC = new ConexionODBC();
        /// <summary>
        /// Método que sirve para agregar nuevos tipos falta a la base de datos
        /// </summary>
        /// <param name="modelo">Recibe el modelo de tipo falta que se desea ingresar</param>
        /// <returns>Retorna la tipo falta ingresado para ser agregado a la tabla</returns>
        public dtoTipoFalta agregarTipoFalta(dtoTipoFalta modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO tipofalta (pkId, tipo, fkIdDeporte) " +
                "VALUES (NULL, ?tipo?, ?fkIdDeporte?);";
                var ValorDeVariables = new
                {
                    tipo = modelo.tipo,
                    fkIdDeporte = modelo.fkIdDeporte,
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }
        /// <summary>
        /// Método que sirve para modificar el tipo falta
        /// </summary>
        /// <param name="modelo">Recibe el modelo de tipo falta para poder modificarlo</param>
        /// <returns>Retorna la tipo falta modificada para ser modificada en la tabla</returns>
        public dtoTipoFalta modificarTipoFalta(dtoTipoFalta modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE tipofalta SET tipo = ?tipo?," +
                "fkIdDeporte = ?fkIdDeporte? " +
                "WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    tipo = modelo.tipo,
                    fkIdDeporte = modelo.fkIdDeporte,
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }
        /// <summary>
        /// Metodo que sirve para eliminar la tipo falta seleccionada de la base de datos
        /// </summary>
        /// <param name="modelo">Recibe el modelo de tipo falta seleccionada</param>
        /// <returns>Retorna el modelo de tipo falta seleccionada para eliminarl</returns>
        public dtoTipoFalta eliminarTipoFalta(dtoTipoFalta modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM tipofalta WHERE pkId = ?pkId?;";

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
        /// Metodo que sirve para mostrar tipo falta
        /// </summary>
        /// <returns>Retorna la consulta a la base de datos que son las tipo falta de la tablaTipoFalta</returns>
        public List<dtoTipoFalta> mostrarTipoFalta()
        {
            List<dtoTipoFalta> sqlresultado = new List<dtoTipoFalta>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tipofalta;";
                sqlresultado = conexionODBC.Query<dtoTipoFalta>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}