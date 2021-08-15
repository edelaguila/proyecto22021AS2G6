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
{
    /// <summary>
    /// Clase utilizada para agregar, modificar, eliminar o mostrar los campos de partidos en la base de datos.
    /// </summary>
    class daoPartido
    {
        private ConexionODBC ODBC = new ConexionODBC();
        /// <summary>
        /// Método que sirve para agregar nuevos partidos a la base de datos 
        /// </summary>
        /// <param name="modelo">Recibe el modelo de partidos que se desea ingresar</param>
        /// <returns>Retorna el partido ingresado para ser agregado a la tabla</returns>
        public dtoPartido agregarPartido(dtoPartido modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO partido (pkId, equipo1, equipo2,anotacionesEquipo1, anotacionesEquipo2, campo, fecha, fkIdCampeonato, " +
                "fkIdEmpleado, fkIdEstadoPartido, fkIdFase) " +
                "VALUES (NULL, ?equipo1?, ?equipo2?,  ?anotacionesEquipo1?, ?anotacionesEquipo2?,?campo?, ?fecha?,  ?fkIdCampeonato?, " +
                "?fkIdEmpleado?, ?fkIdEstadoPartido?, ?fkIdFase?);";
                var ValorDeVariables = new
                {
                    equipo1 = modelo.equipo1,
                    equipo2 = modelo.equipo2,
                    anotacionesEquipo1 = modelo.anotacionesEquipo1,
                    anotacionesEquipo2 = modelo.anotacionesEquipo2,
                    campo = modelo.campo,
                    fecha = modelo.fecha,
                    fkIdFase = modelo.fkIdFase,
                    fkIdCampeonato = modelo.fkIdCampeonato,
                    fkIdEmpleado = modelo.fkIdEmpleado,
                    fkIdEstadoPartido = modelo.fkIdEstadoPartido
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }
        /// <summary>
        /// Método que sirve para modificar a los partidos
        /// </summary>
        /// <param name="modelo">Recibe el modelo de epartido para modificarlo</param>
        /// <returns>Retorna el partido modificado para ser modificado en la tabla</returns>
        public dtoPartido modificarPartido(dtoPartido modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE partido SET equipo1 = ?equipo1?, equipo2 = ?equipo2?, " +
                "campo = ?campo?, fecha = ?fecha?, " +
                 "fkIdCampeonato = ?fkIdCampeonato?, fkIdEmpleado = ?fkIdEmpleado?, " +
                "anotacionesEquipo1 = ?anotacionesEquipo1?,  " + "anotacionesEquipo2 = ?anotacionesEquipo2?,  " + "fkIdEstadoPartido = ?fkIdEstadoPartido?, " + "fkIdFase = ?fkIdFase? " +
                "WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    equipo1 = modelo.equipo1,
                    equipo2 = modelo.equipo2,
                    campo = modelo.campo,
                    fecha = modelo.fecha,
                    fkIdFase = modelo.fkIdFase,
                    fkIdCampeonato = modelo.fkIdCampeonato,
                    fkIdEmpleado = modelo.fkIdEmpleado,
                    fkIdEstadoPartido = modelo.fkIdEstadoPartido,
                    anotacionesEquipo1 = modelo.anotacionesEquipo1,
                    anotacionesEquipo2 = modelo.anotacionesEquipo2,
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }
        /// <summary>
        /// Método que sirve para modificar a los Resultados
        /// </summary>
        /// <param name="modelo">Recibe el modelo de resultado para modificarlo</param>
        /// <returns>Retorna el resultado modificado para ser modificado en la tabla</returns>
        public dtoPartido modificarResultado(dtoPartido modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE partido SET equipo1 = ?equipo1?, equipo2 = ?equipo2?, " +
                "anotacionesEquipo1 = ?anotacionesEquipo1?,  anotacionesEquipo2 = ?anotacionesEquipo2?" +
                " WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    equipo1 = modelo.equipo1,
                    equipo2 = modelo.equipo2,
                    anotacionesEquipo1 = modelo.anotacionesEquipo1,
                    anotacionesEquipo2 = modelo.anotacionesEquipo2,
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }
        /// <summary>
        /// Método que sirve para mostrar los partidos
        /// </summary>
        /// <returns>Retorna la consulta a la base de datos que son los partudis de la tablaPartido</returns>
        public List<dtoPartido> mostrarPartidos()
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            List<dtoPartido> sqlresultado = new List<dtoPartido>();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tablapartidos;";
                sqlresultado = conexionODBC.Query<dtoPartido>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
        /// <summary>
        /// Método que sirve para eliminar el partido seleccionado de la base de datos
        /// </summary>
        /// <param name="modelo">Recibe el modelo del partido seleccionado</param>
        /// <returns>Retorna el modelo del partido seleccionado para eliminarlo </returns>
        public dtoPartido eliminarPartido(dtoPartido modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM partido WHERE pkId = ?pkId?;";
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