using Controlador;
using Modelo;
using Modelo.DAO;
using Modelo.DTO;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formParticipante : Form
    {
        // Se declaran los campos que se van a llenar a partir de la fila seleccionada de la tabla

        // Se declara un modelo jugador para que guarde los datos de la fila sin perderlos
        private dtoParticipante modeloFila = new dtoParticipante();

        public formParticipante()
        {
            InitializeComponent();
            controladorParticipante controladorParticipante = new controladorParticipante(this);
        }

        

        private void tablaPartidos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }

      

       
    }
}