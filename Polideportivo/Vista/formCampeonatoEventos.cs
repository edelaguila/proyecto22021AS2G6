using Controlador;
using Modelo;
using System;
using Modelo.DAO;
using System.Windows.Forms;
using static Vista.utilidadForms;
using Modelo.DTO;

namespace Vista
{
    public partial class formCampeonatoEventos : Form
    {
        public formCampeonatoEventos()
        {
            InitializeComponent();
        }

        private controladorCampeonato formOriginal;

        private dtoCampeonato modeloOriginal;

        public formCampeonatoEventos(dtoCampeonato modelo, controladorCampeonato form)
        {
            // Este constructor es el que se utiliza para modificar datos
            InitializeComponent();
            btnModificarCampeonato.Visible = true;
            btnAgregarCampeonato.Visible = false;
            formOriginal = form;
            // Llenar combobox de deportes
            daoDeporte daoDeporte = new daoDeporte();
            cboDeporte.DataSource = daoDeporte.mostrarDeportes();
            cboDeporte.DisplayMember = "nombre";
            cboDeporte.ValueMember = "pkId";
            // Llenar combobox de tipo de campeonatos
            daoTipoCampeonato tipo = new daoTipoCampeonato();
            cboTipo.DataSource = tipo.mostrarTipoDeCampeonatos();
            cboTipo.DisplayMember = "tipo";
            cboTipo.ValueMember = "pkId";
            cboTipo.SelectedIndex = -1;
            // Para obtener el Id original que se va a modificar
            modeloOriginal = modelo;
            // Modificar el texto del label
            txtNombre.Text = modelo.nombre;
            lblJugadorEvento.Text = "MODIFICAR CAMPEONATO";
        }

        public formCampeonatoEventos(controladorCampeonato form)
        {
            formOriginal = form;
            // Este constructor es el que se utiliza para agregar datos
            InitializeComponent();
            btnModificarCampeonato.Visible = false;
            btnAgregarCampeonato.Visible = true;
            // Llenar combobox de deportes
            daoDeporte daoDeporte = new daoDeporte();
            cboDeporte.DataSource = daoDeporte.mostrarDeportes();
            cboDeporte.DisplayMember = "nombre";
            cboDeporte.ValueMember = "pkId";
            // Llenar combobox de tipo de campeonatos
            daoTipoCampeonato tipo = new daoTipoCampeonato();
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
                dtoEquipo modeloequipo = new dtoEquipo();
                modeloequipo.fkIdDeporte = stringAInt(cboDeporte.SelectedValue.ToString());
            }
        }
        /// <summary>
        /// Cerrar el form presionando el bot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrarForm(this);
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            controladorJugador modeloAgregar = new controladorJugador();
            dtoCampeonato modelo = new dtoCampeonato();
            //modelo.nombre = txtNombre.Text;
            //modelo.anotaciones = stringAInt(txtAnotaciones.Text);
            //modelo.fkIdDeporte = stringAInt(cboDeporte.SelectedValue.ToString());
            //modelo.fkIdEquipo = stringAInt(cboEquipo.SelectedValue.ToString());
            //modelo.fkIdRol = stringAInt(cboRol.SelectedValue.ToString());
            //modeloAgregar.agregarJugador(modelo);
            formOriginal.actualizarTabla();
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
            daoCampeonato controlador = new daoCampeonato();
            modeloOriginal.nombre = txtNombre.Text;
            modeloOriginal.fkIdDeporte = stringAInt(cboDeporte.SelectedValue.ToString());
            modeloOriginal.fkIdTipoCampeonato = stringAInt(cboTipo.SelectedValue.ToString());
            modeloOriginal.fechaInicio = dateFechaInicio.Value.ToString("yyyy-MM-dd");
            modeloOriginal.fechaFinal = dateFechaFinal.Value.ToString("yyyy-MM-dd");
            controlador.ModificarCampeonato(modeloOriginal);
            formOriginal.actualizarTabla();
            cerrarForm(this);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarCampeonato_Click(object sender, EventArgs e)
        {
            daoCampeonato controlador = new daoCampeonato();
            dtoCampeonato modelo = new dtoCampeonato();
            modelo.nombre = txtNombre.Text;
            modelo.fkIdDeporte = stringAInt(cboDeporte.SelectedValue.ToString());
            modelo.fkIdTipoCampeonato = stringAInt(cboTipo.SelectedValue.ToString());
            modelo.fechaInicio = dateFechaInicio.Value.ToString("yyyy-MM-dd");
            modelo.fechaFinal = dateFechaFinal.Value.ToString("yyyy-MM-dd");
            controlador.AgregarCampeonato(modelo);
            formOriginal.actualizarTabla();
            cerrarForm(this);
        }
    }
}