using Polideportivo.AccesoDatos;
using Polideportivo.Controlador;
using Polideportivo.Modelo;
using System;
using System.Windows.Forms;
using static Polideportivo.Vista.utilidadForms;

namespace Polideportivo.Vista
{
    public partial class formCampeonato : Form
    {




        public formCampeonato()
        {
            InitializeComponent();
        }

        private void formCampeonato_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vwCampeonato.vwcampeonato' Puede moverla o quitarla según sea necesario.
            this.vwcampeonatoTableAdapter.Fill(this.vwCampeonato.vwcampeonato);

            cboBuscar.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            modeloCampeonato modelo = new modeloCampeonato();
            controladorCampeonato db = new controladorCampeonato();
            //db.agregarJugador(modelo);
        }


        public void actualizarTablaJugadores()
        {
            //this.vwjugadorTableAdapter.Fill(this.tablaJugadores1.vwjugador);
        }


        private void txtJugadorFiltrar_TextChanged(object sender, EventArgs e)
        {

        }

        modeloCampeonato modeloFila = new modeloCampeonato();
        private void tablaJugadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string nombre = tablaJugadores.SelectedRows[0].Cells[1].Value.ToString();
            int id = stringAInt(tablaJugadores.SelectedRows[0].Cells[0].Value.ToString());
            int anotaciones = stringAInt(tablaJugadores.SelectedRows[0].Cells[2].Value.ToString());
            int fkIdEquipo = stringAInt(tablaJugadores.SelectedRows[0].Cells[3].Value.ToString());
            int fkIdRol = stringAInt(tablaJugadores.SelectedRows[0].Cells[5].Value.ToString());
            int fkIdDeporte = stringAInt(tablaJugadores.SelectedRows[0].Cells[7].Value.ToString());
            //modeloFila.pkId = id;
            //modeloFila.nombre = nombre;
            //modeloFila.anotaciones = anotaciones;
            //modeloFila.fkIdEquipo = fkIdEquipo;
            //modeloFila.fkIdRol = fkIdRol;
            //modeloFila.fkIdDeporte = fkIdDeporte;
            // Para que la selección de filas funcione para modificar, tiene que enviarse el
            // modelo a la función de abrirForm:
            // utilidadForms.abrirForm(new formCampeonatoEventos(modeloFila, this));
            // Además de eso, modificar el construtor del form que va a utilizar los datos
            // para la modificación, en este caso sería el ctor de formCampeonatoEventos que recibe el modelo

        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            abrirForm(new formCampeonatoEventos(this));
        }

        private void btnModificarJugador_Click(object sender, EventArgs e)
        {
            abrirForm(new formCampeonatoEventos(modeloFila, this));
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
            int id = stringAInt(tablaJugadores.SelectedRows[0].Cells[0].Value.ToString());
            controladorCampeonato controlador = new controladorCampeonato();
            modeloCampeonato modelo = new modeloCampeonato();
            //modelo.pkId = id;
            //controlador.eliminarJugador(modelo);
            actualizarTablaJugadores();
        }
    }
}
