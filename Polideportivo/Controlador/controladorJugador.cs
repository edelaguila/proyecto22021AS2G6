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
    class controladorJugador
    {
        OdbcConnection pruebas = new OdbcConnection("DSN=bdpolideportivo");
        public modeloJugador agregarJugador(modeloJugador modelo)
        {
            
            var sqlinsertar = 
                "INSERT INTO jugador (pkId, nombre, anotaciones, fkIdEquipo, fkIdRol) " +
                "VALUES (NULL, ?nombre?, ?anotaciones?, ?fkIdEquipo?, ?fkIdRol?);";
            var parameters = new{ nombre = modelo.nombre, anotaciones = modelo.anotaciones,
            fkIdEquipo = modelo.fkIdEquipo, fkIdRol = modelo.fkIdRol};
            var resultadoinsertar = pruebas.Execute(sqlinsertar, parameters);

            //var resultadoinsertar = pruebas.Execute(sqlinsertar);
            //var resultadoinsertar = pruebas.Execute(sqlinsertar,
            //        new
            //        {
            //            nombre = "Gaucho"
            //        });

            pruebas.Close();

            //modelo.id = 5;
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

        public modeloJugador modificarJugador(modeloJugador modelo)
        {
            var sqlmodificar =
                "UPDATE jugador SET nombre = ?nombre?, anotaciones = ?anotaciones?," +
                " fkIdEquipo = ?fkIdEquipo?, fkIdRol = ?fkIdRol? " +
                "WHERE pkId = ?pkId?;";
            var parameters = new
            {
                nombre = modelo.nombre,
                anotaciones = modelo.anotaciones,
                fkIdEquipo = modelo.fkIdEquipo,
                fkIdRol = modelo.fkIdRol
            };
            var resultadomodificar = pruebas.Execute(sqlmodificar, parameters);

            pruebas.Close();

            //modelo.id = 5;
            return modelo;
        }

    }
}
