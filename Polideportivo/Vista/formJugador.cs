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
        public formJugador()
        {
            InitializeComponent();
        }

        private void formJugador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tablajugadorespruba1.tablajugadores' Puede moverla o quitarla según sea necesario.
            this.tablajugadoresTableAdapter.Fill(this.tablajugadorespruba1.tablajugadores);

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
            tablaJugadores.DataSource = modelo;
            tablaAvanzada.DataSource = modelo;
        }

        private void tablaJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = tablaJugadores.SelectedRows[0].Cells[0].Value.ToString();
        
           
        }
    }
}
