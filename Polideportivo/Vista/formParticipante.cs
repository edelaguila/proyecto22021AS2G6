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

        private void formParticipante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vwParticipante.vwparticipante' Puede moverla o quitarla según sea necesario.
            this.vwparticipanteTableAdapter.Fill(this.vwParticipante.vwparticipante);
            cboBuscar.SelectedIndex = 0;
            tablaParticipantes.CurrentCell = tablaParticipantes.Rows[0].Cells[1];
            llenarModeloConFilaSeleccionada();
        }

        public void actualizarTablaPartido()
        {
        }

        private void tablapartidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
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
            daoParticipante controlador = new daoParticipante();

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
                vwparticipanteBindingSource.Filter = string.Empty;
            }
            else
            {
                vwparticipanteBindingSource.Filter = string.Format("{0}='{1}'", cboBuscar.Text, txtFiltrar.Text);
            }
        }

        private void btnAgregarPartido_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
        }

        private void tablaParticipantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}