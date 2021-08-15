using Controlador;
using Modelo;
using Modelo.DAO;
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

        private dtoPartido modelo = new dtoPartido();

        private formResultado formOriginal = new formResultado();

        private dtoPartido modeloOriginal;

        public formResultadoEvento(dtoPartido modelo, formResultado form)
        {
            // Este constructor es el que se utiliza para modificar datos
            InitializeComponent();
            btnModificarResultado.Visible = true;
            formOriginal = form;
            txtAnotacionesE1.Text = modelo.anotacionesEquipo1.ToString();
            txtAnotacionesE2.Text = modelo.anotacionesEquipo2.ToString();
            // Llenar combobox de deportes
            daoCampeonato campeonato = new daoCampeonato();
            //cboCampeonato.SelectedIndex = -1;

            daoEquipo equipo1 = new daoEquipo();
            cboEquipo2.DataSource = equipo1.mostrarEquipo();
            cboEquipo2.DisplayMember = "nombre";
            cboEquipo2.ValueMember = "nombre";
            //cboEquipo2.SelectedIndex = -1;

            daoEquipo equipo2 = new daoEquipo();
            cboEquipo1.DataSource = equipo2.mostrarEquipo();
            cboEquipo1.DisplayMember = "nombre";
            cboEquipo1.ValueMember = "nombre";
            //cboEquipo1.SelectedIndex = -1;

            daoEmpleado empleado = new daoEmpleado();

            //cboEmpleado.SelectedIndex = -1;

            daoEstadoPartido estado = new daoEstadoPartido();



            daoFase fase = new daoFase();

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

            btnModificarResultado.Visible = false;
            // Llenar combobox
            daoCampeonato campeonato = new daoCampeonato();


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
  

            daoEstadoPartido estado = new daoEstadoPartido();



            

            formOriginal = form;
            //Modificar el texto del título
            lblJugadorEvento.Text = "AGREGAR PARTIDO";
        }
        /// <summary>
        /// Método que al presionar el boton de salir del form, lo cierra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrarForm(this);
        }
        /// <summary>
        /// Método que manda a llamar al daoPartido al método agregarPartido que sirve para agregar partidos dentro de la tablaPartido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarPartido_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Método que manda a llamar al daoResultado que contiene el método modificarResultado que sirve para modificar resultados dentro de la tablaPartido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarResultado_Click(object sender, EventArgs e)
        {
            daoPartido modeloModificar = new daoPartido();
            llenarModeloConDatosIngresados();

            modeloModificar.modificarResultado(modelo);
            formOriginal.actualizarTablaResultado();
            cerrarForm(this);

            cerrarForm(this);
        }
        /// <summary>
        ///  Método que sirve para llenar el modelo con lo que se ingresó dentro del textox de resultado
        /// </summary>
        private void llenarModeloConDatosIngresados()
        {

            modelo.equipo1 = cboEquipo1.Text;
            modelo.equipo2 = cboEquipo2.Text;
            modelo.pkId = modeloOriginal.pkId;
            modelo.anotacionesEquipo1 = stringAInt(txtAnotacionesE1.Text);
            modelo.anotacionesEquipo2 = stringAInt(txtAnotacionesE2.Text);

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