using System;
using System.Drawing;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formError : Form
    {
        public formError(Exception e)
        {
            InitializeComponent();
            lblError.Text = e.Message;
            lblError.MaximumSize = new Size(300, 250);
            this.Height = 300;
        }

        public formError(string e)
        {
            InitializeComponent();
            lblError.Text = e;
            lblError.MaximumSize = new Size(300, 250);
            this.Height = 300;
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