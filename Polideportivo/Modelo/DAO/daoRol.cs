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
        /// <summary>
        /// Método que sirve para agregar nuevos roles a la base de datos
        /// </summary>
        /// <param name="modelo">Recibe el modelo de rol que se desea ingresar</param>
        /// <returns>Retorna el rol ingresado para ser agregado a la tabla</returns>
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
        /// <summary>
        /// Método que sirve para modificar roles
        /// </summary>
        /// <param name="modelo">Recibe el modelo de rol para poder modificarlo</param>
        /// <returns>Retorna el rol modificado para ser modificado en la tabla</returns>
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
        /// <summary>
        /// Metodo que sirve para mostrar los roles
        /// </summary>
        /// <returns>Retorna la consulta a la base de datos que son los roles de la tablaRoles</returns>
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
        /// <summary>
        /// Metodo que sirve para eliminar el rol seleccionado de la base de datos
        /// </summary>
        /// <param name="modelo">Recibe el modelo del rol seleccionado</param>
        /// <returns>Retorna el modelo del rol seleccionado para eliminarlo</returns>
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
        /// <summary>
        /// Metodo que sirve para mostrar los roles por el deporte que se seleccionó
        /// </summary>
        /// <returns>Retorna la consulta a la base de datos</returns>
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