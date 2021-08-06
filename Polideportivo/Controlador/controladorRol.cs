using Dapper;
using Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

namespace Controlador
{
    public class controladorRol
    {
        private OdbcConnection pruebas = new OdbcConnection("DSN=bdpolideportivo");

        private modeloRol modelo;

        public modeloRol agregarRol(modeloRol modelo)
        {
            pruebas.Open();

            var sqlinsertar =
               "INSERT INTO rol (nombre, fkIdDeporte) " +
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