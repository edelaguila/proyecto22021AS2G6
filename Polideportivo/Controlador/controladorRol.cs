using Dapper;
using Conexion;
using Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

namespace Controlador
{
    public class controladorRol
    {
        private ConexionODBC ConexionODBC = new ConexionODBC();
        public controladorRol()
        {
        }


        public modeloRol agregarRol(modeloRol modelo)
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

        public modeloRol modificarRol(modeloRol modelo)
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
       
        public List<modeloRol> mostrarRoles()
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            List<modeloRol> sqlresultado = new List<modeloRol>();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tablaRol;";
                sqlresultado = conexionODBC.Query<modeloRol>(sqlconsulta).ToList();
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }

        public modeloRol eliminarRol(modeloRol modelo)
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


 
        public List<modeloRol> mostrarRolesPorDeporte(modeloRol modelo)
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            List<modeloRol> sqlresultado = new List<modeloRol>();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT pkId, nombre, fkIdDeporte FROM rol WHERE fkIdDeporte = ?fkIdDeporte?;";
                var parameters = new
                {
                    fkIdDeporte = modelo.fkIdDeporte
                };
                sqlresultado = conexionODBC.Query<modeloRol>(sqlconsulta, parameters).ToList();
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}