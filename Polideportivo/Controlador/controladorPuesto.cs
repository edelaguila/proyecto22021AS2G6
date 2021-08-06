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
    class controladorPuesto
    {

        ConexionODBC ODBC = new ConexionODBC();

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