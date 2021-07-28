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
            pruebas.Open();
            OdbcCommand sql = pruebas.CreateCommand();
            sql.CommandText = "INSERT INTO tabladeporte (id, nombre) VALUES (NULL, ?);";
            sql.Parameters.Add("@n", OdbcType.VarChar).Value = "Gaucho";

            sql.ExecuteNonQuery();
            sql.Dispose();
            pruebas.Close();


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
