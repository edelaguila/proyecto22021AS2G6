using Polideportivo.AccesoDatos;
using Polideportivo.Controlador;
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
using static Polideportivo.Vista.utilidadForms;

namespace Polideportivo.Vista
{
    public partial class formEquipoEventos : Form
    {


        public formEquipoEventos()
        {
            InitializeComponent();
        }


        formEquipo formOriginal = new formEquipo();

        modeloEquipo modeloOriginal;
        public formEquipoEventos(modeloEquipo modelo, formEquipo form)
        {
            // Este constructor es el que se utiliza para modificar datos
            InitializeComponent();
            btnModificarEquipo.Visible = true;
            btnAgregarEquipo.Visible = false;
            formOriginal = form;
            txtNombre.Text = modelo.nombre;
            //txtAnotaciones.Text = modelo.anotaciones.ToString();
            // Llenar combobox de deportes
            controladorDeporte deportes = new controladorDeporte();
            // Para obtener el Id original que se va a modificar
            modeloOriginal = modelo;
            // Modificar el texto del label
            lblEquipoEvento.Text = "MODIFICAR JUGADOR";

        }


        public formEquipoEventos(formEquipo form)
        {
            // Este constructor es el que se utiliza para agregar datos
            InitializeComponent();
            btnAgregarEquipo.Visible = true;
            btnModificarEquipo.Visible = false;
            // Llenar combobox de deportes
            controladorDeporte deportes = new controladorDeporte();
            formOriginal = form;
            // Modificar el texto del título
            lblEquipoEvento.Text = "AGREGAR JUGADOR";
        }



       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrarForm(this);
        }


        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            controladorJugador modeloAgregar = new controladorJugador();
            modeloEquipo modelo = new modeloEquipo();
            modelo.nombre = txtNombre.Text;
            //modelo.anotaciones = stringAInt(txtAnotaciones.Text);
            //modelo.fkIdEquipo = stringAInt(cboEquipo.SelectedValue.ToString());
            //modelo.fkIdRol = stringAInt(cboRol.SelectedValue.ToString());
            //modeloAgregar.agregarJugador(modelo);
            formOriginal.actualizarTablaJugadores();
            cerrarForm(this);
        }

        private void btnModificarJugador_Click(object sender, EventArgs e)
        {
            controladorJugador modeloModificar = new controladorJugador();
            modeloEquipo modelo = new modeloEquipo();
            modelo.pkId = modeloOriginal.pkId;
            modelo.nombre = txtNombre.Text;
            //modelo.anotaciones = stringAInt(txtAnotaciones.Text);
            //modelo.fkIdEquipo = stringAInt(cboEquipo.SelectedValue.ToString());
            //modelo.fkIdRol = stringAInt(cboRol.SelectedValue.ToString());
            //modeloModificar.modificarJugador(modelo);
            formOriginal.actualizarTablaJugadores();
            cerrarForm(this);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
