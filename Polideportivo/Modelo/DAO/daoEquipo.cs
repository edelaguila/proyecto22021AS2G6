using Dapper;
using Conexion;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using Modelo.DTO;

namespace Modelo.DAO
{
    public class daoEquipo
    {
        private ConexionODBC ODBC = new ConexionODBC();

        public dtoEquipo agregarEquipo(dtoEquipo modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO equipo (pkId, nombre, fkIdDeporte) " +
                "VALUES (NULL, ?nombre?, ?fkIdDeporte?);";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre,
                    fkIdDeporte = modelo.fkIdDeporte
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public dtoEquipo modificarEquipo(dtoEquipo modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE equipo SET nombre = ?nombre?, fkIdDeporte = ?fkIdDeporte? " +
                "WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre,
                    fkIdDeporte = modelo.fkIdDeporte,
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public dtoEquipo eliminarEquipo(dtoEquipo modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM equipo WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    pkId = modelo.pkId
                };
                var resultadoinsertar = conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public List<dtoEquipo> mostrarEquipos()
        {
            List<dtoEquipo> sqlresultado = new List<dtoEquipo>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tablajugadores;";
                sqlresultado = conexionODBC.Query<dtoEquipo>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }

            return sqlresultado;
        }

        public List<dtoEquipo> mostrarEquipo()
        {
            List<dtoEquipo> sqlresultado = new List<dtoEquipo>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM equipo;";
                sqlresultado = conexionODBC.Query<dtoEquipo>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }

        public List<dtoEquipo> mostrarEquipoPorDeporte(dtoEquipo modelo)
        {
            List<dtoEquipo> sqlresultado = new List<dtoEquipo>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT pkId, nombre, fkIdDeporte FROM equipo WHERE fkIdDeporte = ?fkIdDeporte?;";
                var valorDeVariables = new
                {
                    fkIdDeporte = modelo.fkIdDeporte
                };
                sqlresultado = conexionODBC.Query<dtoEquipo>(sqlconsulta, valorDeVariables).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}