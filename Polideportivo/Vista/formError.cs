using Polideportivo.AccesoDatos;
using Polideportivo.Controlador;
using Polideportivo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Polideportivo.Vista.utilidadForms;

namespace Polideportivo.Vista
{
    public partial class formError : Form
    {

        
        public formError(Exception e)
        {
            InitializeComponent();
            lblError.Text = e.Message;
            lblError.MaximumSize = new Size(300, 250);
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrarForm(this);
        }


        private void btnErrorEntendido_Click(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
    }
}
