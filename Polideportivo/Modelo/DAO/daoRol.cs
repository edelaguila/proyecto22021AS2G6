using Dapper;
using Conexion;
using Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using Modelo.DTO;

namespace Modelo.DAO
{
    public class daoRol
    {
        private ConexionODBC ConexionODBC = new ConexionODBC();

        public daoRol()
        {
        }

        public dtoRol agregarRol(dtoRol modelo)
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
               "INSERT INTO rol (nombre, fkIdDeporte) " +
               "VALUES (?nombre?, ?fkIdDeporte?);";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre,
                    fkIdDeporte = modelo.fkIdDeporte
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public dtoRol modificarRol(dtoRol modelo)
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE rol SET nombre = ?nombre?, " +
                "fkIdDeporte = ?fkIdDeporte?" +
                " WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre,
                    fkIdDeporte = modelo.fkIdDeporte,
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public List<dtoRol> mostrarRoles()
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            List<dtoRol> sqlresultado = new List<dtoRol>();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tablaRol;";
                sqlresultado = conexionODBC.Query<dtoRol>(sqlconsulta).ToList();
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }

        public dtoRol eliminarRol(dtoRol modelo)
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM rol WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public List<dtoRol> mostrarRolesPorDeporte(dtoRol modelo)
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            List<dtoRol> sqlresultado = new List<dtoRol>();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT pkId, nombre, fkIdDeporte FROM rol WHERE fkIdDeporte = ?fkIdDeporte?;";
                var parameters = new
                {
                    fkIdDeporte = modelo.fkIdDeporte
                };
                sqlresultado = conexionODBC.Query<dtoRol>(sqlconsulta, parameters).ToList();
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}