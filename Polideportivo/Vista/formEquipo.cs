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

            string nombre = tablaEquipo.SelectedRows[0].Cells[1].Value.ToString();
            int id = stringAInt(tablaEquipo.SelectedRows[0].Cells[0].Value.ToString());
            int anotaciones = stringAInt(tablaEquipo.SelectedRows[0].Cells[2].Value.ToString());
            int fkIdEquipo = stringAInt(tablaEquipo.SelectedRows[0].Cells[3].Value.ToString());
            int fkIdRol = stringAInt(tablaEquipo.SelectedRows[0].Cells[5].Value.ToString());
            int fkIdDeporte = stringAInt(tablaEquipo.SelectedRows[0].Cells[7].Value.ToString());
            modeloFila.pkId = id;
            modeloFila.nombre = nombre;
            //modeloFila.anotaciones = anotaciones;
            //modeloFila.fkIdEquipo = fkIdEquipo;
            //modeloFila.fkIdRol = fkIdRol;
            modeloFila.fkIdDeporte = fkIdDeporte;
            // Para que la selección de filas funcione para modificar, tiene que enviarse el
            // modelo a la función de abrirForm:
            // utilidadForms.abrirForm(new formEquipoEventos(modeloFila, this));
            // Además de eso, modificar el construtor del form que va a utilizar los datos
            // para la modificación, en este caso sería el ctor de formEquipoEventos que recibe el modelo

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

        
    }
}
