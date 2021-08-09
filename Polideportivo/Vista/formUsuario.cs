using Controlador;
using Modelo;
using Modelo.DAO;
using Modelo.DTO;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formUsuario : Form
    {
        private daoEquipo controlador = new daoEquipo();
        private dtoEquipo modelo = new dtoEquipo();

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