using Controlador;
using Modelo;
using Modelo.DTO;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;
using Modelo.DAO;

namespace Vista
{
    public partial class formPartidoEventos : Form
    {
        public formPartidoEventos()
        {
            InitializeComponent();
        }

        private controladorPartido formOriginal = new controladorPartido();

        private dtoPartido modeloOriginal;

        public formPartidoEventos(dtoPartido modelo, controladorPartido form)
        {
            // Este constructor es el que se utiliza para modificar datos
            InitializeComponent();
            btnModificarPartido.Visible = true;
            btnAgregarPartido.Visible = false;
            formOriginal = form;
            txtAnotacionesE1.Text = modelo.anotacionesEquipo1.ToString();
            txtAnotacionesE2.Text = modelo.anotacionesEquipo2.ToString();
            txtCampo.Text = modelo.campo;
            // Llenar combobox de deportes
            daoCampeonato campeonato = new daoCampeonato();
            cboCampeonato.DataSource = campeonato.mostrarCampeonato();
            cboCampeonato.DisplayMember = "nombre";
            cboCampeonato.ValueMember = "pkId";
            //cboCampeonato.SelectedIndex = -1;

            daoEquipo equipo1 = new daoEquipo();
            cboEquipo1.DataSource = equipo1.mostrarEquipo();
            cboEquipo1.DisplayMember = "nombre";
            cboEquipo1.ValueMember = "nombre";
            //cboEquipo2.SelectedIndex = -1;

            daoEquipo equipo2 = new daoEquipo();
            cboEquipo2.DataSource = equipo2.mostrarEquipo();
            cboEquipo2.DisplayMember = "nombre";
            cboEquipo2.ValueMember = "nombre";
            //cboEquipo1.SelectedIndex = -1;

            daoEmpleado empleado = new daoEmpleado();
            cboEmpleado.DataSource = empleado.mostrarEmpleado();
            cboEmpleado.DisplayMember = "nombre";
            cboEmpleado.ValueMember = "pkId";
            //cboEmpleado.SelectedIndex = -1;

            daoEstadoPartido estado = new daoEstadoPartido();
            cboEstado.DataSource = estado.mostrarEstado();
            cboEstado.DisplayMember = "nombre";
            cboEstado.ValueMember = "pkId";
            //cboEstado.SelectedIndex = -1;

            daoFase fase = new daoFase();
            cboFase.DataSource = fase.mostrarFase();
            cboFase.DisplayMember = "nombre";
            cboFase.ValueMember = "pkId";
            // Para obtener el Id original que se va a modificar
            modeloOriginal = modelo;
            // Modificar el texto del label
            lblJugadorEvento.Text = "MODIFICAR PARTIDO";
        }

        public formPartidoEventos(controladorPartido form)
        {
            // Este constructor es el que se utiliza para agregar datos
            InitializeComponent();
            btnAgregarPartido.Visible = true;
            btnModificarPartido.Visible = false;
            // Llenar combobox
            daoCampeonato campeonato = new daoCampeonato();
            cboCampeonato.DataSource = campeonato.mostrarCampeonato();
            cboCampeonato.DisplayMember = "nombre";
            cboCampeonato.ValueMember = "pkId";
            cboCampeonato.SelectedIndex = -1;

            daoEquipo equipo1 = new daoEquipo();
            cboEquipo2.DataSource = equipo1.mostrarEquipo();
            cboEquipo2.DisplayMember = "nombre";
            cboEquipo2.ValueMember = "nombre";
            cboEquipo2.SelectedIndex = -1;

            daoEquipo equipo2 = new daoEquipo();
            cboEquipo1.DataSource = equipo2.mostrarEquipo();
            cboEquipo1.DisplayMember = "nombre";
            cboEquipo1.ValueMember = "nombre";
            cboEquipo1.SelectedIndex = -1;

            daoEmpleado empleado = new daoEmpleado();
            cboEmpleado.DataSource = empleado.mostrarEmpleado();
            cboEmpleado.DisplayMember = "nombre";
            cboEmpleado.ValueMember = "pkId";
            cboEmpleado.SelectedIndex = -1;

            daoEstadoPartido estado = new daoEstadoPartido();
            cboEstado.DataSource = estado.mostrarEstado();
            cboEstado.DisplayMember = "nombre";
            cboEstado.ValueMember = "pkId";
            cboEstado.SelectedIndex = -1;
            formOriginal = form;


            daoFase fase = new daoFase();
            cboFase.DataSource = fase.mostrarFase();
            cboFase.DisplayMember = "nombre";
            cboFase.ValueMember = "pkId";
            cboFase.SelectedIndex = -1;
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
            daoPartido daoPartido = new daoPartido();
            dtoPartido modelo = new dtoPartido();
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
            modelo.fkIdFase = stringAInt(cboFase.SelectedValue.ToString());
            daoPartido.agregarPartido(modelo);
            formOriginal.actualizarTablaPartido();
            cerrarForm(this);
        }

        private void btnModificarPartido_Click(object sender, EventArgs e)
        {
            daoPartido daoPartido = new daoPartido();
            dtoPartido modelo = new dtoPartido();
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
            modeloOriginal.fkIdFase = stringAInt(cboFase.SelectedValue.ToString());
            daoPartido.modificarPartido(modeloOriginal);
            formOriginal.actualizarTablaPartido();
            cerrarForm(this);
        }



        // Actualizar el combobox de roles dependiendo del deporte seleccionado
        //private void cboCameponato_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cboCampeonato.SelectedIndex > -1)
        //    {
        //        // Llenar la combobox de rol dependiendo del deporte elegido
        //        dtoCampeonato modelocamp = new dtoCampeonato();
        //        modelocamp.fkId = stringAInt(cboCampeonato.SelectedValue.ToString());
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