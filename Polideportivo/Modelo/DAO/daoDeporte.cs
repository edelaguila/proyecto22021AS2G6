using Conexion;
using Dapper;
using Modelo.DTO;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

namespace Modelo.DAO
{
    class daoDeporte
    {
        private ConexionODBC ODBC = new ConexionODBC();

        /// <summary>
        /// Método que sirve para agregar nuevos deportes a la base de datos
        /// </summary>
        /// <param name="modelo">Recibe el modelo del deporte que se desea ingresar</param>
        /// <returns>Retorna el deporte ingresado para ser agregado a la tabla</returns>
        public dtoDeporte agregarDeporte(dtoDeporte modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO deporte (pkId, nombre) " +
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
        /// Método que sirve para modificar Deportes
        /// </summary>
        /// <param name="modelo">Recibe el modelo de deporte para poder modificarlo</param>
        /// <returns>Retorna el deporte modificado para ser modificado en la tabla</returns>
        public dtoDeporte modificarDeporte(dtoDeporte modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE deporte SET nombre = ?nombre? " +
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
        /// Metodo que sirve para eliminar el deporte seleccionado de la base de datos
        /// </summary>
        /// <param name="modelo">Recibe el modelo del deporte seleccionado</param>
        /// <returns>Retorna el modelo del deporte seleccionado para eliminarlo</returns>
        public dtoDeporte eliminarDeporte(dtoDeporte modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM deporte WHERE pkId = ?pkId?;";

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
        /// Metodo que sirve para mostrar los deportes
        /// </summary>
        /// <returns>Retorna la consulta a la base de datos que son los deportes de la tabladeportes</returns>
        public List<dtoDeporte> mostrarDeportes()
        {
            List<dtoDeporte> sqlresultado = new List<dtoDeporte>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM deporte;";
                sqlresultado = conexionODBC.Query<dtoDeporte>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
                return sqlresultado;
            }
            return null;
        }
    }
}