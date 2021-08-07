using Dapper;
using Conexion;
using Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

namespace Controlador
{
    public class controladorPartido
    {
        private ConexionODBC ODBC = new ConexionODBC();

        public modeloPartido agregarPartido(modeloPartido modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO partido (pkId, equipo1, equipo2,anotacionesEquipo1, anotacionesEquipo2, campo, fecha, fase, fkIdCampeonato, " +
                "fkIdEmpleado, fkIdEstado) " +
                "VALUES (NULL, ?equipo1?, ?equipo2?,  ?anotacionesEquipo1?, ?anotacionesEquipo2?,?campo?, ?fecha?, ?fase?, ?fkIdCampeonato?, " +
                "?fkIdEmpleado?, ?fkIdEstado?);";
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
                    fkIdEstado = modelo.fkIdEstado
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public modeloPartido modificarPartido(modeloPartido modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE partido SET equipo1 = ?equipo1?, equipo2 = ?equipo2?, " +
                "campo = ?campo?, fecha = ?fecha? " +
                "fase = ?fase?, fkIdCampeonato = ?fkIdCampeonato?, fkIdEmpleado = ?fkIdEmpleado? " +
                "anotacionesEquipo1 = ?anotacionesEquipo1?,  " + "anotacionesEquipo2 = ?anotacionesEquipo2?,  " + "fkIdEstado = ?fkIdEstado?, " +
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
                    fkIdEstado = modelo.fkIdEstado,
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public List<modeloPartido> mostrarPartidos()
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            List<modeloPartido> sqlresultado = new List<modeloPartido>();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tablapartidos;";
                sqlresultado = conexionODBC.Query<modeloPartido>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }

        public modeloPartido eliminarPartido(modeloPartido modelo)
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