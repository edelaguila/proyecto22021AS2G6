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