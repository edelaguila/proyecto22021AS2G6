using Controlador;
using Modelo;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formParticipante : Form
    {
        // Se declaran los campos que se van a llenar a partir de la fila seleccionada de la tabla
        private int id;

        private string equipo1;
        private string equipo2;
        private string campo;
        private string fecha;
        private string fase;
        private int fkIdCampeonato;
        private int fkIdEmpleado;
        private int fkIdResultado;
        private int fkIdEstado;

        // Se declara un modelo jugador para que guarde los datos de la fila sin perderlos
        private modeloParticipante modeloFila = new modeloParticipante();

        public formParticipante()
        {
            InitializeComponent();
        }

        private void formPartido_Load(object sender, EventArgs e)
        {
            cboBuscar.SelectedIndex = 0;
            tablaPartidos.CurrentCell = tablaPartidos.Rows[0].Cells[1];
            llenarModeloConFilaSeleccionada();
        }

        public void actualizarTablaPartido()
        {
        }

        private void tablapartidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
        }

        private void btnAgregarPartido_Click(object sender, EventArgs e)
        {
            abrirForm(new formParticipanteEventos(this));
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            abrirForm(new formParticipanteEventos(modeloFila, this));
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            filtrarTabla();
        }

        private void cboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltrar.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarTablaPartido();
        }

        private void btnEliminarPartido_Click(object sender, EventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            controladorParticipante controlador = new controladorParticipante();

            actualizarTablaPartido();
        }

        private void tablaPartidos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }

        public void llenarModeloConFilaSeleccionada()
        {
        }

        private void filtrarTabla()
        {
            if (string.IsNullOrEmpty(txtFiltrar.Text))
            {
                //vwpartidoBindingSource.Filter = string.Empty;
            }
            else
            {
                //vwpartidoBindingSource.Filter = string.Format("{0}='{1}'", cboBuscar.Text, txtFiltrar.Text);
            }
        }

        private void btnAgregarPartido_Click_1(object sender, EventArgs e)
        {
            abrirForm(new formParticipanteEventos(this));
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            abrirForm(new formParticipanteEventos(modeloFila, this));
        }
    }
}