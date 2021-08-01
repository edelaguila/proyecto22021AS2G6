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
    public partial class formDeporteEventos : Form
    {


        public formDeporteEventos()
        {
            InitializeComponent();
        }


        formDeporte formOriginal = new formDeporte();

        modeloDeporte modeloOriginal;
        public formDeporteEventos(modeloDeporte modelo, formDeporte form)
        {
            // Este constructor es el que se utiliza para modificar datos
            InitializeComponent();
            btnModificarJugador.Visible = true;
            btnAgregarJugador.Visible = false;
            formOriginal = form;
            txtNombre.Text = modelo.nombre;
            //txtAnotaciones.Text = modelo.anotaciones.ToString();
            // Llenar combobox de deportes
            controladorDeporte deportes = new controladorDeporte();
            cboDeporte.DataSource = deportes.mostrarDeportes();
            cboDeporte.DisplayMember = "nombre";
            cboDeporte.ValueMember = "pkId";
            // Para obtener el Id original que se va a modificar
            modeloOriginal = modelo;
            // Modificar el texto del label
            lblJugadorEvento.Text = "MODIFICAR JUGADOR";

        }


        public formDeporteEventos(formDeporte form)
        {
            // Este constructor es el que se utiliza para agregar datos
            InitializeComponent();
            btnAgregarJugador.Visible = true;
            btnModificarJugador.Visible = false;
            // Llenar combobox de deportes
            controladorDeporte deportes = new controladorDeporte();
            cboDeporte.DataSource = deportes.mostrarDeportes();
            cboDeporte.DisplayMember = "nombre";
            cboDeporte.ValueMember = "pkId";
            cboDeporte.SelectedIndex = -1;
            formOriginal = form;
            // Modificar el texto del título
            lblJugadorEvento.Text = "AGREGAR JUGADOR";
        }



        // Actualizar el combobox de roles dependiendo del deporte seleccionado
        private void cboDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDeporte.SelectedIndex > -1)
            {
                // Llenar la combobox de rol dependiendo del deporte elegido
                modeloRol modelorol = new modeloRol();
                modelorol.fkIdDeporte = stringAInt(cboDeporte.SelectedValue.ToString());
                controladorRol rol = new controladorRol(modelorol);
                cboRol.DataSource = rol.mostrarRolesPorDeporte();
                cboRol.DisplayMember = "nombre";
                cboRol.ValueMember = "pkId";

                // Llenar la combobox de equipo dependiendo del deporte elegido
                modeloEquipo modeloequipo = new modeloEquipo();
                modeloequipo.fkIdDeporte = stringAInt(cboDeporte.SelectedValue.ToString());
                controladorEquipo equipo = new controladorEquipo(modeloequipo);
                cboEquipo.DataSource = equipo.mostrarEquipoPorDeporte();
                cboEquipo.DisplayMember = "nombre";
                cboEquipo.ValueMember = "pkId";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrarForm(this);
        }


        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            controladorJugador modeloAgregar = new controladorJugador();
            modeloDeporte modelo = new modeloDeporte();
            modelo.nombre = txtNombre.Text;
            //modelo.anotaciones = stringAInt(txtAnotaciones.Text);
            //modelo.fkIdDeporte = stringAInt(cboDeporte.SelectedValue.ToString());
            //modelo.fkIdEquipo = stringAInt(cboEquipo.SelectedValue.ToString());
            //modelo.fkIdRol = stringAInt(cboRol.SelectedValue.ToString());
            //modeloAgregar.agregarJugador(modelo);
            formOriginal.actualizarTablaJugadores();
            cerrarForm(this);
        }

        private void btnModificarJugador_Click(object sender, EventArgs e)
        {
            controladorJugador modeloModificar = new controladorJugador();
            modeloDeporte modelo = new modeloDeporte();
            modelo.pkId = modeloOriginal.pkId;
            modelo.nombre = txtNombre.Text;
            //modelo.anotaciones = stringAInt(txtAnotaciones.Text);
            //modelo.fkIdDeporte = stringAInt(cboDeporte.SelectedValue.ToString());
            //modelo.fkIdEquipo = stringAInt(cboEquipo.SelectedValue.ToString());
            //modelo.fkIdRol = stringAInt(cboRol.SelectedValue.ToString());
            //modeloModificar.modificarJugador(modelo);
            formOriginal.actualizarTablaJugadores();
            cerrarForm(this);
        }
    }
}
