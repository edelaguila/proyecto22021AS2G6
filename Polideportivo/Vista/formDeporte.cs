using Controlador;
using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formDeporte : Form
    {
        public formDeporte()
        {
            InitializeComponent();
            controladorDeporte controladorDeporte = new controladorDeporte(this);
        }

        private void tablaDeportes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }
    }
}