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
    class controladorDeporte
    {
        OdbcConnection pruebas = new OdbcConnection("DSN=bdpolideportivo");

        public modeloDeporte agregarDeporte(modeloDeporte modelo)
        {

            var sqlinsertar =
                "INSERT INTO deporte (pkId, nombre) " +
                "VALUES (NULL, ?nombre?);";
            var ValorDeVariables = new
            {
                nombre = modelo.nombre
                
            };
            var resultadoinsertar = pruebas.Execute(sqlinsertar, ValorDeVariables);
            pruebas.Close();
            return modelo;
        }

        public modeloDeporte modificarDeporte(modeloDeporte modelo)
        {
            pruebas.Open();
            var sqlinsertar =
                "UPDATE deporte SET nombre = ?nombre? "+
                "WHERE pkId = ?pkId?;";
            var ValorDeVariables = new
            {
                nombre = modelo.nombre,
                pkId = modelo.pkId
            };
            var resultadoinsertar = pruebas.Execute(sqlinsertar, ValorDeVariables);
            pruebas.Close();
            return modelo;
        }

        public modeloDeporte eliminarDeporte(modeloDeporte modelo)
        {

            var sqlinsertar =
                "DELETE FROM deporte WHERE pkId = ?pkId?;";
            
           var ValorDeVariables = new
            {
                pkId = modelo.pkId
            };
            var resultadoinsertar = pruebas.Execute(sqlinsertar, ValorDeVariables);
            pruebas.Close();
            return modelo;
        }


        public List<modeloDeporte> mostrarDeportes()
        {
            pruebas.Open();
            //string sqlconsulta = "SELECT pkId, nombre, fkIdDeporte FROM rol WHERE fkIdDeporte = 1;";
            string sqlconsulta = "SELECT * FROM deporte;";
            var sqlresultado = pruebas.Query<modeloDeporte>(sqlconsulta).ToList();
            pruebas.Close();
            return sqlresultado;
        }
    }
}
