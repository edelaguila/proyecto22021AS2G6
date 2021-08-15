using Controlador;
using Modelo;
using Modelo.DAO;
using Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formParticipanteEventos : Form
    {
        private dtoParticipante modelo = new dtoParticipante();

        private controladorParticipante formOriginal = new controladorParticipante();

        private dtoParticipante modeloOriginal = new dtoParticipante();

        public formParticipanteEventos(dtoParticipante modelo, controladorParticipante form)
        {
            // Este constructor es el que se utiliza para modificar datos
            InitializeComponent();
            btnModificarParticipante.Visible = true;
            btnAgregarParticipante.Visible = false;
            formOriginal = form;
            txtPuntos.Text = modelo.puntos.ToString();
            // Llenar combobox de deportes
            daoParticipante daoParticipante = new daoParticipante();
            daoCampeonato campeonato = new daoCampeonato();
            cboCampeonato.DataSource = campeonato.mostrarCampeonato();
            cboCampeonato.DisplayMember = "nombre";
            cboCampeonato.ValueMember = "pkId";
            cboCampeonato.SelectedItem = cboCampeonato.Items[0];

            daoEquipo equipo = new daoEquipo();
            cboEquipo.DataSource = equipo.mostrarEquipo();
            cboEquipo.DisplayMember = "nombre";
            cboEquipo.ValueMember = "pkId";
            cboEquipo.SelectedItem = cboEquipo.Items[0];

            daoFase fase = new daoFase();
            cboFase.DataSource = fase.mostrarFase();
            cboFase.DisplayMember = "nombre";
            cboFase.ValueMember = "pkId";
            cboFase.SelectedItem = cboFase.Items[0];

            daoEstadoParticipante estado = new daoEstadoParticipante();
            cboEstado.DataSource = estado.mostrarEstadoParticipante();
            cboEstado.DisplayMember = "nombre";
            cboEstado.ValueMember = "pkId";
            cboEstado.SelectedItem = cboEstado.Items[0];
            //cboEstado.SelectedIndex = -1;

            // Para obtener el Id original que se va a modificar
            modeloOriginal = modelo;
            // Modificar el texto del label
            lblJugadorEvento.Text = "MODIFICAR PARTICIPANTE";
        }

        public formParticipanteEventos(controladorParticipante form)
        {
            // Este constructor es el que se utiliza para agregar datos

            InitializeComponent();
            btnAgregarParticipante.Visible = true;
            btnModificarParticipante.Visible = false;
            // Llenar combobox de deportes
            daoDeporte daoDeporte = new daoDeporte();
            daoParticipante daoParticipante = new daoParticipante();
            daoCampeonato campeonato = new daoCampeonato();
            cboCampeonato.DataSource = campeonato.mostrarCampeonato();
            cboCampeonato.DisplayMember = "nombre";
            cboCampeonato.ValueMember = "pkId";
            if (cboCampeonato.SelectedIndex != -1)
            {
                cboCampeonato.SelectedItem = cboCampeonato.Items[0];
            }

            daoEquipo equipo = new daoEquipo();
            cboEquipo.DataSource = equipo.mostrarEquipo();
            cboEquipo.DisplayMember = "nombre";
            cboEquipo.ValueMember = "pkId";
            if (cboEquipo.SelectedIndex != -1)
            {
                cboEquipo.SelectedItem = cboEquipo.Items[0];
            }

            daoFase fase = new daoFase();
            cboFase.DataSource = fase.mostrarFase();
            cboFase.DisplayMember = "nombre";
            cboFase.ValueMember = "pkId";
            if (cboFase.SelectedIndex != -1)
            {
                cboFase.SelectedItem = cboFase.Items[0];
            }

            daoEstadoParticipante estado = new daoEstadoParticipante();
            cboEstado.DataSource = estado.mostrarEstadoParticipante();
            cboEstado.DisplayMember = "nombre";
            cboEstado.ValueMember = "pkId";
            if (cboEstado.SelectedIndex != -1)
            {
                cboEstado.SelectedItem = cboEstado.Items[0];
            }

            formOriginal = form;
            // Modificar el texto del título
            lblJugadorEvento.Text = "AGREGAR PARTICIPANTE";
        }

        // Actualizar el combobox de roles dependiendo del deporte seleccionado
        //private void cboDeporte_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cboCampeonato.SelectedIndex > -1)
        //    {
        //        // Llenar la combobox de rol dependiendo del deporte elegido
        //        dtoRol modelorol = new dtoRol();
        //        modelorol.fkIdDeporte = stringAInt(cboCampeonato.SelectedValue.ToString());
        //        daoRol rol = new daoRol();
        //        cboEstado.DataSource = rol.mostrarRolesPorDeporte(modelorol);
        //        cboEstado.DisplayMember = "nombre";
        //        cboEstado.ValueMember = "pkId";
        //        // Llenar la combobox de equipo dependiendo del deporte elegido
        //        dtoEquipo modeloequipo = new dtoEquipo();
        //        modeloequipo.fkIdDeporte = stringAInt(cboCampeonato.SelectedValue.ToString());
        //        daoEquipo equipo = new daoEquipo();
        //        cboEquipo.DataSource = equipo.mostrarEquipoPorDeporte(modeloequipo);
        //        cboEquipo.DisplayMember = "nombre";
        //        cboEquipo.ValueMember = "pkId";
        //    }
        //}

        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrarForm(this);
        }
        //Agrega un nuevo participante a la tabla con el daoParticipante llamando el método agregarParticipante
        private void btnAgregarParticipante_Click(object sender, EventArgs e)
        {
            if (validarFormEventos())
            {
                daoParticipante daoParticipante = new daoParticipante();
                llenarModeloConDatosIngresados();
                daoParticipante.agregarParticipante(modelo);
                formOriginal.actualizarTablaParticipante();
                cerrarForm(this);
            }
        }

        /// <summary>
        /// Modifica participante dentro de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarParticipante_Click(object sender, EventArgs e)
        {
            if (validarFormEventos())
            {
                daoParticipante daoParticipante = new daoParticipante();
                llenarModeloConDatosIngresados();
                daoParticipante.modificarParticipantes(modelo);
                formOriginal.actualizarTablaParticipante();
                cerrarForm(this);
            }
        }

        /// <summary>
        /// Llena el modelo con los datos ingresados previamente en la base de datos 
        /// </summary>
        private void llenarModeloConDatosIngresados()
        {
            modelo.pkId = modeloOriginal.pkId;
            modelo.puntos = stringAInt(txtPuntos.Text);
            modelo.fkIdCampeonato = stringAInt(cboCampeonato.SelectedValue.ToString());
            modelo.fkIdEquipo = stringAInt(cboEquipo.SelectedValue.ToString());
            modelo.fkIdFase = stringAInt(cboFase.SelectedValue.ToString());
            modelo.fkIdEstadoParticipante = stringAInt(cboEstado.SelectedValue.ToString());
        }
        /// <summary>
        /// Valida los forms con los combos y asi ser enviado al formParticipante
        /// </summary>
        /// <returns></returns>
        private bool validarFormEventos()
        {
            bool validado = false;
            if (txtPuntos.Text != "" && cboCampeonato.SelectedValue != null
                 && cboEquipo.SelectedValue != null/* && cboRol.SelectedValue != null*/)
            {
                validado = true;
            }
            return validado;
        }
        /// <summary>
        /// Método que manda a llamar al daoParticipante que contiene el método modificarParticipante que sirve para modificar participantes dentro de la tablaParticipante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarJugador_Click(object sender, EventArgs e)
        {
            if (validarFormEventos())
            {
                daoParticipante daoJugador = new daoParticipante();
                llenarModeloConDatosIngresados();
                daoJugador.modificarParticipantes(modelo);
                formOriginal.actualizarTablaParticipante();
                cerrarForm(this);
            }
        }
        /// <summary>
        /// Método que manda a llamar al daoParticipante al método agregarParticipante que sirve para agregar participantes dentro de la tablaParticipante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarParticipante_Click_1(object sender, EventArgs e)
        {
            if (validarFormEventos())
            {
                daoParticipante daoParticipante = new daoParticipante();
                llenarModeloConDatosIngresados();
                daoParticipante.agregarParticipante(modelo);
                formOriginal.actualizarTablaParticipante();
                cerrarForm(this);
            }
        }
    }
}