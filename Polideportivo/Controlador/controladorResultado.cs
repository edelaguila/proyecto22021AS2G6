using Dapper;
using Polideportivo.Conexion;
using Polideportivo.Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

namespace Polideportivo.Controlador
{
    internal class controladorResultado
    {
        private ConexionODBC ODBC = new ConexionODBC();

        public modeloResultado agregarResultado(modeloResultado modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO resultado (pkId, anotacionEquipo1, anotacionEquipo2) " +
                "VALUES (NULL, ?anotacionEquipo1?, ?anotacionEquipo2?);";
                var ValorDeVariables = new
                {
                    anotacionEquipo1  = modelo.anotacionEquipo1,
                    anotacionEquipo2 = modelo.anotacionEquipo2
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public modeloResultado modificarResultado(modeloResultado modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE resultado SET anotacionEquipo1 = ?anotacionEquipo1?, anotacionEquipo2 = ?anotacionEquipo2? " +
                "WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    anotacionEquipo1 = modelo.anotacionEquipo1,
                    anotacionEquipo2 = modelo.anotacionEquipo2
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public modeloResultado eliminarResultado(modeloResultado modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM resultado WHERE pkId = ?pkId?;";

                var ValorDeVariables = new
                {
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public List<modeloResultado> mostrarResultado()
        {
            List<modeloResultado> sqlresultado = new List<modeloResultado>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM resultado;";
                sqlresultado = conexionODBC.Query<modeloResultado>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}