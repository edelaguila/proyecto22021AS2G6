using Controlador;
using Modelo;
using Modelo.DAO;
using Modelo.DTO;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formEquipo : Form
    {
        private daoEquipo controladorEquipo = new daoEquipo();
        private dtoEquipo modeloFila = new dtoEquipo();

        public formEquipo()
        {
            InitializeComponent();
            controladorEquipo controladorEquipo = new controladorEquipo(this);
        }

        private void tablaEquipo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }
    }
}