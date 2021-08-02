using Polideportivo.AccesoDatos;
using Polideportivo.Controlador;
using Polideportivo.Modelo;
using System;
using System.Windows.Forms;
using static Polideportivo.Vista.utilidadForms;

namespace Polideportivo.Vista
{
    public partial class formDeporte : Form
    {




        public formDeporte()
        {
            InitializeComponent();
        }

        
       


        private void formDeporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vwDeportes.deporte' Puede moverla o quitarla según sea necesario.
            this.deporteTableAdapter.Fill(this.vwDeportes.deporte);


            // TODO: esta línea de código carga datos en la tabla 'tablaJugadores1.vwjugador' Puede moverla o quitarla según sea necesario.
            // vwjugadorTableAdapter.Fill(tablaJugadores1.vwjugador);
            cboBuscarDeporte.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            modeloDeporte modelo = new modeloDeporte();
            controladorDeporte db = new controladorDeporte();
            //db.agregarJugador(modelo);
        }


        public void actualizarTablaDeporte()
        {
            this.deporteTableAdapter.Fill(this.vwDeportes.deporte);
        }


        private void txtJugadorFiltrar_TextChanged(object sender, EventArgs e)
        {

        }

        modeloDeporte modeloFila = new modeloDeporte();
        private void tablaDeporte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = stringAInt(tablaDeportes.SelectedRows[0].Cells[0].Value.ToString());
            string nombre = tablaDeportes.SelectedRows[0].Cells[1].Value.ToString();
            txtNombreDeporte.Text = nombre;
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
            if (string.IsNullOrEmpty(txtFiltrarDeporte.Text))
            {
               // vwjugadorBindingSource.Filter = string.Empty;
            }
            else
            {
               // vwjugadorBindingSource.Filter = string.Format("{0}='{1}'", cboBuscar.Text, txtFiltrar.Text);
            }
        }

        private void cboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltrarDeporte.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarTablaDeporte();
        }

        private void btnEliminarJugador_Click(object sender, EventArgs e)
        {
            int id = stringAInt(tablaDeportes.SelectedRows[0].Cells[0].Value.ToString());
            controladorDeporte controlador = new controladorDeporte();
            modeloDeporte modelo = new modeloDeporte();
            modelo.pkId = id;
            //controlador.eliminarJugador(modelo);
            actualizarTablaDeporte();
        }
    }
}
