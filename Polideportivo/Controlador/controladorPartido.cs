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
    class controladorPartido
    {
        OdbcConnection pruebas = new OdbcConnection("DSN=bdpolideportivo");
        public modeloPartido agregarPartido(modeloPartido modelo)
        {

            var sqlinsertar =
                "INSERT INTO jugador (pkId, equipo1, equipo2, campo, fecha, estado, fase, fkIdCampeonato, fkIdEmpleado, fkIdResultado) " +
                "VALUES (NULL, ?equipo1?, ?equipo2?, ?campo?, ?fecha?, ?estado?, ?fase?, ?fkIdCampeonato?, ?fkIdEmpleado?, ?fkIdResultado?);";
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
                fkIdResultado = modelo.fkIdResultado
            };
            var resultadoinsertar = pruebas.Execute(sqlinsertar, ValorDeVariables);


            pruebas.Close();

            //modelo.id = 5;
            return modelo;
        }

        public modeloPartido modificarPartido(modeloPartido modelo)
        {

            var sqlinsertar =
                "UPDATE partido SET equipo1 = ?equipo1?, equipo2 = ?equipo2?, " +
                "campo = ?campo?, fecha = ?fecha?, estado = ?estado? " +
                "fase = ?fase?, fkIdCampeonato = ?fkIdCampeonato?, fkIdEmpleado = ?fkIdEmpleado? " +
                "fkIdResultado = ?fkIdResultado?, " +
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
                pkId = modelo.pkId
            };
            var resultadoinsertar = pruebas.Execute(sqlinsertar, ValorDeVariables);
            pruebas.Close();
            return modelo;
        }

        public IEnumerable<modeloPartido> mostrarPartidos()
        {
            IEnumerable<modeloPartido> modeloList = new List<modeloPartido>();
            pruebas.Open();
            string sqlconsulta = "SELECT * FROM tablapartidos;";
            var sqlresultado = pruebas.Query<modeloPartido>(sqlconsulta);
            modeloList = sqlresultado;
            pruebas.Close();
            return modeloList;
        }



        //public IEnumerable<modeloPartido> mostrarJugadoresPorDeporte()
        //{
        //    IEnumerable<modeloJugador> modeloList = new List<modeloJugador>();
        //    pruebas.Open();
        //    string sqlconsulta = "SELECT * FROM tablajugadores;";
        //    var sqlresultado = pruebas.Query<modeloJugador>(sqlconsulta);
        //    modeloList = sqlresultado;
        //    pruebas.Close();
        //   return modeloList;
        //}

        public modeloPartido eliminarPartido(modeloPartido modelo)
        {

            var sqlinsertar =
                "DELETE FROM partido WHERE pkId = ?pkId?;";
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
