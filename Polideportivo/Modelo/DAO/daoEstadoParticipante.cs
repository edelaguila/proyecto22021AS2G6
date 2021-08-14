using Conexion;
using Dapper;
using Modelo.DTO;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

namespace Modelo.DAO
{
    class daoEstadoParticipante
    {
        private ConexionODBC ODBC = new ConexionODBC();
        /// <summary>
        ///  Método que sirve para agregar nuevos estados de participante a la base de datos
        /// </summary>
        /// <param name="modelo">Recibe el modelo de estado participante que se desea ingresar</param>
        /// <returns>Retorna el estado participante ingresado para ser agregado a la tabla</returns>
        public dtoEstadoParticipante agregarEstadoParticipante(dtoEstadoParticipante modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO estadoParticipante (pkId, nombre) " +
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
        /// Metodo que sirve para modificar estados de participante
        /// </summary>
        /// <param name="modelo">Recibe el modelo de estado participante para poder modificarlo</param>
        /// <returns>Retorna el estado participante para ser modificado en la tabla</returns>
        public dtoEstadoParticipante modificarEstadoParticipante(dtoEstadoParticipante modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE estadoParticipante SET nombre = ?nombre? " +
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
        ///  Metodo que sirve para eliminar el estado participante seleccionado de la base de datos
        /// </summary>
        /// <param name="modelo">Recibe el modelo del estado participante seleccionado</param>
        /// <returns>Retorna el modelo del estado participante seleccionado para eliminarlo</returns>
        public dtoEstadoParticipante eliminarEstadoParticipante(dtoEstadoParticipante modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM estadoParticipante WHERE pkId = ?pkId?;";

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
        /// Método que sirve para mostrar el estado del participante
        /// </summary>
        /// <returns>Retorna la consulta a la base de datos</returns>
        public List<dtoEstadoParticipante> mostrarEstadoParticipante()
        {
            List<dtoEstadoParticipante> sqlresultado = new List<dtoEstadoParticipante>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM estadoParticipante;";
                sqlresultado = conexionODBC.Query<dtoEstadoParticipante>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
                return sqlresultado;
            }
            return null;
        }
    }
}