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
                "INSERT INTO equipo (pkId, nombre, contraseña, telefono, tipo) " +
                "VALUES (NULL, ?nombre?, ?contraseña?, ?telefono?, ?fkIdtipo?);";
                var ValorDeVariables = new
                {
                    pkId = modelo.pkId,
                    nombre = modelo.nombre,
                    contraseña = modelo.contraseña,
                    telefono = modelo.telefono,
                    fkIdTipo = modelo.fkIdTipo,
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }
        public List<dtoUsuario> mostrarUsuarioyContraseña()
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