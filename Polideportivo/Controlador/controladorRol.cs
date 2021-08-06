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
    class controladorRol
    {
        OdbcConnection pruebas = new OdbcConnection("DSN=bdpolideportivo");

        modeloRol modelo;


        public modeloRol agregarRol(modeloRol modelo)
        {
            pruebas.Open();

            var sqlinsertar =
               "INSERT INTO equipo (nombre, fkIdDeporte) " +
               "VALUES (?nombre?, ?fkIdDeporte?);";
            var ValorDeVariables = new
            {
                nombre = modelo.nombre,
                fkIdDeporte = modelo.fkIdDeporte
            };
            var resultadoinsertar = pruebas.Execute(sqlinsertar, ValorDeVariables);
            pruebas.Close();
            return modelo;
        }

        public controladorRol()
        {

        }
        public controladorRol(modeloRol Modelo)
        {
            modelo = Modelo;
        }

        public List<modeloRol> mostrarRolesPorDeporte()
        {
            pruebas.Open();
            //string sqlconsulta = "SELECT pkId, nombre, fkIdDeporte FROM rol WHERE fkIdDeporte = 1;";
            string sqlconsulta = "SELECT pkId, nombre, fkIdDeporte FROM rol WHERE fkIdDeporte = ?fkIdDeporte?;";
            var parameters = new
            {
                fkIdDeporte = modelo.fkIdDeporte
            };
            var sqlresultado = pruebas.Query<modeloRol>(sqlconsulta, parameters).ToList();
            pruebas.Close();
            return sqlresultado;
        }




    }
}