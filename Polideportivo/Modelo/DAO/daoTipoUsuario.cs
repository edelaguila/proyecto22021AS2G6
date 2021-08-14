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
        /// <summary>
        /// Método que sirve para mostrar los tipos de usuario 
        /// </summary>
        /// <returns>Retorna la consulta a la base de datos que son los tipos de usuario de la tablaTipoUsuario</returns>
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