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

        controladorEquipo controlador = new controladorEquipo();
        modeloEquipo modelo = new modeloEquipo();

        public formEquipoEventos()
        {
            InitializeComponent();
        }


        formEquipo formOriginal = new formEquipo();

        modeloEquipo modeloOriginal = new modeloEquipo();
        public formEquipoEventos(modeloEquipo modelo, formEquipo form)
        {
            // Este constructor es el que se utiliza para modificar datos
            InitializeComponent();
            btnModificarEquipo.Visible = true;
            btnAgregarEquipo.Visible = false;
            formOriginal = form;
            txtNombre.Text = modelo.nombre;
            // Llenar combobox de deportes
            llenarCboDeporte();
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
            llenarCboDeporte();
            cboDeporte.SelectedIndex = -1;
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
            llenarModeloConOpcionesSeleccionadas();
            controlador.agregarEquipo(modelo);
            formOriginal.actualizarTablaJugadores();
            cerrarForm(this);
        }

        private void btnModificarJugador_Click(object sender, EventArgs e)
        {
            llenarModeloConOpcionesSeleccionadas();
            controlador.modificarEquipo(modelo);
            formOriginal.actualizarTablaJugadores();
            cerrarForm(this);
        }

        private void llenarCboDeporte()
        {
            controladorDeporte deportes = new controladorDeporte();
            cboDeporte.DataSource = deportes.mostrarDeportes();
            cboDeporte.DisplayMember = "nombre";
            cboDeporte.ValueMember = "pkId";
        }

        private void llenarModeloConOpcionesSeleccionadas()
        {
            modelo.pkId = modeloOriginal.pkId;
            modelo.nombre = txtNombre.Text;
            modelo.fkIdDeporte = stringAInt(cboDeporte.SelectedValue.ToString());
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
