using Polideportivo.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.Odbc;
using System.Data;

namespace Polideportivo.AccesoDatos
{
    class controladorPatido
    {
        OdbcConnection pruebas = new OdbcConnection("DSN=bdpolideportivo");
        public modeloJugador agregarJugador(modeloJugador modelo)
        {

            var sqlinsertar =
                "INSERT INTO jugador (pkId, equipo1, equipo2, campo, fecha, estado, fase, fkIdCampeonato, fkIdEmpleado, fkIdResultado) " +
                "VALUES (NULL, ?equipo1?, ?equipo2?, ?campo??fkId?, ?fkIdRol?, ?fkIdDeporte?);";
            var ValorDeVariables = new
            {
                nombre = modelo.nombre,
                anotaciones = modelo.anotaciones,
                fkIdEquipo = modelo.fkIdEquipo,
                fkIdRol = modelo.fkIdRol,
                fkIdDeporte = modelo.fkIdDeporte
            };
            var resultadoinsertar = pruebas.Execute(sqlinsertar, ValorDeVariables);


            pruebas.Close();

            //modelo.id = 5;
            return modelo;
        }

        public modeloJugador modificarJugador(modeloJugador modelo)
        {

            var sqlinsertar =
                "UPDATE jugador SET nombre = ?nombre?, anotaciones = ?anotaciones?, " +
                "fkIdEquipo = ?fkIdEquipo?, fkIdRol = ?fkIdRol?, fkIdDeporte = ?fkIdDeporte? " +
                "WHERE pkId = ?pkId?;";
            var ValorDeVariables = new
            {
                nombre = modelo.nombre,
                anotaciones = modelo.anotaciones,
                fkIdEquipo = modelo.fkIdEquipo,
                fkIdRol = modelo.fkIdRol,
                fkIdDeporte = modelo.fkIdDeporte,
                pkId = modelo.pkId
            };
            var resultadoinsertar = pruebas.Execute(sqlinsertar, ValorDeVariables);
            pruebas.Close();
            return modelo;
        }

        public IEnumerable<modeloJugador> mostrarJugadores()
        {
            IEnumerable<modeloJugador> modeloList = new List<modeloJugador>();
            pruebas.Open();
            string sqlconsulta = "SELECT * FROM tablajugadores;";
            var sqlresultado = pruebas.Query<modeloJugador>(sqlconsulta);
            modeloList = sqlresultado;
            pruebas.Close();
            return modeloList;
        }



        public IEnumerable<modeloJugador> mostrarJugadoresPorDeporte()
        {
            IEnumerable<modeloJugador> modeloList = new List<modeloJugador>();
            pruebas.Open();
            string sqlconsulta = "SELECT * FROM tablajugadores;";
            var sqlresultado = pruebas.Query<modeloJugador>(sqlconsulta);
            modeloList = sqlresultado;
            pruebas.Close();
            return modeloList;
        }

        public modeloJugador eliminarJugador(modeloJugador modelo)
        {

            var sqlinsertar =
                "DELETE FROM jugador WHERE pkId = ?pkId?;";
            var ValorDeVariables = new
            {
                pkId = modelo.pkId
            };
            var resultadoinsertar = pruebas.Execute(sqlinsertar, ValorDeVariables);
            pruebas.Close();
            return modelo;
        }



    }
}
