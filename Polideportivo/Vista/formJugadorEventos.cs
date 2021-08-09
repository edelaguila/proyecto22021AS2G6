using Controlador;
using Modelo;
using Modelo.DAO;
using Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formJugadorEventos : Form
    {
        private dtoJugador modelo = new dtoJugador();

        private controladorJugador formOriginal = new controladorJugador();

        private dtoJugador modeloOriginal = new dtoJugador();

        public formJugadorEventos(dtoJugador modelo, controladorJugador form)
        {
            // Este constructor es el que se utiliza para modificar datos
            InitializeComponent();
            btnModificarJugador.Visible = true;
            btnAgregarJugador.Visible = false;
            formOriginal = form;
            txtNombre.Text = modelo.nombre;
            txtAnotaciones.Text = modelo.anotaciones.ToString();
            // Llenar combobox de deportes
            controladorDeporte deportes = new controladorDeporte();
            cboDeporte.DataSource = deportes.mostrarDeportes();
            cboDeporte.DisplayMember = "nombre";
            cboDeporte.ValueMember = "pkId";
            cboDeporte.SelectedItem = cboDeporte.Items[0];
            // Para obtener el Id original que se va a modificar
            modeloOriginal = modelo;
            // Modificar el texto del label
            lblJugadorEvento.Text = "MODIFICAR JUGADOR";
        }

        // Este constructor es el que se utiliza para agregar datos
        public formJugadorEventos(controladorJugador form)
        {
            formOriginal = form;
            InitializeComponent();
            btnAgregarJugador.Visible = true;
            btnModificarJugador.Visible = false;
            // Llenar combobox de deportes
            controladorDeporte deportes = new controladorDeporte();
            List<modeloDeporte> lista = deportes.mostrarDeportes();
            if (lista != null)
            {
                cboDeporte.DataSource = deportes.mostrarDeportes();
                cboDeporte.DisplayMember = "nombre";
                cboDeporte.ValueMember = "pkId";
                // Modificar el texto del título
                lblJugadorEvento.Text = "AGREGAR JUGADOR";
            }
            else
            {
                cerrarForm(this);
            }
        }

        // Actualizar el combobox de roles dependiendo del deporte seleccionado
        private void cboDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDeporte.SelectedIndex > -1)
            {
                // Llenar la combobox de rol dependiendo del deporte elegido
                modeloRol modelorol = new modeloRol();
                modelorol.fkIdDeporte = stringAInt(cboDeporte.SelectedValue.ToString());
                controladorRol rol = new controladorRol();
                cboRol.DataSource = rol.mostrarRolesPorDeporte(modelorol);
                cboRol.DisplayMember = "nombre";
                cboRol.ValueMember = "pkId";

                // Llenar la combobox de equipo dependiendo del deporte elegido
                modeloEquipo modeloequipo = new modeloEquipo();
                modeloequipo.fkIdDeporte = stringAInt(cboDeporte.SelectedValue.ToString());
                controladorEquipo equipo = new controladorEquipo();
                cboEquipo.DataSource = equipo.mostrarEquipoPorDeporte(modeloequipo);
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
            if (validarFormEventos())
            {
                controladorJugador modeloAgregar = new controladorJugador();
                llenarModeloConDatosIngresados();
                formOriginal.actualizarTablaJugadores();
                cerrarForm(this);
            }
        }

        /// <summary>
        /// Modifica jugador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarJugador_Click(object sender, EventArgs e)
        {
            if (validarFormEventos())
            {
                daoJugador daoJugador = new daoJugador();
                llenarModeloConDatosIngresados();

                daoJugador.modificarJugador(modelo);
                formOriginal.actualizarTablaJugadores();
                cerrarForm(this);
            }
        }

        /// <summary>
        /// Hola
        /// </summary>
        private void llenarModeloConDatosIngresados()
        {
            modelo.pkId = modeloOriginal.pkId;
            modelo.nombre = txtNombre.Text;
            modelo.anotaciones = stringAInt(txtAnotaciones.Text);
            modelo.fkIdDeporte = stringAInt(cboDeporte.SelectedValue.ToString());
            modelo.fkIdEquipo = stringAInt(cboEquipo.SelectedValue.ToString());
            modelo.fkIdRol = stringAInt(cboRol.SelectedValue.ToString());
        }

        private bool validarFormEventos()
        {
            bool validado = false;
            if (txtNombre.Text != "" && cboDeporte.SelectedValue != null
                 && cboEquipo.SelectedValue != null/* && cboRol.SelectedValue != null*/)
            {
                validado = true;
            }
            return validado;
        }
    }
}