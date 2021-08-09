using Controlador;
using Modelo;
using Modelo.DTO;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formJugador : Form
    {
        public formJugador()
        {
            InitializeComponent();
            controladorJugador controladorJugador = new controladorJugador(this);
        }

        private void tablaJugadores_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }
    }
}