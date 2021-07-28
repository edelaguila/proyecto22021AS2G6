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
        
        
        //Falta hacer que de verdad guarde en la base de datos
        /// <summary>
        /// Guarda un nuevo equipo a la base de datos
        /// </summary>
        /// <param name="modelo">La información del equipo</param>
        /// <returns>La información del equipo incluyendo el Id</returns>
        public modeloJugador agregarJugador(modeloJugador modelo)
        {
            OdbcConnection pruebas = new OdbcConnection("DSN=prueba");
            var sqlinsertar = "INSERT INTO tabladeporte (id, nombre) VALUES (NULL, ?g?);";
            var resultadoinsertar = pruebas.Execute(sqlinsertar,
                    new
                    {
                        g = "Gaucho"
                    });



            modelo.id = 5;
            return modelo;
        }

        public IEnumerable<modeloJugador> mostrarJugadores()
        {
            IEnumerable<modeloJugador> modeloList = new List<modeloJugador>();

            OdbcConnection pruebas = new OdbcConnection("DSN=prueba");
            pruebas.Open();
            string sqlconsulta = "SELECT * FROM tablajugadores;";
            var sqlresultado = pruebas.Query<modeloJugador>(sqlconsulta);
            modeloList = sqlresultado;
            pruebas.Close();
            return modeloList;
        }
    }
}
