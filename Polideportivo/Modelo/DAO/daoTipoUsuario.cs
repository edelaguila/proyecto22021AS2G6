using Dapper;
using Conexion;
using Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using Modelo.DTO;
using Modelo.DTO;

namespace Controlador
{
    public class daoTipoUsuario
    {
        private ConexionODBC ODBC = new ConexionODBC();

        public List<dtoTipoUsuario> mostrarTipoUsuario()
        {
            List<dtoTipoUsuario> sqlresultado = new List<dtoTipoUsuario>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tipousuario;";
                sqlresultado = conexionODBC.Query<dtoTipoUsuario>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }

            return sqlresultado;
        }
    }
}