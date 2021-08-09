using Controlador;
using Modelo;
using Modelo.DAO;
using Modelo.DTO;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formEntrenador : Form
    {
        public formEntrenador()
        {
            InitializeComponent();
            controladorEntrenador controladorEntrenador = new controladorEntrenador(this);
        }

        private void tablaEntrenador_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }
    }
}