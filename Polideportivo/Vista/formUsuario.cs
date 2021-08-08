using Controlador;
using Modelo;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formUsuario : Form
    {
        private controladorEquipo controlador = new controladorEquipo();
        private modeloEquipo modelo = new modeloEquipo();

        public formUsuario()
        {
            InitializeComponent();
        }








        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrarForm(this);
        }


  




        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {

        }
    }
}