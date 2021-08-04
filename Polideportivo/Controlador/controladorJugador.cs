using Polideportivo.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.Odbc;
using System.Data;
using static Polideportivo.Vista.utilidadForms;
using Polideportivo.Vista;
using Polideportivo.Conexion;

namespace Polideportivo.AccesoDatos
{
    class controladorJugador
    {
        ConexionODBC ODBC = new ConexionODBC();
        public modeloJugador agregarJugador(modeloJugador modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO jugador (pkId, nombre, anotaciones, fkIdEquipo, fkIdRol) " +
                "VALUES (NULL, ?nombre?, ?anotaciones?, ?fkIdEquipo?, ?fkIdRol?);";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre,
                    anotaciones = modelo.anotaciones,
                    fkIdEquipo = modelo.fkIdEquipo,
                    fkIdRol = modelo.fkIdRol
                };
                var resultadoinsertar = conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }




            //modelo.id = 5;
            return modelo;
        }

        public modeloJugador modificarJugador(modeloJugador modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE jugador SET nombre = ?nombre?, anotaciones = ?anotaciones?, " +
                "fkIdEquipo = ?fkIdEquipo?, fkIdRol = ?fkIdRol?" +
                " WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre,
                    anotaciones = modelo.anotaciones,
                    fkIdEquipo = modelo.fkIdEquipo,
                    fkIdRol = modelo.fkIdRol,
                    pkId = modelo.pkId
                };
                var resultadoinsertar = conexionODBC.Execute(sqlinsertar, ValorDeVariables);
            }


            ODBC.cerrarConexion(conexionODBC);

            return modelo;
        }

        public IEnumerable<modeloJugador> mostrarJugadores()
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            IEnumerable<modeloJugador> modeloList = new List<modeloJugador>();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tablajugadores;";
                var sqlresultado = conexionODBC.Query<modeloJugador>(sqlconsulta);
                modeloList = sqlresultado;
                ODBC.cerrarConexion(conexionODBC);
            }
            return modeloList;
        }


        public IEnumerable<modeloJugador> mostrarJugadoresPorDeporte()
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            IEnumerable<modeloJugador> modeloList = new List<modeloJugador>();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tablajugadores;";
                var sqlresultado = conexionODBC.Query<modeloJugador>(sqlconsulta);
                modeloList = sqlresultado;
                ODBC.cerrarConexion(conexionODBC);
            }
            return modeloList;
        }

        public modeloJugador eliminarJugador(modeloJugador modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM jugador WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    pkId = modelo.pkId
                };
                var resultadoinsertar = conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }



    }
}
