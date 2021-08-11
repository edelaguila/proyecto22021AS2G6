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
    public class controladorUsuarioRegistrar
    {
        formUsuarioRegistrar vista;
        daoUsuario daoUsuario = new daoUsuario();
        dtoUsuario dtoUsuario = new dtoUsuario();
        public controladorUsuarioRegistrar(formUsuarioRegistrar Vista)
        {
            vista = Vista;
            // Eventos
            vista.btnRegistrarUsuario.Click += new EventHandler(clickUsuarioRegistrar);
            vista.Load += new EventHandler(cargarForm);
        }

        public void cargarForm(object sender , EventArgs e)
        {
            daoTipoUsuario daoTipoUsuario = new daoTipoUsuario();
            vista.cboTipoUsuario.DataSource = daoTipoUsuario.mostrarTipoUsuario();
            vista.cboTipoUsuario.DisplayMember = "nombre";
            vista.cboTipoUsuario.ValueMember = "pkId";
            vista.cboTipoUsuario.SelectedIndex = -1;
        }

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
        }

    }
}
