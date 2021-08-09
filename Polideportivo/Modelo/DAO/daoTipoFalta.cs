using Dapper;
using Conexion;
using Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

using Modelo.DTO;

namespace Modelo.DAO
{
    public class daoTipoFalta
    {
        private ConexionODBC ODBC = new ConexionODBC();

        public dtoTipoFalta agregarTipoFalta(dtoTipoFalta modelo)
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

        public dtoTipoFalta modificarTipoFalta(dtoTipoFalta modelo)
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

        public dtoTipoFalta eliminarTipoFalta(dtoTipoFalta modelo)
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

        public List<dtoTipoFalta> mostrarTipoFalta()
        {
            List<dtoTipoFalta> sqlresultado = new List<dtoTipoFalta>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tipofalta;";
                sqlresultado = conexionODBC.Query<dtoTipoFalta>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}