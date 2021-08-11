using Conexion;
using Dapper;
using Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.DAO
    { class daoParticipante
        {
       
            private ConexionODBC ODBC = new ConexionODBC();

            /// <summary>
            /// Método que sirve para agregar nuevos jugadores a la base de datos
            /// </summary>
            /// <param name="modelo"></param>
            /// <returns></returns>
            public dtoParticipante agregarParticipante(dtoParticipante modelo)
            {
                OdbcConnection conexionODBC = ODBC.abrirConexion();
                if (conexionODBC != null)
                {
                    var sqlinsertar =
                    "INSERT INTO participante (pkId, puntos, fkIdCampeonato, fkIdEquipo, fkIdFase, fkIdEstadoParticipante) " +
                    "VALUES (NULL, ?puntos?, ?fkIdCampeonato?, ?fkIdEquipo?, ?fkIdFase?, ?fkIdEstadoParticipante?);";
                    var ValorDeVariables = new
                    {
                        puntos = modelo.puntos,
                        fkIdCampeonato = modelo.fkIdCampeonato,
                        fkIdEquipo = modelo.fkIdEquipo,
                        fkIdEstadoParticipante = modelo.fkIdEstadoParticipante,
                        fkIdFase = modelo.fkIdFase
                    };
                    conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                    ODBC.cerrarConexion(conexionODBC);
                    return modelo;
                }
                return null;
            }

            /// <summary>
            /// Método que sirve para modificar jugadores
            /// </summary>
            /// <param name="modelo"></param>
            /// <returns></returns>
            public dtoParticipante modificarParticipantes(dtoParticipante modelo)
            {
                OdbcConnection conexionODBC = ODBC.abrirConexion();
                if (conexionODBC != null)
                {
                    var sqlinsertar =
                    "UPDATE participante SET puntos = ?puntos?, fkIdCampeonato = ?fkIdCampeonato?, " +
                    "fkIdEquipo = ?fkIdEquipo?, fkIdEstadoParticipante = ?fkIdEstadoParticipante?, fkIdFase = ?fkIdFase?" +
                    " WHERE pkId = ?pkId?;";
                    var ValorDeVariables = new
                    {
                        puntos = modelo.puntos,
                        fkIdCampeonato = modelo.fkIdCampeonato,
                        fkIdEquipo = modelo.fkIdEquipo,
                        fkIdEstadoParticipante = modelo.fkIdEstadoParticipante,
                        fkIdFase = modelo.fkIdFase,
                        pkId = modelo.pkId
                    };
                    conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                    ODBC.cerrarConexion(conexionODBC);
                }
                return modelo;
            }

            public List<dtoParticipante> mostrarParticipante()
            {
                OdbcConnection conexionODBC = ODBC.abrirConexion();
                List<dtoParticipante> sqlresultado = new List<dtoParticipante>();
                if (conexionODBC != null)
                {
                    string sqlconsulta = "SELECT * FROM tablaParticipantes;";
                    sqlresultado = conexionODBC.Query<dtoParticipante>(sqlconsulta).ToList();
                    ODBC.cerrarConexion(conexionODBC);
                }
                return sqlresultado;
            }

            //public List<dtoParticipantes> mostrarJugadoresPorDeporte()
            //{
            //    OdbcConnection conexionODBC = ODBC.abrirConexion();
            //    List<dtoJugador> sqlresultado = new List<dtoJugador>();
            //    if (conexionODBC != null)
            //    {
            //        string sqlconsulta = "SELECT * FROM tablajugadores;";
            //        sqlresultado = conexionODBC.Query<dtoJugador>(sqlconsulta).ToList();
            //        ODBC.cerrarConexion(conexionODBC);
            //    }
            //    return sqlresultado;
            //}

            public dtoParticipante eliminarParticipante(dtoParticipante modelo)
            {
                OdbcConnection conexionODBC = ODBC.abrirConexion();
                if (conexionODBC != null)
                {
                    var sqlinsertar =
                    "DELETE FROM participante WHERE pkId = ?pkId?;";
                    var ValorDeVariables = new
                    {
                        pkId = modelo.pkId
                    };
                    conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                    ODBC.cerrarConexion(conexionODBC);
                }
                return modelo;
            }

    }
    }
