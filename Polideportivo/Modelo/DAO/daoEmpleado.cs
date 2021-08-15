using Dapper;
using Conexion;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using Modelo.DTO;

namespace Modelo.DAO
{
    /// <summary>
    /// Clase utilizada para agregar, modificar, eliminar o mostrar los campos de empleados en la base de datos.
    /// </summary>
    public class daoEmpleado
    {
        private ConexionODBC ODBC = new ConexionODBC();

        /// <summary>
        /// Método que sirve para agregar nuevos empleados a la base de datos
        /// </summary>
        /// <param name="modelo">Recibe el modelo de empleado que se desea ingresar</param>
        /// <returns>Retorna el empleado ingresado para ser agregado a la tabla</returns>
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

        /// <summary>
        /// Método que sirve para modificar empleados
        /// </summary>
        /// <param name="modelo">Recibe el modelo del empleado para poder modificarlo </param>
        /// <returns>Retorna el empleado modificado para ser modificado en la tabla</returns>
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

        /// <summary>
        /// Metodo que sirve para eliminar el empleado seleccionado de la base de datos 
        /// </summary>
        /// <param name="modelo">Recibe el modelo del empleado seleccioado</param>
        /// <returns>Retorna el modelo del empleado seleccionado para eliminarlo</returns>
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

        /// <summary>
        /// Metodo que sirve para mostrar los empleados
        /// </summary>
        /// <returns>Retorna la consulta de la base de datos que son los empleados de la tablaEmpleados</returns>
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