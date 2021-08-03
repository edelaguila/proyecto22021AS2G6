using Polideportivo.AccesoDatos;
using Polideportivo.Controlador;
using Polideportivo.Modelo;
using System;
using System.Windows.Forms;
using static Polideportivo.Vista.utilidadForms;

namespace Polideportivo.Vista
{
    public partial class formEquipo : Form
    {




        public formEquipo()
        {
            InitializeComponent();
        }




        private void formEquipo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vwEquipo.vwequipo' Puede moverla o quitarla según sea necesario.
            this.vwequipoTableAdapter.Fill(this.vwEquipo.vwequipo);
            // TODO: esta línea de código carga datos en la tabla 'vwEquipo.vwequipo' Puede moverla o quitarla según sea necesario.
            //this.vwequipoTableAdapter.Fill(this.vwEquipo.vwequipo);

        }


        public void actualizarTablaJugadores()
        {
            this.vwequipoTableAdapter.Fill(this.vwEquipo.vwequipo);
        }


        private void txtJugadorFiltrar_TextChanged(object sender, EventArgs e)
        {

        }

        modeloEquipo modeloFila = new modeloEquipo();
        private void tablaJugadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = stringAInt(tablaEquipo.SelectedRows[0].Cells[0].Value.ToString());
            string nombre = tablaEquipo.SelectedRows[0].Cells[1].Value.ToString();
            int fkIdDeporte = stringAInt(tablaEquipo.SelectedRows[0].Cells[2].Value.ToString());
            modeloFila.pkId = id;
            modeloFila.nombre = nombre;
            modeloFila.fkIdDeporte = fkIdDeporte;
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            abrirForm(new formEquipoEventos(this));
        }

        private void btnModificarJugador_Click(object sender, EventArgs e)
        {
            abrirForm(new formEquipoEventos(modeloFila, this));
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFiltrar.Text))
            {
                //vwjugadorBindingSource.Filter = string.Empty;
            }
            else
            {
                //vwjugadorBindingSource.Filter = string.Format("{0}='{1}'", cboBuscar.Text, txtFiltrar.Text);
            }
        }

        private void cboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltrar.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarTablaJugadores();
        }

        private void btnEliminarJugador_Click(object sender, EventArgs e)
        {
            int id = stringAInt(tablaEquipo.SelectedRows[0].Cells[0].Value.ToString());
            controladorEquipo controlador = new controladorEquipo();
            modeloEquipo modelo = new modeloEquipo();
            modelo.pkId = id;
            //controlador.eliminarJugador(modelo);
            actualizarTablaJugadores();
        }

        private void tablaEquipo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }
    }
}
