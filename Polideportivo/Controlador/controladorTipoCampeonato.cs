using Dapper;
using Conexion;
using Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

namespace Controlador
{
    public class controladorTipoCampeonato
    {
        private ConexionODBC ODBC = new ConexionODBC();

        public List<modeloTipoCampeonato> mostrarTipoDeCampeonatos()
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            List<modeloTipoCampeonato> sqlresultado = new List<modeloTipoCampeonato>();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tipocampeonato;";
                sqlresultado = conexionODBC.Query<modeloTipoCampeonato>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}