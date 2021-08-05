using Dapper;
using Polideportivo.Conexion;
using Polideportivo.Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

namespace Polideportivo.Controlador
{
    class controladorTipoCampeonato
    {
        ConexionODBC ODBC = new ConexionODBC();
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
