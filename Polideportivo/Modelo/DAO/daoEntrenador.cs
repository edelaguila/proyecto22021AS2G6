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