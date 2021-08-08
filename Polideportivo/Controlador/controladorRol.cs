using Dapper;
using Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

namespace Controlador
{
    public class controladorRol
    {
        public OdbcConnection pruebas = new OdbcConnection("DSN=bdpolideportivo");

        public modeloRol modelo;

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

        public modeloRol modificarRol(modeloRol modelo)
        {
            pruebas.Open();
            {
                var sqlinsertar =
                "UPDATE jugador SET nombre = ?nombre?, " +
                "fkIdDeporte = ?fkIdDeporte?" +
                " WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    nombre = modelo.nombre,
                    fkIdDeporte = modelo.fkIdDeporte
                };
                pruebas.Close();
            }
            return modelo;
        }
        public List<modeloRol> mostrarRol()
        {
            pruebas.Open();
            List<modeloRol> sqlresultado = new List<modeloRol>();
            
                string sqlconsulta = "SELECT * FROM tablaRol;";
                sqlresultado = pruebas.Query<modeloRol>(sqlconsulta).ToList();
            pruebas.Close();
            return sqlresultado;
        }
        public modeloRol eliminarRol(modeloRol modelo)
        {
            pruebas.Open();
            {
                var sqlinsertar =
                "DELETE FROM rol WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    pkId = modelo.pkId

                };
                pruebas.Close();
            }
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