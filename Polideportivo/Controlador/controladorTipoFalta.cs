using Dapper;
using Conexion;
using Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

namespace Controlador
{
    public class controladorTipoFalta
    {
        private ConexionODBC ODBC = new ConexionODBC();

        public modeloTipoFalta agregarTipoFalta(modeloTipoFalta modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO tipofalta (pkId, tipo, fkIdDeporte) " +
                "VALUES (NULL, ?tipo?, ?fkIdDeporte?);";
                var ValorDeVariables = new
                {
                    tipo = modelo.tipo,
                    fkIdDeporte = modelo.fkIdDeporte,
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public modeloTipoFalta modificarTipoFalta(modeloTipoFalta modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE tipofalta SET tipo = ?tipo?," +
                "fkIdDeporte = ?fkIdDeporte? " +
                "WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    tipo = modelo.tipo,
                    fkIdDeporte = modelo.fkIdDeporte,
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public modeloTipoFalta eliminarTipoFalta(modeloTipoFalta modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM tipofalta WHERE pkId = ?pkId?;";

                var ValorDeVariables = new
                {
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public List<modeloTipoFalta> mostrarTipoFalta()
        {
            List<modeloTipoFalta> sqlresultado = new List<modeloTipoFalta>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tipofalta;";
                sqlresultado = conexionODBC.Query<modeloTipoFalta>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}