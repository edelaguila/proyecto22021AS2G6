using Polideportivo.Controlador;
using Polideportivo.Modelo;
using System;
using System.Windows.Forms;
using static Polideportivo.Vista.utilidadForms;

namespace Polideportivo.Vista
{
    public partial class formRol : Form
    {
        private int id;
        private string nombre;
        private int fkIdDeporte;

        public formRol()
        {
            InitializeComponent();
            btnAgregarRol.Visible = true;
            btnModificarRol.Visible = false;
            // Llenar combobox de deportes
            controladorDeporte deportes = new controladorDeporte();
            cboDeporte.DataSource = deportes.mostrarDeportes();
            cboDeporte.DisplayMember = "nombre";
            cboDeporte.ValueMember = "pkId";
            cboDeporte.SelectedItem = cboDeporte.Items[0];
        }

        public void actualizarTablaRol()
        {
            this.vwrolTableAdapter.Fill(this.vwRol.vwrol);
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            controladorRol modeloAgregar = new controladorRol();
            modeloRol modelo = new modeloRol();
            modelo.nombre = txtNombreRol.Text;
            modelo.fkIdDeporte = stringAInt(cboDeporte.SelectedValue.ToString());
            modeloAgregar.agregarRol(modelo);
            actualizarTablaRol();
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