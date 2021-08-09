using Controlador;
using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formDeporte : Form
    {
        private int id;
        private string nombre;

        public formDeporte()
        {
            InitializeComponent();
        }

        private void formDeporte_Load(object sender, EventArgs e)
        {
            try
            {
                this.deporteTableAdapter.Fill(this.vwDeportes.deporte);
                cboBuscar.SelectedIndex = 0;
            }
            catch (MySqlException error)
            {
                abrirForm(new formError(error));
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    modeloDeporte modelo = new modeloDeporte();
        //    controladorDeporte db = new controladorDeporte();
        //}

        public void actualizarTablaDeporte()
        {
            this.deporteTableAdapter.Fill(this.vwDeportes.deporte);
        }

        private void txtJugadorFiltrar_TextChanged(object sender, EventArgs e)
        {
        }

        private modeloDeporte modeloFila = new modeloDeporte();

        private void tablaDeporte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            txtNombreDeporte.Text = nombre;
        }

        private void llenarModeloConFilaSeleccionada()
        {
            id = stringAInt(tablaDeportes.SelectedRows[0].Cells[0].Value.ToString());
            nombre = tablaDeportes.SelectedRows[0].Cells[1].Value.ToString();
            modeloFila.pkId = id;
        }

        private void btnAgregarDeporte_Click(object sender, EventArgs e)
        {
            controladorDeporte modeloAgregar = new controladorDeporte();
            modeloDeporte modelo = new modeloDeporte();
            modelo.nombre = txtNombreDeporte.Text;
            modeloAgregar.agregarDeporte(modelo);
            actualizarTablaDeporte();
        }

        private void btnModificarDeporte_Click(object sender, EventArgs e)
        {
            controladorDeporte modeloModificar = new controladorDeporte();
            modeloFila.nombre = txtNombreDeporte.Text;
            modeloModificar.modificarDeporte(modeloFila);
            actualizarTablaDeporte();
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFiltrar.Text))
            {
                vwDeporteBindingSource.Filter = string.Empty;
            }
            else
            {
                vwDeporteBindingSource.Filter = string.Format("{0}='{1}'", cboBuscar.Text, txtFiltrar.Text);
            }
        }

        private void cboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltrar.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarTablaDeporte();
        }

        private void btnEliminarDeporte_Click(object sender, EventArgs e)
        {
            int id = stringAInt(tablaDeportes.SelectedRows[0].Cells[0].Value.ToString());
            controladorDeporte controlador = new controladorDeporte();
            modeloDeporte modelo = new modeloDeporte();
            modelo.pkId = id;
            controlador.eliminarDeporte(modelo);
            actualizarTablaDeporte();
        }

        private void tablaDeportes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }

        private void txtNombreDeporte_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void tablaDeportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}