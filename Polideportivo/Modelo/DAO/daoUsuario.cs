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
                "INSERT INTO equipo (pkId, nombre, fkIdDeporte) " +
                "VALUES (NULL, ?nombre?, ?fkIdDeporte?);";
                var ValorDeVariables = new
                {
                    pkId = modelo.pkId,
                    nombre = modelo.nombre,
                    contraseña = modelo.contraseña,
                    telefono = modelo.telefono,
                    tipo = modelo.tipo,
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }
    }
}