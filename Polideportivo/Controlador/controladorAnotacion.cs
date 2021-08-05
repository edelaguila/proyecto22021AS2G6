using Dapper;
using Polideportivo.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polideportivo.Controlador
{
    class controladorAnotacion
    {
        OdbcConnection pruebas = new OdbcConnection("DSN=bdpolideportivo");

        public modeloAnotacion agregarAnotacion(modeloAnotacion modelo)
        {
            pruebas.Open();
            var sqlinsertar =
                "INSERT INTO anotacion (pkId, cantidad, fkIdJugador, fkIdPartido) " +
                "VALUES (NULL, ?cantidad?, ?fkIdJugador?, ?fkIdPartido?);";
            var ValorDeVariables = new
            {
                cantidad = modelo.cantidad,
                fkIdJugador = modelo.fkIdJugador,
                fkIdPartido = modelo.fkIdPartido


            };
            var resultadoinsertar = pruebas.Execute(sqlinsertar, ValorDeVariables);
            pruebas.Close();
            return modelo;
        }

        public modeloAnotacion modificarAnotacion(modeloAnotacion modelo)
        {
            pruebas.Open();
            var sqlinsertar =
                "UPDATE anotacion SET cantidad = ?cantidad? ," +
                "fkIdJugador = ?fkIdJugador?, fkIdPartido = ?fkIdPartido?, " +
                "WHERE pkId = ?pkId?;";
            var ValorDeVariables = new
            {
                cantidad = modelo.cantidad,
                fkIdJugador = modelo.fkIdJugador,
                fkIdPartido = modelo.fkIdPartido,
                pkId = modelo.pkId
            };
            var resultadoinsertar = pruebas.Execute(sqlinsertar, ValorDeVariables);
            pruebas.Close();
            return modelo;
        }

        public modeloAnotacion eliminarAnotacion(modeloAnotacion modelo)
        {

            var sqlinsertar =
                "DELETE FROM entrenador WHERE pkId = ?pkId?;";

            var ValorDeVariables = new
            {
                pkId = modelo.pkId
            };
            var resultadoinsertar = pruebas.Execute(sqlinsertar, ValorDeVariables);
            pruebas.Close();
            return modelo;
        }


        public List<modeloEntrenador> mostrarEntrenador()
        {
            pruebas.Open();
            //string sqlconsulta = "SELECT pkId, nombre, fkIdDeporte FROM rol WHERE fkIdDeporte = 1;";
            string sqlconsulta = "SELECT * FROM entrenador;";
            var sqlresultado = pruebas.Query<modeloEntrenador>(sqlconsulta).ToList();
            pruebas.Close();
            return sqlresultado;
        }
    }
}