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
            var ValorDeVariables = new{ nombre = modelo.nombre, anotaciones = modelo.anotaciones,
            fkIdEquipo = modelo.fkIdEquipo, fkIdRol = modelo.fkIdRol};
            var resultadoinsertar = pruebas.Execute(sqlinsertar, ValorDeVariables);


            pruebas.Close();

            //modelo.id = 5;
            return modelo;
        }

        public modeloJugador modificarJugador(modeloJugador modelo)
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
