﻿using System;
using System.Windows.Forms;

namespace Polideportivo.Vista
{
    public partial class formRol : Form
    {
        public formRol()
        {
            InitializeComponent();
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
        }

        private void btnModificarRol_Click(object sender, EventArgs e)
        {
        }

        private void btnElinimarRol_Click(object sender, EventArgs e)
        {
        }

        private void btnActualizarRol_Click(object sender, EventArgs e)
        {
        }

        private void tablaRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tablaRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tablaRol_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
        }

        private void cboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtNombreRol_TextChanged(object sender, EventArgs e)
        {
        }

        private void formRol_Load(object sender, EventArgs e)
        {
            this.vwrolTableAdapter.Fill(this.vwRol.vwrol);
        }

        private void txtNombreDeporte_TextChanged(object sender, EventArgs e)
        {
        }
    }
}