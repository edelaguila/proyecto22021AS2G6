using Conexion;
using Dapper;
using Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.DAO
{
    class daoPartido
    {
        private ConexionODBC ODBC = new ConexionODBC();

        public dtoPartido agregarPartido(dtoPartido modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO partido (pkId, equipo1, equipo2,anotacionesEquipo1, anotacionesEquipo2, campo, fecha, fase, fkIdCampeonato, " +
                "fkIdEmpleado, fkIdEstadoPartido) " +
                "VALUES (NULL, ?equipo1?, ?equipo2?,  ?anotacionesEquipo1?, ?anotacionesEquipo2?,?campo?, ?fecha?, ?fase?, ?fkIdCampeonato?, " +
                "?fkIdEmpleado?, ?fkIdEstadoPartido?);";
                var ValorDeVariables = new
                {
                    equipo1 = modelo.equipo1,
                    equipo2 = modelo.equipo2,
                    anotacionesEquipo1 = modelo.anotacionesEquipo1,
                    anotacionesEquipo2 = modelo.anotacionesEquipo2,
                    campo = modelo.campo,
                    fecha = modelo.fecha,
                    fase = modelo.fase,
                    fkIdCampeonato = modelo.fkIdCampeonato,
                    fkIdEmpleado = modelo.fkIdEmpleado,
                    fkIdEstadoPartido = modelo.fkIdEstadoPartido
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public dtoPartido modificarPartido(dtoPartido modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE partido SET equipo1 = ?equipo1?, equipo2 = ?equipo2?, " +
                "campo = ?campo?, fecha = ?fecha?, " +
                "fase = ?fase?, fkIdCampeonato = ?fkIdCampeonato?, fkIdEmpleado = ?fkIdEmpleado?, " +
                "anotacionesEquipo1 = ?anotacionesEquipo1?,  " + "anotacionesEquipo2 = ?anotacionesEquipo2?,  " + "fkIdEstadoPartido = ?fkIdEstadoPartido? " +
                "WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    equipo1 = modelo.equipo1,
                    equipo2 = modelo.equipo2,
                    campo = modelo.campo,
                    fecha = modelo.fecha,
                    fase = modelo.fase,
                    fkIdCampeonato = modelo.fkIdCampeonato,
                    fkIdEmpleado = modelo.fkIdEmpleado,
                    fkIdEstadoPartido = modelo.fkIdEstadoPartido,
                    anotacionesEquipo1 = modelo.anotacionesEquipo1,
                    anotacionesEquipo2 = modelo.anotacionesEquipo2,
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public List<dtoPartido> mostrarPartidos()
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            List<dtoPartido> sqlresultado = new List<dtoPartido>();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tablapartidos;";
                sqlresultado = conexionODBC.Query<dtoPartido>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }

        public dtoPartido eliminarPartido(dtoPartido modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM partido WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }
    }
}