using Conexion;
using Dapper;
using Modelo.DTO;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

namespace Modelo.DAO
{
    class daoFase
    {
       
            private ConexionODBC ODBC = new ConexionODBC();

            public dtoFase agregarFase(dtoFase modelo)
            {
                OdbcConnection conexionODBC = ODBC.abrirConexion();
                if (conexionODBC != null)
                {
                    var sqlinsertar =
                    "INSERT INTO fase (pkId, nombre) " +
                    "VALUES (NULL, ?nombre?);";
                    var ValorDeVariables = new
                    {
                        nombre = modelo.nombre
                    };
                    conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                    ODBC.cerrarConexion(conexionODBC);
                    return modelo;
                }
                return null;
            }

            public dtoFase modificarFase(dtoFase modelo)
            {
                OdbcConnection conexionODBC = ODBC.abrirConexion();
                if (conexionODBC != null)
                {
                    var sqlinsertar =
                    "UPDATE fase SET nombre = ?nombre? " +
                    "WHERE pkId = ?pkId?;";
                    var ValorDeVariables = new
                    {
                        nombre = modelo.nombre,
                        pkId = modelo.pkId
                    };
                    conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                    ODBC.cerrarConexion(conexionODBC);
                    return modelo;
                }
                return null;
            }

            public dtoFase eliminarFase(dtoFase modelo)
            {
                OdbcConnection conexionODBC = ODBC.abrirConexion();
                if (conexionODBC != null)
                {
                    var sqlinsertar =
                    "DELETE FROM fase WHERE pkId = ?pkId?;";

                    var ValorDeVariables = new
                    {
                        pkId = modelo.pkId
                    };
                    conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                    ODBC.cerrarConexion(conexionODBC);
                    return modelo;
                }
                return null;
            }

            public List<dtoFase> mostrarFase()
            {
                List<dtoFase> sqlresultado = new List<dtoFase>();
                OdbcConnection conexionODBC = ODBC.abrirConexion();
                if (conexionODBC != null)
                {
                    string sqlconsulta = "SELECT * FROM fase;";
                    sqlresultado = conexionODBC.Query<dtoFase>(sqlconsulta).ToList();
                    ODBC.cerrarConexion(conexionODBC);
                    return sqlresultado;
                }
                return null;
            }



        
    }
}