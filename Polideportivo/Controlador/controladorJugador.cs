using Polideportivo.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;


namespace Polideportivo.AccesoDatos
{
    class controladorJugador
    {
        string conexion = @"Server=localhost; Database=prueba1; Uid=root; Pwd=jm;";
        //Falta hacer que de verdad guarde en la base de datos
        /// <summary>
        /// Guarda un nuevo equipo a la base de datos
        /// </summary>
        /// <param name="modelo">La información del equipo</param>
        /// <returns>La información del equipo incluyendo el Id</returns>
        public modeloJugador agregarJugador(modeloJugador modelo)
        {
            using (var db = new MySqlConnection(conexion))
            {
                var sqlinsertar = "INSERT INTO tabladeporte (id, nombre) VALUES (NULL, @nombre);";
                var resultadoinsertar = db.Execute(sqlinsertar,
                    new
                    {
                        nombre = "PruebadesdeVisualStudio"
                    });
            }

            modelo.id = 1;
            return modelo;
        }

        public IEnumerable<modeloJugador> mostrarJugadores()
        {
            IEnumerable<modeloJugador> modeloList = new List<modeloJugador>();
            using (var db = new MySqlConnection(conexion))
            {
                var sqlconsulta = "SELECT * FROM tablajugadores;";
                var sqlresultado = db.Query<modeloJugador>(sqlconsulta);
                modeloList = sqlresultado;
            }
            return modeloList;
        }
    }
}
