using Dapper;
using Conexion;
using Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

namespace Controlador
{
    public class controladorPuesto
    {
        private ConexionODBC ODBC = new ConexionODBC();

        public List<modeloPuesto> mostrarPuesto()
        {
            List<modeloPuesto> sqlresultado = new List<modeloPuesto>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM puestoempleado;";
                sqlresultado = conexionODBC.Query<modeloPuesto>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }

            return sqlresultado;
        }
    }
}