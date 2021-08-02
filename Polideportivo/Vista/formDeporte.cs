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
           // this.vwjugadorTableAdapter.Fill(this.tablaJugadores1.vwjugador);
        }


        private void txtJugadorFiltrar_TextChanged(object sender, EventArgs e)
        {

        }

        modeloDeporte modeloFila = new modeloDeporte();
        private void tablaDeporte_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string nombre = tablaDeportes.SelectedRows[0].Cells[1].Value.ToString();
            int id = stringAInt(tablaDeportes.SelectedRows[0].Cells[0].Value.ToString());
            modeloFila.pkId = id;
            modeloFila.nombre = nombre;
            //modeloFila.anotaciones = anotaciones;
            //modeloFila.fkIdEquipo = fkIdEquipo;
            //modeloFila.fkIdRol = fkIdRol;
            //modeloFila.fkIdDeporte = fkIdDeporte;
            // Para que la selección de filas funcione para modificar, tiene que enviarse el
            // modelo a la función de abrirForm:
            // utilidadForms.abrirForm(new formDeporteEventos(modeloFila, this));
            // Además de eso, modificar el construtor del form que va a utilizar los datos
            // para la modificación, en este caso sería el ctor de formDeporteEventos que recibe el modelo

        }

        private void btnAgregarDeporte_Click(object sender, EventArgs e)
        {
            controladorDeporte modeloAgregar = new controladorDeporte();
            modeloDeporte modelo = new modeloDeporte();

            modelo.nombre = txtNombreDeporte.Text;


            
            modeloAgregar.agregarDeporte(modelo);

            //formOriginal.actualizarTablaDeporte();

            
        }

        private void btnModificarJugador_Click(object sender, EventArgs e)
        {
            abrirForm(new formDeporteEventos(modeloFila, this));
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
