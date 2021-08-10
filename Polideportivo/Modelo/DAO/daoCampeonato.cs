using Dapper;
using Conexion;
using System.Data.Odbc;
using System.Linq;
using System.Collections.Generic;
using Modelo.DTO;

namespace Modelo.DAO
{
    public class daoCampeonato
    {
        private ConexionODBC ODBC = new ConexionODBC();

        public dtoCampeonato AgregarCampeonato(dtoCampeonato modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO campeonato(pkId, nombre, fechaInicio, fechaFinal, fkIdDeporte, fkIdTipoCampeonato)" +
                " VALUES  (NULL, ?nombre?, ?fechaInicio?, ?fechaFinal?, ?fkIdDeporte?, " +
                "?fkIdTipoCampeonato?);";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre,
                    fechaInicio = modelo.fechaInicio,
                    fechaFinal = modelo.fechaFinal,
                    fkIdDeporte = modelo.fkIdDeporte,
                    fkIdTipoCampeonato = modelo.fkIdTipoCampeonato
                };

                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public dtoCampeonato ModificarCampeonato(dtoCampeonato modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE campeonato SET nombre = ?nombre?, fechaInicio = ?fechaInicio?, " +
                "fechaFinal = ?fechaFinal?, fkIdDeporte = ?fkIdDeporte?, fkIdTipoCampeonato = ?fkIdTipoCampeonato?" +
                " WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    pkId = modelo.pkId,
                    nombre = modelo.nombre,
                    fechaInicio = modelo.fechaInicio,
                    fechaFinal = modelo.fechaFinal,
                    fkIdDeporte = modelo.fkIdDeporte,
                    fkIdTipoCampeonato = modelo.fkIdTipoCampeonato
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }

            return modelo;
        }

        public dtoCampeonato eliminarCampeonato(dtoCampeonato modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM campeonato WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }

            return modelo;
        }

        public List<dtoCampeonato> mostrarCampeonato()
        {
            List<dtoCampeonato> sqlresultado = new List<dtoCampeonato>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM campeonato;";
                sqlresultado = conexionODBC.Query<dtoCampeonato>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}