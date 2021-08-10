using Conexion;
using Dapper;
using Modelo;
using Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.DAO
{
    class daoUsuario
    {
        private ConexionODBC ODBC = new ConexionODBC();

        public dtoUsuario agregarUsuario(dtoUsuario modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO usuario (pkId, nombre, contraseña, telefono, fkIdTipoUsuario) " +
                "VALUES (NULL, ?nombre?, ?contraseña?, ?telefono?, ?fkIdTipoUsuario?);";
                var ValorDeVariables = new
                {
                    pkId = modelo.pkId,
                    nombre = modelo.nombre,
                    contraseña = modelo.contraseña,
                    telefono = modelo.telefono,
                    fkIdTipoUsuario = modelo.fkIdTipo
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        /// <summary>
        /// Función que valida usuarios con la base de datos
        /// </summary>
        /// <param name="modelo"></param>
        /// <returns></returns>
        public List<string> obtenerDatosDeUsuario(string usuario)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlconsulta =
                "SELECT contraseña FROM usuario WHERE nombre = ?nombre?;";
                var ValorDeVariables = new
                {
                    nombre = usuario,
                };
                var sqlresultado = conexionODBC.Query<string>(sqlconsulta, ValorDeVariables);
                if (sqlresultado.Count() > 0)
                {
                    ODBC.cerrarConexion(conexionODBC);
                    return sqlresultado.ToList();
                }
                ODBC.cerrarConexion(conexionODBC);
                return null;
            }
            return null;
        }

        public List<dtoUsuario> mostrarUsuario()
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            List<dtoUsuario> sqlresultado = new List<dtoUsuario>();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM usuario;";
                sqlresultado = conexionODBC.Query<dtoUsuario>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }

    }
}