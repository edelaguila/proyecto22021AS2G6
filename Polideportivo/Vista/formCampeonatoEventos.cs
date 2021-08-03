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
    public partial class formCampeonatoEventos : Form
    {


        public formCampeonatoEventos()
        {
            InitializeComponent();
        }


        formCampeonato formOriginal = new formCampeonato();

        modeloCampeonato modeloOriginal;
        public formCampeonatoEventos(modeloCampeonato modelo, formCampeonato form)
        {
            // Este constructor es el que se utiliza para modificar datos
            InitializeComponent();
            btnModificarCampeonato.Visible = true;
            btnAgregarCampeonato.Visible = false;
            formOriginal = form;
            // Llenar combobox de deportes
            controladorDeporte deportes = new controladorDeporte();
            cboDeporte.DataSource = deportes.mostrarDeportes();
            cboDeporte.DisplayMember = "nombre";
            cboDeporte.ValueMember = "pkId";
            // Para obtener el Id original que se va a modificar
            modeloOriginal = modelo;
            // Modificar el texto del label
            lblJugadorEvento.Text = "MODIFICAR CAMPEONATO";

        }


        public formCampeonatoEventos(formCampeonato form)
        {
            formOriginal = form;
            // Este constructor es el que se utiliza para agregar datos
            InitializeComponent();
            btnModificarCampeonato.Visible = false;
            btnAgregarCampeonato.Visible = true;
            // Llenar combobox de deportes
            controladorDeporte deportes = new controladorDeporte();
            cboDeporte.DataSource = deportes.mostrarDeportes();
            cboDeporte.DisplayMember = "nombre";
            cboDeporte.ValueMember = "pkId";
            // Llenar combobox de tipo de campeonatos
            controladorTipoCampeonato tipo = new controladorTipoCampeonato();
            cboTipo.DataSource = tipo.mostrarTipoDeCampeonatos();
            cboTipo.DisplayMember = "tipo";
            cboTipo.ValueMember = "pkId";
            cboTipo.SelectedIndex = -1;
            // Modificar el texto del título
            lblJugadorEvento.Text = "AGREGAR CAMPEONATO";
        }



        // Actualizar el combobox de roles dependiendo del deporte seleccionado
        private void cboDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDeporte.SelectedIndex > -1)
            {
                // Llenar la combobox de equipo dependiendo del deporte elegido
                modeloEquipo modeloequipo = new modeloEquipo();
                modeloequipo.fkIdDeporte = stringAInt(cboDeporte.SelectedValue.ToString());
                controladorEquipo equipo = new controladorEquipo(modeloequipo);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrarForm(this);
        }


        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            controladorJugador modeloAgregar = new controladorJugador();
            modeloCampeonato modelo = new modeloCampeonato();
            //modelo.nombre = txtNombre.Text;
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
            
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarCampeonato_Click(object sender, EventArgs e)
        {
            controladorCampeonato controlador = new controladorCampeonato();
            controlador.ModificarCampeonato(modeloOriginal);
            formOriginal.actualizarTablaJugadores();
            cerrarForm(this);
        }

        private void btnAgregarCampeonato_Click(object sender, EventArgs e)
        {
            controladorCampeonato controlador = new controladorCampeonato();
            modeloCampeonato modelo = new modeloCampeonato();
            modelo.nombre = txtNombre.Text;
            modelo.fkIdDeporte = stringAInt(cboDeporte.SelectedValue.ToString());
            modelo.fkIdTipoCampeonato = stringAInt(cboTipo.SelectedValue.ToString());
            modelo.fechaInicio = dateFechaFinal.Text.Replace("-","/");
            modelo.fechaFinal = dateFechaInicio.Text.Replace("-", "/");
            controlador.AgregarCampeonato(modelo);
        }
    }
}
