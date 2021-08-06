using Dapper;
using Conexion;
using Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

namespace Controlador
{
    public class controladorJugador
    {
        private ConexionODBC ODBC = new ConexionODBC();

        public modeloJugador agregarJugador(modeloJugador modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO jugador (pkId, nombre, anotaciones, fkIdEquipo, fkIdRol) " +
                "VALUES (NULL, ?nombre?, ?anotaciones?, ?fkIdEquipo?, ?fkIdRol?);";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre,
                    anotaciones = modelo.anotaciones,
                    fkIdEquipo = modelo.fkIdEquipo,
                    fkIdRol = modelo.fkIdRol
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        /// <summary>
        /// Prueba de modificar
        /// </summary>
        /// <param name="modelo"></param>
        /// <returns></returns>
        public modeloJugador modificarJugador(modeloJugador modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE jugador SET nombre = ?nombre?, anotaciones = ?anotaciones?, " +
                "fkIdEquipo = ?fkIdEquipo?, fkIdRol = ?fkIdRol?" +
                " WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre,
                    anotaciones = modelo.anotaciones,
                    fkIdEquipo = modelo.fkIdEquipo,
                    fkIdRol = modelo.fkIdRol,
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public List<modeloJugador> mostrarJugadores()
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            List<modeloJugador> sqlresultado = new List<modeloJugador>();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tablajugadores;";
                sqlresultado = conexionODBC.Query<modeloJugador>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }

        public List<modeloJugador> mostrarJugadoresPorDeporte()
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            List<modeloJugador> sqlresultado = new List<modeloJugador>();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tablajugadores;";
                sqlresultado = conexionODBC.Query<modeloJugador>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }

        public modeloJugador eliminarJugador(modeloJugador modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM jugador WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }
    }
}