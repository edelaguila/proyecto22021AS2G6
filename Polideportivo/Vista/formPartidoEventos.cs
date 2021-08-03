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
    public partial class formPartidoEventos : Form
    {


        public formPartidoEventos()
        {
            InitializeComponent();
        }


        formPartido formOriginal = new formPartido();

        modeloPartido modeloOriginal;
        public formPartidoEventos(modeloPartido modelo, formPartido form)
        {
            // Este constructor es el que se utiliza para modificar datos
            InitializeComponent();
            btnModificarPartido.Visible = true;
            btnAgregarPartido.Visible = false;
            formOriginal = form;
            txtFase.Text = modelo.fase;
            txtEstado.Text = modelo.estado;
            txtEquipo1.Text = modelo.equipo1;
            txtEquipo2.Text = modelo.equipo2;
            txtCampo.Text = modelo.campo;
            // Llenar combobox de deportes
            controladorDeporte deportes = new controladorDeporte();
            cboCampeonato.DataSource = deportes.mostrarDeportes();
            cboCampeonato.DisplayMember = "nombre";
            cboCampeonato.ValueMember = "pkId";
            // Para obtener el Id original que se va a modificar
            modeloOriginal = modelo;
            // Modificar el texto del label
            lblJugadorEvento.Text = "MODIFICAR JUGADOR";

        }


        public formPartidoEventos(formPartido form)
        {
            // Este constructor es el que se utiliza para agregar datos
            InitializeComponent();
            btnAgregarPartido.Visible = true;
            btnModificarPartido.Visible = false;
            // Llenar combobox de deportes
            controladorDeporte deportes = new controladorDeporte();
            cboCampeonato.DataSource = deportes.mostrarDeportes();
            cboCampeonato.DisplayMember = "nombre";
            cboCampeonato.ValueMember = "pkId";
            cboCampeonato.SelectedIndex = -1;
            formOriginal = form;
            // Modificar el texto del título
            lblJugadorEvento.Text = "AGREGAR JUGADOR";
        }



        // Actualizar el combobox de roles dependiendo del deporte seleccionado
        //private void cboDeporte_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cboCampeonato.SelectedIndex > -1)
        //    {
        //        // Llenar la combobox de rol dependiendo del deporte elegido
        //        modeloRol modelorol = new modeloRol();
        //        modelorol.fkIdDeporte = stringAInt(cboCampeonato.SelectedValue.ToString());
        //        controladorRol rol = new controladorRol(modelorol);
        //        cboResultado.DataSource = rol.mostrarRolesPorDeporte();
        //        cboResultado.DisplayMember = "nombre";
        //        cboResultado.ValueMember = "pkId";

        //        // Llenar la combobox de equipo dependiendo del deporte elegido
        //        modeloEquipo modeloequipo = new modeloEquipo();
        //        modeloequipo.fkIdDeporte = stringAInt(cboCampeonato.SelectedValue.ToString());
        //        controladorEquipo equipo = new controladorEquipo(modeloequipo);
        //        cboEmpleado.DataSource = equipo.mostrarEquipoPorDeporte();
        //        cboEmpleado.DisplayMember = "nombre";
        //        cboEmpleado.ValueMember = "pkId";
        //    }
        //}

        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrarForm(this);
        }


        private void btnAgregarPartido_Click(object sender, EventArgs e)
        {
            controladorPartido modeloAgregar = new controladorPartido();
            modeloPartido modelo = new modeloPartido();
            modelo.fase = txtFase.Text;
            modelo.estado = txtEstado.Text;
            modelo.equipo1 = txtEquipo1.Text;
            modelo.equipo2 = txtEquipo2.Text;
            modelo.campo = txtCampo.Text;
            modelo.fkIdCampeonato = stringAInt(cboCampeonato.SelectedValue.ToString());
            modelo.fkIdEmpleado = stringAInt(cboEmpleado.SelectedValue.ToString());
            modelo.fkIdResultado = stringAInt(cboResultado.SelectedValue.ToString());
            modeloAgregar.agregarPartido(modelo);
            //formOriginal.actualizarTablaPartido();
            cerrarForm(this);
        }

        private void btnModificarJugador_Click(object sender, EventArgs e)
        {
            controladorJugador modeloModificar = new controladorJugador();
            modeloJugador modelo = new modeloJugador();
            modelo.pkId = modeloOriginal.pkId;
            modelo.nombre = txtFase.Text;
            modelo.anotaciones = stringAInt(txtEquipo1.Text);
            modelo.fkIdDeporte = stringAInt(cboCampeonato.SelectedValue.ToString());
            modelo.fkIdEquipo = stringAInt(cboEmpleado.SelectedValue.ToString());
            modelo.fkIdRol = stringAInt(cboResultado.SelectedValue.ToString());
            modeloModificar.modificarJugador(modelo);
            formOriginal.actualizarTablaJugadores();
            cerrarForm(this);
        }
    }
}
