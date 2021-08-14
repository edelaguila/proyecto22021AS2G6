using Dapper;
using Conexion;
using Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using Modelo.DTO;

namespace Controlador
{
    /// <summary>
    /// Clase utilizada para agregar, modificar, eliminar o mostrar los campos de puestos en la base de datos.
    /// </summary>
    public class daoPuesto
    {
        private ConexionODBC ODBC = new ConexionODBC();
        /// <summary>
        /// Metodo que sirve para mostrar el puesto que tiene cada uno de los empleados
        /// </summary>
        /// <returns>Retorna los puestos existentes en la tablaPuesto</returns>
        public List<dtoPuesto> mostrarPuesto()
        {
            List<dtoPuesto> sqlresultado = new List<dtoPuesto>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM puestoempleado;";
                sqlresultado = conexionODBC.Query<dtoPuesto>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }

            return sqlresultado;
        }
    }
}