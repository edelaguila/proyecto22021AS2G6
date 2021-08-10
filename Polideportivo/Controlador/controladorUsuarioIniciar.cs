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
    class controladorUsuarioIniciar
    {
        private formUsuario vista;
        private dtoUsuario dtoUsuario = new dtoUsuario();
        private daoUsuario daoUsuario = new daoUsuario();
        public controladorUsuarioIniciar()
        {
        }

        public controladorUsuarioIniciar(formUsuario Vista)
        {
            vista = Vista;
            // Creación de eventos
            vista.btnIngresar.Click += new EventHandler(clickIniciarUsuario);
            vista.btnRegistrarUsuario.Click += new EventHandler(clickRegistrarUsuario);
        }


        public void clickRegistrarUsuario(object sender, EventArgs e)
        {
            abrirFormDentroDePanel(new formUsuarioRegistrar(), vista.panelUsuario);
        }

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
