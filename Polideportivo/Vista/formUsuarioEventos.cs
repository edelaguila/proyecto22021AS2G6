using BCrypt.Net;
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
    public partial class formUsuarioEventos : Form
    {
        private dtoUsuario modelo = new dtoUsuario();

        private controladorUsuario formOriginal = new controladorUsuario();
        private dtoUsuario modeloOriginal = new dtoUsuario();


        // Este constructor es el que se utiliza para agregar datos
        public formUsuarioEventos(controladorUsuario form)
        {
            formOriginal = form;
            InitializeComponent();
            btnAgregarUsuario.Visible = true;
            // Llenar combobox de deportes
            daoTipoUsuario daoTipoUsuario = new daoTipoUsuario();
            List<dtoTipoUsuario> lista = daoTipoUsuario.mostrarTipoUsuario();
            if (lista != null)
            {
                cboTipoUsuario.DataSource = daoTipoUsuario.mostrarTipoUsuario();
                cboTipoUsuario.DisplayMember = "nombre";
                cboTipoUsuario.ValueMember = "pkId";
            }
            else
            {
                cerrarForm(this);
            }
        }

        // Actualizar el combobox de roles dependiendo del deporte seleccionado
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrarForm(this);
        }

        private void btnAgregarTipoUsuario_Click(object sender, EventArgs e)
        {
            if (validarFormEventos())
            {
                controladorUsuario modeloAgregar = new controladorUsuario();
                llenarModeloConDatosIngresados();
                cerrarForm(this);
            }
        }

        /// <summary>
        /// Modifica jugador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void llenarModeloConDatosIngresados()
        {
            modelo.pkId = modeloOriginal.pkId;
            modelo.nombre = txtNombre.Text;
            modelo.contraseña = txtContraseña.Text;
            modelo.telefono = stringAInt(txtTelefono.Text.ToString());
            modelo.fkIdTipo = stringAInt(cboTipoUsuario.SelectedValue.ToString());
            var enhancedHashPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(modelo.contraseña, hashType: HashType.SHA384);
            var validatePassword = BCrypt.Net.BCrypt.EnhancedVerify(modelo.contraseña, enhancedHashPassword, hashType: HashType.SHA384);
        }
        
        private bool validarFormEventos()
        {
            bool validado = false;
            if (txtNombre.Text != "" && cboTipoUsuario.SelectedValue != null
                 && cboTipoUsuario.SelectedValue != null/* && cboRol.SelectedValue != null*/)
            {
                validado = true;
            }
            return validado;
        }

    }
}