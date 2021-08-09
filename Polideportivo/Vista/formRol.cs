using Controlador;
using Modelo;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;
using Modelo.DAO;

namespace Vista
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
            btnModificarRol.Visible = true;
            // Llenar combobox de deportes
            daoDeporte daoDeporte = new daoDeporte();
            cboDeporte.DataSource = daoDeporte.mostrarDeportes();
            cboDeporte.DisplayMember = "nombre";
            cboDeporte.ValueMember = "pkId";
            cboDeporte.SelectedItem = cboDeporte.Items[0];
        }

        public void actualizarTablaRol()
        {
            this.vwrolTableAdapter.Fill(this.vwRol.vwrol);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtoEmpleado modelo = new dtoEmpleado();
            daoEmpleado db = new daoEmpleado();
        }

        private modeloRol modeloFila = new modeloRol();

        private void llenarModeloConFilaSeleccionada()
        {
            id = stringAInt(tablaRol.SelectedRows[0].Cells[0].Value.ToString());
            nombre = tablaRol.SelectedRows[0].Cells[1].Value.ToString();
            modeloFila.pkId = id;
        }

        private void tablaRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            txtNombreRol.Text = nombre;
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
            controladorRol modeloModificar = new controladorRol();
            modeloRol modelo = new modeloRol();
            modeloFila.nombre = txtNombreRol.Text;
            modeloFila.fkIdDeporte = stringAInt(cboDeporte.SelectedValue.ToString());
            modeloModificar.modificarRol(modeloFila);
            actualizarTablaRol();
        }

        private void txtFiltrarRol_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFiltrarRol.Text))
            {
                vwrolBindingSource.Filter = string.Empty;
            }
            else
            {
                vwrolBindingSource.Filter = string.Format("{0}='{1}'", cboBuscarRol.Text, txtFiltrarRol.Text);
            }
        }

        private void cboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltrarRol.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarTablaRol();
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            int id = stringAInt(tablaRol.SelectedRows[0].Cells[0].Value.ToString());
            controladorRol controlador = new controladorRol();
            modeloRol modelo = new modeloRol();
            modelo.pkId = id;
            controlador.eliminarRol(modelo);
            actualizarTablaRol();
        }

        private void tablaEmpleado_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }

        private void tablaRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void formRol_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vwRol.vwrol' Puede moverla o quitarla según sea necesario.
            this.vwrolTableAdapter.Fill(this.vwRol.vwrol);
            // TODO: esta línea de código carga datos en la tabla 'vwRol.vwrol' Puede moverla o quitarla según sea necesario.
            this.vwrolTableAdapter.Fill(this.vwRol.vwrol);
        }
    }
}