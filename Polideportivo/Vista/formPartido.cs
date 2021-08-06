using Polideportivo.AccesoDatos;
using Polideportivo.Modelo;
using System;
using System.Windows.Forms;
using static Polideportivo.Vista.utilidadForms;

namespace Polideportivo.Vista
{
    public partial class formPartido : Form
    {
        // Se declaran los campos que se van a llenar a partir de la fila seleccionada de la tabla
        private int id;

        private string nombre;
        private int anotaciones;
        private int fkIdEquipo;
        private int fkIdRol;
        private int fkIdDeporte;

        // Se declara un modelo jugador para que guarde los datos de la fila sin perderlos
        private modeloJugador modeloFila = new modeloJugador();

        public formPartido()
        {
            InitializeComponent();
        }

        private void formJugador_Load(object sender, EventArgs e)
        {
            this.vwjugadorTableAdapter.Fill(this.vwJugador.vwjugador);
            // Se asigna la primera opción posible en la combobox de filtración
            cboBuscar.SelectedIndex = 0;
            // Se asigna la primera fila posible de la tabla y se llena el modelo
            tablaJugadores.CurrentCell = tablaJugadores.Rows[0].Cells[1];
            llenarModeloConFilaSeleccionada();
        }

        public void actualizarTablaJugadores()
        {
            this.vwjugadorTableAdapter.Fill(this.vwJugador.vwjugador);
        }

        private void tablaJugadores_CellClick(object sender, DataGridViewCellEventArgs e)
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
            actualizarTablaJugadores();
        }

        private void btnEliminarJugador_Click(object sender, EventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            controladorJugador controlador = new controladorJugador();
            controlador.eliminarJugador(modeloFila);
            actualizarTablaJugadores();
        }

        private void tablaJugadores_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }

        public void llenarModeloConFilaSeleccionada()
        {
            id = stringAInt(tablaJugadores.SelectedRows[0].Cells[0].Value.ToString());
            nombre = tablaJugadores.SelectedRows[0].Cells[1].Value.ToString();
            anotaciones = stringAInt(tablaJugadores.SelectedRows[0].Cells[2].Value.ToString());
            fkIdEquipo = stringAInt(tablaJugadores.SelectedRows[0].Cells[3].Value.ToString());
            fkIdRol = stringAInt(tablaJugadores.SelectedRows[0].Cells[5].Value.ToString());
            fkIdDeporte = stringAInt(tablaJugadores.SelectedRows[0].Cells[7].Value.ToString());
            modeloFila.pkId = id;
            modeloFila.nombre = nombre;
            modeloFila.anotaciones = anotaciones;
            modeloFila.fkIdEquipo = fkIdEquipo;
            modeloFila.fkIdRol = fkIdRol;
            modeloFila.fkIdDeporte = fkIdDeporte;
        }

        private void filtrarTabla()
        {
            if (string.IsNullOrEmpty(txtFiltrar.Text))
            {
                vwjugadorBindingSource.Filter = string.Empty;
            }
            else
            {
                vwjugadorBindingSource.Filter = string.Format("{0}='{1}'", cboBuscar.Text, txtFiltrar.Text);
            }
        }
    }
}