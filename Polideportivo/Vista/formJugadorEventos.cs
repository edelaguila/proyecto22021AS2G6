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
        utilidadForms prueba = new utilidadForms();
        public formJugadorEventos()
        {
            InitializeComponent();
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            prueba.cerrarForm();
        }
    }
}
