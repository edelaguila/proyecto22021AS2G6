using Polideportivo.AccesoDatos;
using Polideportivo.Modelo;
using System;
using System.Windows.Forms;
using static Polideportivo.Vista.utilidadForms;

namespace Polideportivo.Vista
{
    public partial class formJugador : Form
    {




        public formJugador()
        {
            InitializeComponent();
        }

        private void formJugador_Load(object sender, EventArgs e)
        {
            this.vwjugadorTableAdapter.Fill(this.vwJugador.vwjugador);
            cboBuscar.SelectedIndex = 0;
            //tablaJugadores.Selec
        }



        public void actualizarTablaJugadores()
        {
            this.vwjugadorTableAdapter.Fill(this.vwJugador.vwjugador);
        }


        private void txtJugadorFiltrar_TextChanged(object sender, EventArgs e)
        {

        }


        modeloJugador modeloFila = new modeloJugador();
        private void tablaJugadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = tablaJugadores.SelectedRows[0].Cells[1].Value.ToString();
            int id = stringAInt(tablaJugadores.SelectedRows[0].Cells[0].Value.ToString());
            int anotaciones = stringAInt(tablaJugadores.SelectedRows[0].Cells[2].Value.ToString());
            int fkIdEquipo = stringAInt(tablaJugadores.SelectedRows[0].Cells[3].Value.ToString());
            int fkIdRol = stringAInt(tablaJugadores.SelectedRows[0].Cells[5].Value.ToString());
            int fkIdDeporte = stringAInt(tablaJugadores.SelectedRows[0].Cells[7].Value.ToString());
            modeloFila.pkId = id;
            modeloFila.nombre = nombre;
            modeloFila.anotaciones = anotaciones;
            modeloFila.fkIdEquipo = fkIdEquipo;
            modeloFila.fkIdRol = fkIdRol;
            modeloFila.fkIdDeporte = fkIdDeporte;
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            abrirForm(new formJugadorEventos(this));
        }

        private void btnModificarJugador_Click(object sender, EventArgs e)
        {

            if (modeloFila.pkId > 0)
            {
                abrirForm(new formJugadorEventos(modeloFila, this));
            }
            else
            {
                abrirForm(new formAviso("Por favor, seleccione el jugador que desea modificar"));
            }
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFiltrar.Text))
            {
                vwjugadorBindingSource.Filter = string.Empty;
            }
            else
            {
                vwjugadorBindingSource.Filter = string.Format("{0}='{1}'",cboBuscar.Text,txtFiltrar.Text);
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
            int id = stringAInt(tablaJugadores.SelectedRows[0].Cells[0].Value.ToString());
            controladorJugador controlador = new controladorJugador();
            modeloJugador modelo = new modeloJugador();
            modelo.pkId = id;
            controlador.eliminarJugador(modelo);
            actualizarTablaJugadores();
        }

        private void tablaJugadores_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }
    }
}
