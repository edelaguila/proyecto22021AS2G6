using Dapper;
using Polideportivo.Conexion;
using Polideportivo.Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

namespace Polideportivo.Controlador
{
    internal class controladorEntrenador
    {
        private ConexionODBC ODBC = new ConexionODBC();

        public modeloEntrenador agregarEntrenador(modeloEntrenador modelo)
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

        public modeloEntrenador modificarEntrenador(modeloEntrenador modelo)
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

        public modeloEntrenador eliminarEntrenador(modeloEntrenador modelo)
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

        public List<modeloEntrenador> mostrarEntrenador()
        {
            List<modeloEntrenador> sqlresultado = new List<modeloEntrenador>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM entrenador;";
                sqlresultado = conexionODBC.Query<modeloEntrenador>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}