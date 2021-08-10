using Controlador;
using Modelo;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;
using Modelo.DAO;
using Modelo.DTO;

namespace Vista
{
    public partial class formEquipoEventos : Form
    {
        private daoEquipo controlador = new daoEquipo();
        private dtoEquipo modelo = new dtoEquipo();

        private controladorEquipo formOriginal = new controladorEquipo();
        private dtoEquipo modeloOriginal = new dtoEquipo();

        public formEquipoEventos(dtoEquipo modelo, controladorEquipo form)
        {
            // Este constructor es el que se utiliza para modificar datos
            InitializeComponent();
            controladorEquipoEventos controladorEmpleado = new controladorEquipoEventos(modelo, this, form);
        }

        public formEquipoEventos(controladorEquipo form)
        {
            // Este constructor es el que se utiliza para agregar datos
            InitializeComponent();
            controladorEquipoEventos controladorEmpleado = new controladorEquipoEventos(this, form);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrarForm(this);
        }

        private void btnModificarEquipo_Click(object sender, EventArgs e)
        {
            llenarModeloConOpcionesSeleccionadas();
            controlador.modificarEquipo(modelo);
            formOriginal.actualizarTablaJugadores();
            cerrarForm(this);
        }

        public void llenarCboDeporte()
        {
            daoDeporte daoDeporte = new daoDeporte();
            cboDeporte.DataSource = daoDeporte.mostrarDeportes();
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

        private void cboDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}