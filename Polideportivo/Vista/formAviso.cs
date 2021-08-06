using System;
using System.Drawing;
using System.Windows.Forms;
using static Polideportivo.Vista.utilidadForms;

namespace Polideportivo.Vista
{
    public partial class formAviso : Form
    {
        public formAviso(string mensaje, int y)
        {
            InitializeComponent();
            lblAviso.MaximumSize = new Size(250, y - 50);
            lblAviso.Text = mensaje;
            this.Height = y;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrarForm(this);
        }

        private void btnErrorEntendido_Click(object sender, EventArgs e)
        {
            cerrarForm(this);
        }

        private void lblError_Click(object sender, EventArgs e)
        {
        }

        private void btnAvisoEntendido_Click(object sender, EventArgs e)
        {
            cerrarForm(this);
        }
    }
}