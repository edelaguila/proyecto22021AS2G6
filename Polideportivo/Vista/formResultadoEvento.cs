using Controlador;
using Modelo;
using Modelo.DTO;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formResultadoEvento : Form
    {
        public formResultadoEvento()
        {
            InitializeComponent();
        }

        private modeloResultado modelo = new modeloResultado();

        private formResultado formOriginal = new formResultado();

        private modeloResultado modeloOriginal;

        public formResultadoEvento(modeloResultado modelo, formResultado form)
        {
            // Este constructor es el que se utiliza para modificar datos
            InitializeComponent();
            btnModificarResultado.Visible = true;
            btnAgregarPartido.Visible = false;
            formOriginal = form;
            txtFase.Text = modelo.fase;
            txtAnotacionesE1.Text = modelo.anotacionesEquipo1.ToString();
            txtAnotacionesE2.Text = modelo.anotacionesEquipo2.ToString();
            txtCampo.Text = modelo.campo;
            // Llenar combobox de deportes
            controladorCampeonato campeonato = new controladorCampeonato();
            cboCampeonato.DataSource = campeonato.mostrarCampeonato();
            cboCampeonato.DisplayMember = "nombre";
            cboCampeonato.ValueMember = "pkId";
            //cboCampeonato.SelectedIndex = -1;

            controladorEquipo equipo1 = new controladorEquipo();
            cboEquipo2.DataSource = equipo1.mostrarEquipo();
            cboEquipo2.DisplayMember = "nombre";
            cboEquipo2.ValueMember = "nombre";
            //cboEquipo2.SelectedIndex = -1;

            controladorEquipo equipo2 = new controladorEquipo();
            cboEquipo1.DataSource = equipo2.mostrarEquipo();
            cboEquipo1.DisplayMember = "nombre";
            cboEquipo1.ValueMember = "nombre";
            //cboEquipo1.SelectedIndex = -1;

            daoEmpleado empleado = new daoEmpleado();
            cboEmpleado.DataSource = empleado.mostrarEmpleado();
            cboEmpleado.DisplayMember = "nombre";
            cboEmpleado.ValueMember = "pkId";
            //cboEmpleado.SelectedIndex = -1;

            controladorEstado estado = new controladorEstado();
            cboEstado.DataSource = estado.mostrarEstado();
            cboEstado.DisplayMember = "nombre";
            cboEstado.ValueMember = "pkId";
            //cboEstado.SelectedIndex = -1;
            // Para obtener el Id original que se va a modificar
            modeloOriginal = modelo;
            // Modificar el texto del label
            lblJugadorEvento.Text = "INGRESAR RESULTADO";
        }

        public formResultadoEvento(formResultado form)
        {
            // Este constructor es el que se utiliza para agregar datos
            InitializeComponent();
            btnAgregarPartido.Visible = true;
            btnModificarResultado.Visible = false;
            // Llenar combobox
            controladorCampeonato campeonato = new controladorCampeonato();
            cboCampeonato.DataSource = campeonato.mostrarCampeonato();
            cboCampeonato.DisplayMember = "nombre";
            cboCampeonato.ValueMember = "pkId";
            cboCampeonato.SelectedIndex = -1;

            controladorEquipo equipo1 = new controladorEquipo();
            cboEquipo2.DataSource = equipo1.mostrarEquipo();
            cboEquipo2.DisplayMember = "nombre";
            cboEquipo2.ValueMember = "nombre";
            cboEquipo2.SelectedIndex = -1;

            controladorEquipo equipo2 = new controladorEquipo();
            cboEquipo1.DataSource = equipo2.mostrarEquipo();
            cboEquipo1.DisplayMember = "nombre";
            cboEquipo1.ValueMember = "nombre";
            cboEquipo1.SelectedIndex = -1;

            daoEmpleado empleado = new daoEmpleado();
            cboEmpleado.DataSource = empleado.mostrarEmpleado();
            cboEmpleado.DisplayMember = "nombre";
            cboEmpleado.ValueMember = "pkId";
            cboEmpleado.SelectedIndex = -1;

            controladorEstado estado = new controladorEstado();
            cboEstado.DataSource = estado.mostrarEstado();
            cboEstado.DisplayMember = "nombre";
            cboEstado.ValueMember = "pkId";
            cboEstado.SelectedIndex = -1;
            formOriginal = form;

            formOriginal = form;
            //Modificar el texto del título
            lblJugadorEvento.Text = "AGREGAR PARTIDO";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrarForm(this);
        }

        private void btnAgregarPartido_Click(object sender, EventArgs e)
        {
        }

        private void btnModificarResultado_Click(object sender, EventArgs e)
        {
            controladorResultado modeloModificar = new controladorResultado();
            llenarModeloConDatosIngresados();

            modeloModificar.modificarPartido(modelo);
            formOriginal.actualizarTablaResultado();
            cerrarForm(this);

            cerrarForm(this);
        }

        private void llenarModeloConDatosIngresados()
        {
            modelo.fase = txtFase.Text;
            modelo.campo = txtCampo.Text;
            modelo.equipo1 = cboEquipo1.Text;
            modelo.equipo2 = cboEquipo2.Text;
            modelo.pkId = modeloOriginal.pkId;
            string fecha = dateFecha.Value.ToString("yyyy-MM-dd");
            string hora = dateHora.Value.ToString("HH:mm");
            modelo.fecha = fecha + " " + hora;
            modelo.anotacionesEquipo1 = stringAInt(txtAnotacionesE1.Text);
            modelo.anotacionesEquipo2 = stringAInt(txtAnotacionesE2.Text);
            modelo.fkIdCampeonato = stringAInt(cboCampeonato.SelectedValue.ToString());
            modelo.fkIdEmpleado = stringAInt(cboEmpleado.SelectedValue.ToString());
            modelo.fkIdEstadoPartido = stringAInt(cboEstado.SelectedValue.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cdrFecha_ValueChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
    }
}