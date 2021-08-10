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
    public partial class formUsuarioRegistrar : Form
    {
        public formUsuarioRegistrar()
        {
            InitializeComponent();
            controladorUsuarioRegistrar controladorUsuarioRegistrar = new controladorUsuarioRegistrar(this);

        }

    }
}