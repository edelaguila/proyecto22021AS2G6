using Polideportivo.Controlador;
using Polideportivo.Modelo;
using System;
using System.Windows.Forms;
using static Polideportivo.Vista.utilidadForms;

namespace Polideportivo.Vista
{
    public partial class formEquipo : Form
    {
        private controladorEquipo controladorEquipo = new controladorEquipo();
        private modeloEquipo modeloFila = new modeloEquipo();

        public formEquipo()
        {
            InitializeComponent();
        }

        private void formEquipo_Load(object sender, EventArgs e)
        {
            actualizarTablaJugadores();
        }

        private void tablaJugadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            abrirForm(new formEquipoEventos(this));
        }

        private void btnModificarJugador_Click(object sender, EventArgs e)
        {
            abrirForm(new formEquipoEventos(modeloFila, this));
        }

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            controladorEquipo.eliminarEquipo(modeloFila);
            actualizarTablaJugadores();
        }

        private void cboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltrar.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarTablaJugadores();
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            filtrarTabla();
        }

        public void llenarModeloConFilaSeleccionada()
        {
            modeloFila.pkId = stringAInt(tablaEquipo.SelectedRows[0].Cells[0].Value.ToString());
            modeloFila.nombre = tablaEquipo.SelectedRows[0].Cells[1].Value.ToString();
            modeloFila.fkIdDeporte = stringAInt(tablaEquipo.SelectedRows[0].Cells[2].Value.ToString());
        }

        private void tablaEquipo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }

        private void filtrarTabla()
        {
            if (string.IsNullOrEmpty(txtFiltrar.Text))
            {
                vwequipoBindingSource.Filter = string.Empty;
            }
            else
            {
                vwequipoBindingSource.Filter = string.Format("{0}='{1}'", cboBuscar.Text, txtFiltrar.Text);
            }
        }

        public void actualizarTablaJugadores()
        {
            this.vwequipoTableAdapter.Fill(this.vwEquipo.vwequipo);
        }
    }
}