using Dapper;
using Polideportivo.Conexion;
using Polideportivo.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polideportivo.Controlador
{
    class controladorEquipo
    {

        ConexionODBC ODBC = new ConexionODBC();

        public modeloEquipo agregarEquipo(modeloEquipo modelo)
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

        public modeloEquipo modificarEquipo(modeloEquipo modelo)
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

        public modeloEquipo eliminarEquipo(modeloEquipo modelo)
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

        public List<modeloEquipo> mostrarEquipos()
        {
            List<modeloEquipo> sqlresultado = new List<modeloEquipo>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tablajugadores;";
                sqlresultado = conexionODBC.Query<modeloEquipo>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }

            return sqlresultado;
        }

        public List<modeloEquipo> mostrarEquipoPorDeporte(modeloEquipo modelo)
        {
            List<modeloEquipo> sqlresultado = new List<modeloEquipo>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT pkId, nombre, fkIdDeporte FROM equipo WHERE fkIdDeporte = ?fkIdDeporte?;";
                var valorDeVariables = new
                {
                    fkIdDeporte = modelo.fkIdDeporte
                };
                sqlresultado = conexionODBC.Query<modeloEquipo>(sqlconsulta, valorDeVariables).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }

    }
}