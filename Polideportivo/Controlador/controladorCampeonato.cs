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
    class controladorCampeonato
    {
        OdbcConnection conexionOdbc = new OdbcConnection("DSN=bdpolideportivo");
        public modeloCampeonato AgregarCampeonato(modeloCampeonato modelo)
        {
            conexionOdbc.Open();
            var sqlinsertar = 
                "INSERT INTO campeonato(pkId, nombre, fechaInicio, fechaFinal, fkIdDeporte, fkIdTipoCampeonato)" +
                " VALUES  (NULL, ?nombre?, ?fechaInicio?, ?fechaFinal?, ?fkIdDeporte?, " +
                "?fkIdTipoCampeonato?);";
            var ValorDeVariables = new
            {
                nombre = modelo.nombre,
                fechaInicio = modelo.fechaInicio,
                fechaFinal = modelo.fechaFinal,
                fkIdDeporte = modelo.fkIdDeporte,
                fkIdTipoCampeonato = modelo.fkIdTipoCampeonato
            };

            var resultadoinsertar = conexionOdbc.Execute(sqlinsertar, ValorDeVariables);

            conexionOdbc.Close();
            return modelo;
        }

        public modeloCampeonato ModificarCampeonato(modeloCampeonato modelo)
        {
            conexionOdbc.Open();
            var sqlinsertar =
                "UPDATE campeonato SET nombre = ?nombre?, fechaInicio = ?fechaInicio?, " +
                "fechaFinal = ?fechaFinal?, fkIdDeporte = ?fkIdDeporte?, fkIdTipoCampeonato = ?fkIdTipoCampeonato?" +
                " WHERE pkId = ?pkId?;";
            var ValorDeVariables = new
            {
                pkId = modelo.pkId,
                nombre = modelo.nombre,
                fechaInicio = modelo.fechaInicio,
                fechaFinal = modelo.fechaFinal,
                fkIdDeporte = modelo.fkIdDeporte,
                fkIdTipoCampeonato = modelo.fkIdTipoCampeonato
            };

            var resultadoinsertar = conexionOdbc.Execute(sqlinsertar, ValorDeVariables);

            conexionOdbc.Close();
            return modelo;
        }

        public modeloCampeonato eliminarCampeonato(modeloCampeonato modelo)
        {

            var sqlinsertar =
                "DELETE FROM campeonato WHERE pkId = ?pkId?;";
            var ValorDeVariables = new
            {
                pkId = modelo.pkId
            };
            var resultadoinsertar = conexionOdbc.Execute(sqlinsertar, ValorDeVariables);
            conexionOdbc.Close();
            return modelo;
        }
    }
}
