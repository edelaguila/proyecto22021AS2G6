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
    class controladorEmpleado
    {
        ConexionODBC ODBC = new ConexionODBC();

        public modeloEmpleado agregarEmpleado(modeloEmpleado modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO empleado (pkId, nombre, fkIdPuestoEmpleado) " +
                "VALUES (NULL, ?nombre?, ?fkIdPuestoEmpleado?);";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre,
                    fkIdPuestoEmpleado= modelo.fkIdPuestoEmpleado,

                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public modeloEmpleado modificarEmpleado(modeloEmpleado modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE empleado SET nombre = ?nombre?," +
                "fkIdPuestoEmpleado = ?fkIdPuestoEmpleado? " +
                "WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre,
                    fkIdPuestoEmpleado = modelo.fkIdPuestoEmpleado,
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public modeloEmpleado eliminarEmpleado(modeloEmpleado modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM empleado WHERE pkId = ?pkId?;";

                var ValorDeVariables = new
                {
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }


        public List<modeloEmpleado> mostrarEmpleado()
        {
            List<modeloEmpleado> sqlresultado = new List<modeloEmpleado>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM empleado;";
                sqlresultado = conexionODBC.Query<modeloEmpleado>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}