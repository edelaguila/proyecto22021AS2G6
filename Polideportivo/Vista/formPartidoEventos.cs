using Controlador;
using Modelo;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formPartidoEventos : Form
    {
        public formPartidoEventos()
        {
            InitializeComponent();
        }

        private formPartido formOriginal = new formPartido();

        private modeloPartido modeloOriginal;

        public formPartidoEventos(modeloPartido modelo, formPartido form)
        {
            // Este constructor es el que se utiliza para modificar datos
            InitializeComponent();
            btnModificarPartido.Visible = true;
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

            controladorEmpleado empleado = new controladorEmpleado();
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
            lblJugadorEvento.Text = "MODIFICAR PARTIDO";
        }

        public formPartidoEventos(formPartido form)
        {
            // Este constructor es el que se utiliza para agregar datos
            InitializeComponent();
            btnAgregarPartido.Visible = true;
            btnModificarPartido.Visible = false;
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

            controladorEmpleado empleado = new controladorEmpleado();
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
            controladorPartido controlador = new controladorPartido();
            modeloPartido modelo = new modeloPartido();
            modelo.fase = txtFase.Text;
            modelo.campo = txtCampo.Text;
            modelo.equipo1 = cboEquipo1.Text;
            modelo.equipo2 = cboEquipo2.Text;
            string fecha = dateFecha.Value.ToString("yyyy-MM-dd");
            string hora = dateHora.Value.ToString("HH:mm");
            modelo.fecha = fecha + " " + hora;
            modelo.anotacionesEquipo1 = stringAInt(txtAnotacionesE1.ToString());
            modelo.anotacionesEquipo2 = stringAInt(txtAnotacionesE2.ToString());
            modelo.fkIdCampeonato = stringAInt(cboCampeonato.SelectedValue.ToString());
            modelo.fkIdEmpleado = stringAInt(cboEmpleado.SelectedValue.ToString());
            modelo.fkIdEstadoPartido = stringAInt(cboEstado.SelectedValue.ToString());
            controlador.agregarPartido(modelo);
            formOriginal.actualizarTablaPartido();
            cerrarForm(this);
        }

        private void btnModificarPartido_Click(object sender, EventArgs e)
        {
            controladorPartido controlador = new controladorPartido();
            modeloPartido modelo = new modeloPartido();
            modeloOriginal.fase = txtFase.Text;
            modeloOriginal.campo = txtCampo.Text;
            modeloOriginal.equipo1 = cboEquipo1.Text;
            modeloOriginal.equipo2 = cboEquipo2.Text;
            string fecha = dateFecha.Value.ToString("yyyy-MM-dd");
            string hora = dateHora.Value.ToString("HH:mm");
            modeloOriginal.fecha = fecha + " " + hora;
            modeloOriginal.anotacionesEquipo1 = stringAInt(txtAnotacionesE1.ToString());
            modeloOriginal.anotacionesEquipo2 = stringAInt(txtAnotacionesE2.ToString());
            modeloOriginal.fkIdCampeonato = stringAInt(cboCampeonato.SelectedValue.ToString());
            modeloOriginal.fkIdEmpleado = stringAInt(cboEmpleado.SelectedValue.ToString());
            modeloOriginal.fkIdEstadoPartido = stringAInt(cboEstado.SelectedValue.ToString());
            controlador.modificarPartido(modeloOriginal);
            formOriginal.actualizarTablaPartido();
            cerrarForm(this);
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