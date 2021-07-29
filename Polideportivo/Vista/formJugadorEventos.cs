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
    public partial class formJugadorEventos : Form
    {
        utilidadForms form = new utilidadForms();
        public formJugadorEventos()
        {
            InitializeComponent();
        }
        public formJugadorEventos(modeloJugador modelo)
        {
            InitializeComponent();
            txtNombre.Text = modelo.pkId.ToString();
        }


        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            controladorJugador modeloAgregar = new controladorJugador();
            modeloJugador modelo = new modeloJugador();
            modelo.nombre = txtNombre.Text;
            modelo.anotaciones = txtAnotaciones.Text;
            modeloAgregar.agregarJugador(modelo);
            form.cerrarForm(this);
        }

        private void formJugadorEventos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cboRoles.rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.cboRoles.rol);
            // TODO: esta línea de código carga datos en la tabla 'cboEquipos.equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.cboEquipos.equipo);

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
