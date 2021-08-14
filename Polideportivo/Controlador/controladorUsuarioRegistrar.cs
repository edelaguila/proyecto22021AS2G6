using BCrypt.Net;
using Modelo.DAO;
using Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista;
using static Vista.utilidadForms;
namespace Controlador
{
    /// <summary>
    /// Clase que gestiona la tabla de UsuarioRegistrar de la base de datos
    /// </summary>
    public class controladorUsuarioRegistrar
    {
        formUsuarioRegistrar vista;
        daoUsuario daoUsuario = new daoUsuario();
        dtoUsuario dtoUsuario = new dtoUsuario();
        /// <summary>
        /// Método que sirve para cargar los eventos que van dentro de cada elemento en el formRegistrarUsuario
        /// </summary>
        /// <param name="Vista"></param>
        public controladorUsuarioRegistrar(formUsuarioRegistrar Vista)
        {
            vista = Vista;
            // Eventos
            vista.btnRegistrarUsuario.Click += new EventHandler(clickUsuarioRegistrar);
            vista.Load += new EventHandler(cargarForm);
        }
        /// <summary>
        /// Método que sirve para cargar los datos dentro del form de registrar usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cargarForm(object sender , EventArgs e)
        {
            daoTipoUsuario daoTipoUsuario = new daoTipoUsuario();
            vista.cboTipoUsuario.DataSource = daoTipoUsuario.mostrarTipoUsuario();
            vista.cboTipoUsuario.DisplayMember = "nombre";
            vista.cboTipoUsuario.ValueMember = "pkId";
            vista.cboTipoUsuario.SelectedIndex = -1;
        }
        /// <summary>
        /// Método que sirve para registrar nuevos usuarios y guardar todos sus datos dentro de la base de datos
        /// los cuales contiene nombre, contraseña la cual se hashea gracias a BCrypt y tambien el telefono y su rol dentro de la empresa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void clickUsuarioRegistrar(object sender, EventArgs e) 
        {
            var contraseñaSinHashear = vista.txtContraseñaUsuario.Text;
            var contraseñaHasheada = 
                BCrypt.Net.BCrypt.EnhancedHashPassword(contraseñaSinHashear, hashType: HashType.SHA384);
            dtoUsuario.nombre = vista.txtNombreUsuario.Text;
            dtoUsuario.contraseña = contraseñaHasheada;
            dtoUsuario.fkIdTipo = stringAInt(vista.cboTipoUsuario.SelectedValue.ToString());
            dtoUsuario.telefono = stringAInt(vista.txtTelefonoUsuario.Text);
            daoUsuario.agregarUsuario(dtoUsuario);
            vista.Hide();
            abrirForm(new formUsuario());
        }

    }
}
