using Controlador;
using Modelo;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formParticipanteEventos : Form
    {
        private modeloParticipante modelo = new modeloParticipante();

        public formParticipanteEventos()
        {
            InitializeComponent();
        }

        private formParticipante formOriginal = new formParticipante();

        private modeloParticipante modeloOriginal = new modeloParticipante();

        public formParticipanteEventos(modeloParticipante modelo, formParticipante form)
        {
            // Este constructor es el que se utiliza para modificar datos
            InitializeComponent();
            btnModificarJugador.Visible = true;
            btnAgregarJugador.Visible = false;
            formOriginal = form;
        }

        public formParticipanteEventos(formParticipante form)
        {
            // Este constructor es el que se utiliza para agregar datos
            InitializeComponent();
            btnAgregarJugador.Visible = true;
            btnModificarJugador.Visible = false;
        }

        // Actualizar el combobox de roles dependiendo del deporte seleccionado
        private void cboDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDeporte.SelectedIndex > -1)
            {
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
                cerrarForm(this);
            }
        }

        /// <summary>
        /// Hola
        /// </summary>
        private void llenarModeloConDatosIngresados()
        {
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