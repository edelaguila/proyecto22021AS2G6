using Dapper;
using Polideportivo.Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

namespace Polideportivo.Controlador
{
    class controladorTipoCampeonato
    {
        OdbcConnection pruebas = new OdbcConnection("DSN=bdpolideportivo");
        public List<modeloTipoCampeonato> mostrarTipoDeCampeonatos()
        {
            pruebas.Open();
            //string sqlconsulta = "SELECT pkId, nombre, fkIdDeporte FROM rol WHERE fkIdDeporte = 1;";
            string sqlconsulta = "SELECT * FROM tipocampeonato;";
            var sqlresultado = pruebas.Query<modeloTipoCampeonato>(sqlconsulta).ToList();
            pruebas.Close();
            return sqlresultado;
        }
    }
}
