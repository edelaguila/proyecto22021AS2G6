using Controlador;
using Modelo;
using Datos;
using Modelo.DAO;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formTipoFalta : Form
    {
        public formTipoFalta()
        {
            InitializeComponent();
            controladorTipoFalta controladorTipoFalta = new controladorTipoFalta(this);
        }

        private void tablaTipoFalta_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }
    }
}