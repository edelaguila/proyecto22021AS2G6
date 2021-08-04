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
    class controladorEntrenador
    {
        OdbcConnection pruebas = new OdbcConnection("DSN=bdpolideportivo");

        public modeloEntrenador agregarEntrenador(modeloEntrenador modelo)
        {
            pruebas.Open();
            var sqlinsertar =
                "INSERT INTO deporte (pkId, nombre, fkIdEquipo,) " +
                "VALUES (NULL, ?nombre?, ?fkIdEquipo?);";
            var ValorDeVariables = new
            {
                nombre = modelo.nombre,
                fkIdEquipo = modelo.fkIdEquipo,

            };
            var resultadoinsertar = pruebas.Execute(sqlinsertar, ValorDeVariables);
            pruebas.Close();
            return modelo;
        }

        public modeloEntrenador modificarEntrenador(modeloEntrenador modelo)
        {
            pruebas.Open();
            var sqlinsertar =
                "UPDATE deporte SET nombre = ?nombre? " +
                "fkIdEquipo = ?fkIdEquipo? " +
                "WHERE pkId = ?pkId?;";
            var ValorDeVariables = new
            {
                nombre = modelo.nombre,
                fkIdEquipo = modelo.fkIdEquipo,
                pkId = modelo.pkId
            };
            var resultadoinsertar = pruebas.Execute(sqlinsertar, ValorDeVariables);
            pruebas.Close();
            return modelo;
        }

        public modeloEntrenador eliminarEntrenador(modeloEntrenador modelo)
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