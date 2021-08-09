using Controlador;
using Modelo.DTO;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formPartido : Form
    {
        // Se declara un modelo jugador para que guarde los datos de la fila sin perderlos
        private dtoPartido modeloFila = new dtoPartido();

        public formPartido()
        {
            InitializeComponent();
            controladorPartido controladorJugador = new controladorPartido(this);
        }

        private void tablaPartidos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }
    }
}