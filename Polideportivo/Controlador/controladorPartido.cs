using Dapper;
using Polideportivo.Conexion;
using Polideportivo.Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

namespace Polideportivo.AccesoDatos
{
    internal class controladorPartido
    {
        private ConexionODBC ODBC = new ConexionODBC();

        public modeloPartido agregarPartido(modeloPartido modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO jugador (pkId, equipo1, equipo2, campo, fecha, fase, fkIdCampeonato, " +
                "fkIdEmpleado, fkIdResultado, fkIdEstado) " +
                "VALUES (NULL, ?equipo1?, ?equipo2?, ?campo?, ?fecha?, ?fase?, ?fkIdCampeonato?, " +
                "?fkIdEmpleado?, ?fkIdResultado?, ?fkIdEstado?);";
                var ValorDeVariables = new
                {
                    equipo1 = modelo.equipo1,
                    equipo2 = modelo.equipo2,
                    campo = modelo.campo,
                    fecha = modelo.fecha,
                    fase = modelo.fase,
                    fkIdCampeonato = modelo.fkIdCampeonato,
                    fkIdEmpleado = modelo.fkIdEmpleado,
                    fkIdResultado = modelo.fkIdResultado,
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
                "campo = ?campo?, fecha = ?fecha?, estado = ?estado? " +
                "fase = ?fase?, fkIdCampeonato = ?fkIdCampeonato?, fkIdEmpleado = ?fkIdEmpleado? " +
                "fkIdResultado = ?fkIdResultado?, " + "fkIdEstado = ?fkIdEstado?, " +
                "WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    equipo1 = modelo.equipo1,
                    equipo2 = modelo.equipo2,
                    campo = modelo.campo,
                    fecha = modelo.fecha,
                    estado = modelo.estado,
                    fase = modelo.fase,
                    fkIdCampeonato = modelo.fkIdCampeonato,
                    fkIdEmpleado = modelo.fkIdEmpleado,
                    fkIdResultado = modelo.fkIdResultado,
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