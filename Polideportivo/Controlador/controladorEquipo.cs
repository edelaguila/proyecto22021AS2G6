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
    class controladorEquipo
    {
        modeloEquipo modelo;

        public controladorEquipo()
        {


        }

        public controladorEquipo(modeloEquipo Modelo)
        {
            modelo = Modelo;
        }
        OdbcConnection conexionOdbc = new OdbcConnection("DSN=bdpolideportivo");

        public modeloEquipo agregarEquipo(modeloEquipo modelo)
        {

            var sqlinsertar =
                "INSERT INTO equipo (pkId, nombre, fkIdEntrenador, fkIdDeporte) " +
                "VALUES (NULL, ?nombre?, ?fkIdEntrenador?, ?fkIdDeporte?);";
            var ValorDeVariables = new
            {
                nombre = modelo.nombre,
                fkIdEntrenador = modelo.fkIdEntrenador,
                fkIdDeporte = modelo.fkIdDeporte
            };
            var resultadoinsertar = conexionOdbc.Execute(sqlinsertar, ValorDeVariables);


            conexionOdbc.Close();

            //modelo.id = 5;
            return modelo;
        }
        public modeloEquipo modificarEquipo(modeloEquipo modelo)
        {

            var sqlinsertar =
                "UPDATE jugador SET nombre = ?nombre?, anotaciones = ?anotaciones?, " +
                "fkIdEquipo = ?fkIdEquipo?, fkIdRol = ?fkIdRol?, fkIdDeporte = ?fkIdDeporte? " +
                "WHERE pkId = ?pkId?;";
            var ValorDeVariables = new
            {
                nombre = modelo.nombre,
                fkIdEntrenador = modelo.fkIdEntrenador,
                fkIdDeporte = modelo.fkIdDeporte,
                pkId = modelo.pkId
            };
            var resultadoinsertar = conexionOdbc.Execute(sqlinsertar, ValorDeVariables);
            conexionOdbc.Close();
            return modelo;
        }
        public IEnumerable<modeloEquipo> mostrarEquipos()
        {
            IEnumerable<modeloEquipo> modeloList = new List<modeloEquipo>();
            conexionOdbc.Open();
            string sqlconsulta = "SELECT * FROM tablajugadores;";
            var sqlresultado = conexionOdbc.Query<modeloEquipo>(sqlconsulta);
            modeloList = sqlresultado;
            conexionOdbc.Close();
            return modeloList;
        }

        public List<modeloEquipo> mostrarEquipoPorDeporte()
        {
            conexionOdbc.Open();
            string sqlconsulta = "SELECT pkId, nombre, fkIdDeporte FROM equipo WHERE fkIdDeporte = ?fkIdDeporte?;";
            var valorDeVariables = new
            {
                fkIdDeporte = modelo.fkIdDeporte
            };
            List<modeloEquipo> sqlresultado = conexionOdbc.Query<modeloEquipo>(sqlconsulta, valorDeVariables).ToList();
            conexionOdbc.Close();
            return sqlresultado;
        }

    }
}