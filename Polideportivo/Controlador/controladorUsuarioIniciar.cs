using Vista;
using System;
using static Vista.utilidadForms;
using System.Windows.Forms;
using Modelo.DTO;
using Modelo.DAO;
using static Vista.utilidadForms;
using System.Collections.Generic;
using BCrypt.Net;

namespace Controlador
{
    /// <summary>
    /// Clase que gestiona la tabla de usuario iniciar de la base de datos
    /// </summary>
    class controladorUsuarioIniciar
    {
        private formUsuario vista;
        private dtoUsuario dtoUsuario = new dtoUsuario();
        private daoUsuario daoUsuario = new daoUsuario();
        public controladorUsuarioIniciar()
        {
        }
        /// <summary>
        /// Método que sirve para cargar los eventos que van dentro de cada elemento en el formUsuarioIniciar
        /// </summary>
        /// <param name="Vista"></param>
        public controladorUsuarioIniciar(formUsuario Vista)
        {
            vista = Vista;
            // Creación de eventos
            vista.btnIngresar.Click += new EventHandler(clickIniciarUsuario);
            vista.btnSalir.Click += new EventHandler(clickSalir);
            vista.btnRegistrarUsuario.Click += new EventHandler(clickRegistrarUsuario);
        }
        /// <summary>
        /// Método que al presionar el botón de cerrar del form se cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void clickSalir(object sender, EventArgs e)
        {
            cerrarForm(vista);
        }
        /// <summary>
        /// Método que abre el formUsuario registrar al presionar el boton de añadir usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void clickRegistrarUsuario(object sender, EventArgs e)
        {
            abrirFormDentroDePanel(new formUsuarioRegistrar(), vista.panelUsuario);
        }
        /// <summary>
        /// Método que sirve para iniciar sesión en el programa y así acceder a lo que es el menú de formPolideportivo
        /// el cual con ayuda de BCrypt ayuda a hashear las contraseñas lo cual hace mas segura las contraseñas dentro de la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void clickIniciarUsuario(object sender, EventArgs e)
        {

            string nombre = vista.txtNombre.Text;
            List<string> contraseñaHasheada = daoUsuario.obtenerDatosDeUsuario(nombre);
            string contraseñaObtenidaHasheada = "";
            bool esValido = false;
            if (contraseñaHasheada != null)
            {
                foreach (var contraseña in contraseñaHasheada)
                {
                    contraseñaObtenidaHasheada = contraseña;
                }

                esValido = BCrypt.Net.BCrypt.EnhancedVerify(vista.txtContraseña.Text, contraseñaObtenidaHasheada, hashType: HashType.SHA384);
            }

            if (esValido)
            {
                vista.Hide();

                abrirForm(new formPolideportivo());

            }

        }



    }
}
