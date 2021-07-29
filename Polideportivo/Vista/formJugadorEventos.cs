using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polideportivo.Vista
{
    public partial class formJugadorEventos : Form
    {
        utilidadForms form = new utilidadForms();
        public formJugadorEventos()
        {
            InitializeComponent();
        }

        public formJugadorEventos()
        {
            InitializeComponent();
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            form.cerrarForm(this);
        }

        private void formJugadorEventos_Load(object sender, EventArgs e)
        {

        }
    }
}
