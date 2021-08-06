using Dapper;
using Conexion;
using Modelo;
using System.Data.Odbc;
using System.Linq;
using System.Collections.Generic;

namespace Controlador
{
    public class controladorCampeonato
    {
        private ConexionODBC ODBC = new ConexionODBC();

        public modeloCampeonato AgregarCampeonato(modeloCampeonato modelo)
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

        public modeloCampeonato ModificarCampeonato(modeloCampeonato modelo)
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

        public modeloCampeonato eliminarCampeonato(modeloCampeonato modelo)
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

        public List<modeloCampeonato> mostrarCampeonato()
        {
            List<modeloCampeonato> sqlresultado = new List<modeloCampeonato>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM campeonato;";
                sqlresultado = conexionODBC.Query<modeloCampeonato>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}