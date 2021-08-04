using Polideportivo.AccesoDatos;
using Polideportivo.Controlador;
using Polideportivo.Modelo;
using System;
using System.Windows.Forms;
using static Polideportivo.Vista.utilidadForms;

namespace Polideportivo.Vista
{
    public partial class formEntrenador : Form
    {




        public formEntrenador()
        {
            InitializeComponent();
        }





        private void formDeporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vwEntrenador.vwentrenador' Puede moverla o quitarla según sea necesario.
            this.vwentrenadorTableAdapter.Fill(this.vwEntrenador.vwentrenador);
            cboBuscar.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            modeloDeporte modelo = new modeloDeporte();
            controladorDeporte db = new controladorDeporte();
        }


        public void actualizarTablaEntrenador()
        {
            this.vwentrenadorTableAdapter.Fill(this.vwEntrenador.vwentrenador);
        }


        private void txtEntrenadorFiltrar_TextChanged(object sender, EventArgs e)
        {

        }

        modeloEntrenador modeloFila = new modeloEntrenador();
        private void tablaEntrenador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = stringAInt(tablaEntrenador.SelectedRows[0].Cells[0].Value.ToString());
            string nombre = tablaEntrenador.SelectedRows[0].Cells[1].Value.ToString();
            txtNombreEntrenador.Text = nombre;
            modeloFila.pkId = id;

        }

        private void btnAgregarEntrenador_Click(object sender, EventArgs e)
        {
            controladorEntrenador modeloAgregar = new controladorEntrenador();
            modeloEntrenador modelo = new modeloEntrenador();
            modelo.nombre = txtNombreEntrenador.Text;
            modeloAgregar.agregarEntrenador(modelo);
            actualizarTablaEntrenador();
        }

        private void btnModificarEntrenador_Click(object sender, EventArgs e)
        {
            controladorEntrenador modeloModificar = new controladorEntrenador();
            modeloFila.nombre = txtNombreEntrenador.Text;
            modeloModificar.modificarEntrenador(modeloFila);
            actualizarTablaEntrenador();
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFiltrar.Text))
            {
                vwentrenadorBindingSource.Filter = string.Empty;
            }
            else
            {
                vwentrenadorBindingSource.Filter = string.Format("{0}='{1}'", cboBuscar.Text, txtFiltrar.Text);
            }
        }

        private void cboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltrar.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarTablaEntrenador();
        }

        private void btnEliminarEntrenador_Click(object sender, EventArgs e)
        {
            int id = stringAInt(tablaEntrenador.SelectedRows[0].Cells[0].Value.ToString());
            controladorEntrenador controlador = new controladorEntrenador();
            modeloEntrenador modelo = new modeloEntrenador();
            modelo.pkId = id;
            controlador.eliminarEntrenador(modelo);
            actualizarTablaEntrenador();
        }

        private void tablaEntrenador_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }
    }
}