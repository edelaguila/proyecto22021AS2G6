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
        OdbcConnection prueba = new OdbcConnection("DSN=bdpolideportivo");
        modeloRol modelo;
        public controladorRol(modeloRol Modelo)
        {
            modelo = Modelo;
        }
        OdbcConnection pruebas = new OdbcConnection("DSN=bdpolideportivo");
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
