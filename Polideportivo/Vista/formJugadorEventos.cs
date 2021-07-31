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

namespace Polideportivo.Vista
{
    public partial class formJugadorEventos : Form
    {

        

        public formJugadorEventos()
        {
            InitializeComponent();
        }

        formJugador formOriginal = new formJugador();


        public formJugadorEventos(modeloJugador modelo, formJugador form)
        {
            // Este constructor es el que se utiliza para modificar datos
            InitializeComponent();
            btnAgregarJugador.Visible = false;
            btnModificar.Visible = true;
            formOriginal = form;
            txtNombre.Text = modelo.nombre;
            txtAnotaciones.Text = modelo.anotaciones.ToString();

        }

        
        public formJugadorEventos(formJugador form)
        {
            // Este constructor es el que se utiliza para agregar datos
            InitializeComponent();
            btnAgregarJugador.Visible = true;
            btnModificar.Visible = false;
            // Llenar combobox de deportes
            controladorDeporte deportes = new controladorDeporte();
            cboDeporte.DataSource = deportes.mostrarDeportes();
            cboDeporte.DisplayMember = "nombre";
            cboDeporte.ValueMember = "pkId";

        }


        public void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            controladorJugador modeloAgregar = new controladorJugador();
            modeloJugador modelo = new modeloJugador();
            modelo.nombre = txtNombre.Text;
            modelo.anotaciones = utilidadForms.stringAInt(txtAnotaciones.Text);
            modelo.fkIdEquipo = utilidadForms.stringAInt(cboEquipo.SelectedValue.ToString());
            modelo.fkIdRol = utilidadForms.stringAInt(cboRol.SelectedValue.ToString());
            modeloAgregar.agregarJugador(modelo);
            formOriginal.actualizarTablaJugadores();
            utilidadForms.cerrarForm(this);
            
        }

        private void formJugadorEventos_Load(object sender, EventArgs e)
        {
            

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void parrotGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            controladorJugador modeloModificar = new controladorJugador();
            modeloJugador modelo = new modeloJugador();
            modelo.nombre = txtNombre.Text;
            modelo.anotaciones = utilidadForms.stringAInt(txtAnotaciones.Text);
            modelo.fkIdEquipo = utilidadForms.stringAInt(cboEquipo.SelectedValue.ToString());
            modelo.fkIdRol = utilidadForms.stringAInt(cboRol.SelectedValue.ToString());
            modeloModificar.modificarJugador(modelo);
            formOriginal.actualizarTablaJugadores();
            utilidadForms.cerrarForm(this);
        }

        private void cboEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Actualizar el combobox de roles dependiendo del deporte seleccionado
        private void cboDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDeporte.SelectedIndex > -1)
            {
                modeloRol modelo = new modeloRol();
                controladorRol rol = new controladorRol(modelo);
                modelo.fkIdDeporte = utilidadForms.stringAInt(cboDeporte.SelectedValue.ToString());
                cboRol.DataSource = rol.mostrarRolesPorDeporte();
                cboRol.DisplayMember = "nombre";
                cboRol.ValueMember = "pkId";
            }
        }

        private void cboDeporte_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void cboDeporte_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //controladorRol rol = new controladorRol();
            //modeloRol modelo = new modeloRol();
            //modelo.fkIdDeporte = utilidadForms.stringAInt(cboDeporte.SelectedValue.ToString());
            //cboRol.DataSource = rol.mostrarRolesPorDeporte(modelo);
            //cboRol.DisplayMember = "nombre";
            //cboRol.ValueMember = "pkId";
        }

        private void cboDeporte_Layout(object sender, LayoutEventArgs e)
        {

        }
    }
}
