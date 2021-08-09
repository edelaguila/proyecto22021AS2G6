using Dapper;
using Conexion;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using Modelo.DTO;

namespace Modelo.DAO
{
    public class daoEmpleado
    {
        private ConexionODBC ODBC = new ConexionODBC();

        public dtoEmpleado agregarEmpleado(dtoEmpleado modelo)
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
                    fkIdPuestoEmpleado = modelo.fkIdPuestoEmpleado,
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public dtoEmpleado modificarEmpleado(dtoEmpleado modelo)
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

        public dtoEmpleado eliminarEmpleado(dtoEmpleado modelo)
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

        public List<dtoEmpleado> mostrarEmpleado()
        {
            List<dtoEmpleado> sqlresultado = new List<dtoEmpleado>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM empleado;";
                sqlresultado = conexionODBC.Query<dtoEmpleado>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}