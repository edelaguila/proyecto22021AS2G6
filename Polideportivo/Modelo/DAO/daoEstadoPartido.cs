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
    /// Clase utilizada para agregar, modificar, eliminar o mostrar los campos de partidos en la base de datos.
    /// </summary>
    public class daoEstadoPartido
    {
        private ConexionODBC ODBC = new ConexionODBC();
        /// <summary>
        /// Método que sirve para agregar nuevos estados de partido a la base de datos
        /// </summary>
        /// <param name="modelo">Recibe el modelo de estado partido que se desea ingresar</param>
        /// <returns></returns>
        public dtoEstadoPartido agregarEstado(dtoEstadoPartido modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO estado (pkId, nombre) " +
                "VALUES (NULL, ?nombre?);";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }
        /// <summary>
        /// Método que sirve para modificar los estados de partido
        /// </summary>
        /// <param name="modelo">Recibe el modelo de estado partido para poder modificarlo</param>
        /// <returns>Retorna el estado partido para ser modificado en la tabla </returns>
        public dtoEstadoPartido modificarEstado(dtoEstadoPartido modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE estado SET nombre = ?nombre? " +
                "WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre,
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }
        /// <summary>
        /// Metodo que sirve para eliminar el estado partido seleccionado de la base de datos
        /// </summary>
        /// <param name="modelo">Recibe el modelo del estado partido seleccionado</param>
        /// <returns>Retorna el modelo del estado partido seleccionado para eliminarlo</returns>
        public dtoEstadoPartido eliminarEstado(dtoEstadoPartido modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM estado WHERE pkId = ?pkId?;";

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
        /// Metodo que sirve para mostrar los estado partido
        /// </summary>
        /// <returns>Retorna la consulta a la base de datos que son los estados partido de la tablaEstadoPartido</returns>
        public List<dtoEstadoPartido> mostrarEstado()
        {
            List<dtoEstadoPartido> sqlresultado = new List<dtoEstadoPartido>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM estadoPartido;";
                sqlresultado = conexionODBC.Query<dtoEstadoPartido>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}