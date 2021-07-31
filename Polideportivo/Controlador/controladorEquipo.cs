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

        public controladorEquipo(modeloEquipo Modelo)
        {
            modelo = Modelo;
        }
        OdbcConnection conexionOdbc = new OdbcConnection("DSN=bdpolideportivo");
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
