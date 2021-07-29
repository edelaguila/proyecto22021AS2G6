using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polideportivo.Vista
{
    public class utilidadForms 
    {
        public void abrirForm(Form formEvento)
        {

            //formEvento.TopLevel = false;
            formEvento.FormBorderStyle = FormBorderStyle.None;
            //formEvento.Dock = DockStyle.Fill;
            formEvento.StartPosition = FormStartPosition.CenterScreen;
            formEvento.BringToFront();
            formEvento.Show();
        }
        public void cerrarForm(Form formEvento)
        {
            formEvento.Close();
        }

        public int stringAInt(string str)
        {
            int num = Int32.Parse(str);
            return num;
        }

    }
}
