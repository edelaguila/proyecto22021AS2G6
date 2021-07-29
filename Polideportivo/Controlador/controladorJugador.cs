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
            pruebas.Open();
            string nombre = modelo.nombre;
            int anotaciones = modelo.anotaciones;
            int fkIdEquipo = modelo.fkIdEquipo;
            int fkIdRol = modelo.fkIdRol;
            var sqlinsertar = 
                "INSERT INTO tabladeporte (pkId, nombre, anotaciones, fkIdEquipo, fkIdRol) " +
                "VALUES (NULL, ?nombre?, ?anotaciones?, ?fkIdEquipo?, ?fkIdRol?);";
            var resultadoinsertar = pruebas.Execute(sqlinsertar);
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

        public modeloJugador modificarJugador(modeloJugador modelo)
        {
            pruebas.Open();
            var sqlinsertar = "INSERT INTO tabladeporte (id, nombre) VALUES (NULL, ?g?);";
            var resultadoinsertar = pruebas.Execute(sqlinsertar,
                    new
                    {
                        g = "Gaucho"
                    });
            pruebas.Close();

            modelo.id = 5;
            return modelo;
        }

    }
}
