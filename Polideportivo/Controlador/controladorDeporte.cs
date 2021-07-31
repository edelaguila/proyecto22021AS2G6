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
