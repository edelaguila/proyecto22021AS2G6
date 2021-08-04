using System;
using static Polideportivo.Vista.utilidadForms;
using System.Data.Odbc;
using Polideportivo.Vista;

namespace Polideportivo.Conexion
{
    class ConexionODBC
    {
        string dsn = "Dsn=bdpolideportivo";
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
