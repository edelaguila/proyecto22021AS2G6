using Controlador;
using Modelo;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;
using Modelo.DAO;

namespace Vista
{
    public partial class formRol : Form
    {
        public formRol()
        {
            InitializeComponent();
            controladorRol controladorRol = new controladorRol(this);
        }

        private void tablaEmpleado_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }
    }
}