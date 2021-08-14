using Controlador;
using Modelo;
using Modelo.DTO;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formUsuario : Form
    {
        public formUsuario()
        {
            InitializeComponent();
            controladorUsuarioIniciar controladorUsuario = new controladorUsuarioIniciar(this);

        }

        private void tablaUsuarios_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}