using Conexion;
using Dapper;
using Modelo.DTO;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

namespace Modelo.DAO
{
    class daoFase
    {
            private ConexionODBC ODBC = new ConexionODBC();
        /// <summary>
        /// Método que sirve para agregar nuevas fases a la base de datos
        /// </summary>
        /// <param name="modelo">Recibe el modelo de fase que se desea ingresar</param>
        /// <returns>Retorna la fase ingresada para ser agregado a la tabla</returns>
        public dtoFase agregarFase(dtoFase modelo)
            {
                OdbcConnection conexionODBC = ODBC.abrirConexion();
                if (conexionODBC != null)
                {
                    var sqlinsertar =
                    "INSERT INTO fase (pkId, nombre) " +
                    "VALUES (NULL, ?nombre?);";
                    var ValorDeVariables = new
                    {
                        nombre = modelo.nombre
                    };
                    conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                    ODBC.cerrarConexion(conexionODBC);
                    return modelo;
                }
                return null;
            }
            /// <summary>
            /// Método que sirve para modificar fases de los campeonatos
            /// </summary>
            /// <param name="modelo">Recibe el modelo de la fase para poder modificarlo</param>
            /// <returns>Retorna la fase para ser modificada en la tabla</returns>
            public dtoFase modificarFase(dtoFase modelo)
            {
                OdbcConnection conexionODBC = ODBC.abrirConexion();
                if (conexionODBC != null)
                {
                    var sqlinsertar =
                    "UPDATE fase SET nombre = ?nombre? " +
                    "WHERE pkId = ?pkId?;";
                    var ValorDeVariables = new
                    {
                        nombre = modelo.nombre,
                        pkId = modelo.pkId
                    };
                    conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                    ODBC.cerrarConexion(conexionODBC);
                    return modelo;
                }
                return null;
            }
            /// <summary>
            /// Método que sirve para eliminar la fase seleccionada de la base de datos 
            /// </summary>
            /// <param name="modelo">Recibe el modelo de la fase seleccionada</param>
            /// <returns>Retorna el modelo de la fase seleccionada para eliminarla</returns>
            public dtoFase eliminarFase(dtoFase modelo)
            {
                OdbcConnection conexionODBC = ODBC.abrirConexion();
                if (conexionODBC != null)
                {
                    var sqlinsertar =
                    "DELETE FROM fase WHERE pkId = ?pkId?;";

                    var ValorDeVariables = new
                    {
                        pkId = modelo.pkId
                    };
                    conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                    ODBC.cerrarConexion(conexionODBC);
                    return modelo;
                }
                return null;
            }
            /// <summary>
            /// Metodo que sirve para mostrar la fase
            /// </summary>
            /// <returns>Retorna la consulta a la base de datos que son las fases de la tablaFase</returns>
            public List<dtoFase> mostrarFase()
            {
                List<dtoFase> sqlresultado = new List<dtoFase>();
                OdbcConnection conexionODBC = ODBC.abrirConexion();
                if (conexionODBC != null)
                {
                    string sqlconsulta = "SELECT * FROM fase;";
                    sqlresultado = conexionODBC.Query<dtoFase>(sqlconsulta).ToList();
                    ODBC.cerrarConexion(conexionODBC);
                    return sqlresultado;
                }
                return null;
            }



        
    }
}