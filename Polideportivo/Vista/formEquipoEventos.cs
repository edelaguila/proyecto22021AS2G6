using Controlador;
using System.Windows.Forms;
using Modelo.DTO;

namespace Vista
{
    public partial class formEquipoEventos : Form
    {
        public formEquipoEventos(controladorEquipo padre, string tipoDeEvento)
        {
            // Este constructor es el que se utiliza para modificar datos
            InitializeComponent();
            controladorEquipoEventos controladorEmpleado =
                new controladorEquipoEventos(this, padre, tipoDeEvento);
        }
    }
}