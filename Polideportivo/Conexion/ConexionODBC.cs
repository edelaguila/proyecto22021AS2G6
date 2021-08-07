using Vista;
using System.Data.Odbc;
using static Vista.utilidadForms;

namespace Conexion
{
    /// <summary>
    /// Conexion ODBC
    /// </summary>
    public class ConexionODBC
    {
        private string dsn = "Dsn=bdpolideportivo";

        /// <summary>
        /// Inicia la conexión hacia ODBC con el DSN especificado.
        /// </summary>
        /// <returns></returns>
        public OdbcConnection abrirConexion()
        {
            OdbcConnection conexion = new OdbcConnection(dsn);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (OdbcException e)
            {
                abrirForm(new formError("El dsn especificado no funciona correctamente, corríjalo e intente de nuevo"));
                return null;
            }
        }

        /// <summary>
        /// Cierra la conexión hacia ODBC con el DSN especificado.
        /// </summary>
        /// <param name="conexion"></param>
        public void cerrarConexion(OdbcConnection conexion)
        {
            try
            {
                conexion.Close();
            }
            catch (OdbcException e)
            {
                abrirForm(new formError("El dsn especificado no se pudo cerrar"));
            }
        }
    }
}