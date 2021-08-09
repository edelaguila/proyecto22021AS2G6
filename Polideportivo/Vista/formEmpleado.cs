using Controlador;
using Modelo;
using Modelo.DAO;
using Modelo.DTO;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formEmpleado : Form
    {
        private int id;
        private string nombre;

        public formEmpleado()
        {
            InitializeComponent();
            controladorEmpleado controladorEmpleado = new controladorEmpleado(this);
            // Llenar combobox de deportes
            daoPuesto daoPuesto = new daoPuesto();
            cboPuesto.DataSource = daoPuesto.mostrarPuesto();
            cboPuesto.DisplayMember = "nombre";
            cboPuesto.ValueMember = "pkId";
            cboPuesto.SelectedIndex = -1;
            // Modificar el texto del título
        }

        private void tablaEmpleado_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }
    }
}