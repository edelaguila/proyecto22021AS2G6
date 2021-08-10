using Vista;
using System;
using static Vista.utilidadForms;
using System.Windows.Forms;
using Modelo.DTO;
using Modelo.DAO;

namespace Controlador
{
    class controladorUsuario
    {
        private formUsuario vista;
        private dtoUsuario modeloFila = new dtoUsuario();

        public controladorUsuario()
        {
        }

        public controladorUsuario(formUsuario Vista)
        {
            vista = Vista;
            // Creación de eventos
            vista.btnIngresar.Click += new EventHandler(click_Ingresar);
            vista.btnNuevoUsuario.Click += new EventHandler(clickAgregarUsuario);
            vista.btnSalir.Click += new EventHandler(btnSalir_Click);
        }

        private void clickAgregarUsuario(object sender, EventArgs e)
        {
            abrirForm(new formUsuarioEventos(this));
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrarForm(vista);
        }

        private static bool click_Ingresar(daoUsuario usuario)
        {
            daoUsuario daoTipoUsuario = new daoUsuario();
            List<dtoUsuario> lista = daoTipoUsuario.mostrarUsuario();
            if (lista != null)
                string nombre = txtNombre.Text;
            string contraseña = txtContraseña.Text;
            bool esvalido = false;
            string usuarioValidar = nombre;
            string contraseñaValidar = contraseña;
            if (usuarioValidar == usuario.Usuario && contraseñaValidar == usuario.contraseña)
            {
                esvalido = true;
            }
            return esvalido;
        }
    }
}
}
