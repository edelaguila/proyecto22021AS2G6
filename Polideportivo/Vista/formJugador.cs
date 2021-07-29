using Polideportivo.AccesoDatos;
using Polideportivo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polideportivo.Vista
{
    public partial class formJugador : Form
    {
        utilidadForms form = new utilidadForms();
        public formJugador()
        {
            InitializeComponent();
        }

        private void formJugador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosJugador.vwjugador' Puede moverla o quitarla según sea necesario.
            this.vwjugadorTableAdapter.Fill(this.datosJugador.vwjugador);
            // TODO: esta línea de código carga datos en la tabla 'vwJugador.vwjugador' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'vwJugador.vwjugador' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'datosJugador.jugador' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'tablajugadorespruba1.tablajugadores' Puede moverla o quitarla según sea necesario.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //modeloJugador modelo = new modeloJugador(nombreTexto.Text);
            modeloJugador modelo = new modeloJugador();
            //EquipoModelo modelo1 = new EquipoModelo(); CTRL + SHIFT + ESPACIO para ver sobrecargas
            //Si no se pasara como propiedad a la función, se puede hacer así:
            //modelo.Nombre = nombreTexto.Text;

            //// Pruebas acaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
            //foreach (IConexionDatos db in GlobalConfig.Conexiones)
            //{
            //    db.CrearEquipo(modelo);
            //}
            controladorJugador db = new controladorJugador();
            db.agregarJugador(modelo);

            //nombreTexto.Text = ""; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IEnumerable<modeloJugador> modelo;
            controladorJugador db = new controladorJugador();
            modelo = db.mostrarJugadores();
        }


        private void txtJugadorFiltrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tablaJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = tablaJugadores.SelectedRows[0].Cells[0].Value.ToString();
        }

        modeloJugador modeloFila = new modeloJugador();
        private void tablaJugadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //modeloFila.pkId = tablaJugadores.SelectedRows[0].Cells[0].Value.ToString();
            string pkId = tablaJugadores.SelectedRows[0].Cells[0].Value.ToString();
            modeloFila.pkId = Int32.Parse(pkId);
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            form.abrirForm(new formJugadorEventos());
            //modeloJugador modelo = new modeloJugador();
            //controladorJugador db = new controladorJugador();
            //db.agregarJugador(modelo);
        }


        private void btnModificarJugador_Click(object sender, EventArgs e)
        {
            form.abrirForm(new formJugadorEventos(modeloFila));
        }
    }
}
