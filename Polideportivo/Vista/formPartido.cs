using Polideportivo.AccesoDatos;
using Polideportivo.Modelo;
using System;
using System.Windows.Forms;
using static Polideportivo.Vista.utilidadForms;

namespace Polideportivo.Vista
{
    public partial class formPartido : Form
    {




        public formPartido()
        {
            InitializeComponent();
        }

        private void formJugador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vwPartido.vwpartido' Puede moverla o quitarla según sea necesario.
            this.vwpartidoTableAdapter.Fill(this.vwPartido.vwpartido);

            cboBuscar.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            modeloJugador modelo = new modeloJugador();
            controladorJugador db = new controladorJugador();
            db.agregarJugador(modelo);
        }


        public void actualizarTablaJugadores()
        {
            this.vwpartidoTableAdapter.Fill(this.vwPartido.vwpartido);
        }


        private void txtJugadorFiltrar_TextChanged(object sender, EventArgs e)
        {

        }

        modeloPartido modeloFila = new modeloPartido();
        private void tablaPartido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = stringAInt(tablaPartido.SelectedRows[0].Cells[0].Value.ToString());
            string equipo1 = tablaPartido.SelectedRows[0].Cells[1].Value.ToString();
            string equipo2 = tablaPartido.SelectedRows[0].Cells[2].Value.ToString();
            string campo = tablaPartido.SelectedRows[0].Cells[3].Value.ToString();
            string estado = tablaPartido.SelectedRows[0].Cells[4].Value.ToString();
            string fase = tablaPartido.SelectedRows[0].Cells[5].Value.ToString();
            int fkIdEquipo = stringAInt(tablaPartido.SelectedRows[0].Cells[3].Value.ToString());
            int fkIdRol = stringAInt(tablaPartido.SelectedRows[0].Cells[5].Value.ToString());
            int fkIdDeporte = stringAInt(tablaPartido.SelectedRows[0].Cells[7].Value.ToString());
            modeloFila.pkId = id;
            //modeloFila.nombre = nombre;
            //modeloFila.anotaciones = anotaciones;
            //modeloFila.fkIdEquipo = fkIdEquipo;
            //modeloFila.fkIdRol = fkIdRol;
            //modeloFila.fkIdDeporte = fkIdDeporte;
            // Para que la selección de filas funcione para modificar, tiene que enviarse el
            // modelo a la función de abrirForm:
            // utilidadForms.abrirForm(new formJugadorEventos(modeloFila, this));
            // Además de eso, modificar el construtor del form que va a utilizar los datos
            // para la modificación, en este caso sería el ctor de formJugadorEventos que recibe el modelo

        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            abrirForm(new formPartidoEventos(this));
        }

        private void btnModificarPartido_Click(object sender, EventArgs e)
        {
            abrirForm(new formPartidoEventos(modeloFila, this));
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFiltrar.Text))
            {
                vwpartidoBindingSource.Filter = string.Empty;
            }
            else
            {
                vwpartidoBindingSource.Filter = string.Format("{0}='{1}'", cboBuscar.Text, txtFiltrar.Text);
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
            int id = stringAInt(tablaPartido.SelectedRows[0].Cells[0].Value.ToString());
            controladorJugador controlador = new controladorJugador();
            modeloJugador modelo = new modeloJugador();
            modelo.pkId = id;
            controlador.eliminarJugador(modelo);
            actualizarTablaJugadores();
        }
    }
}
