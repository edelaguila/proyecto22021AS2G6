using Controlador;
using Modelo;
using Datos;
using Modelo.DAO;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formTipoFalta : Form
    {
        private int id;
        private string nombre;

        public formTipoFalta()
        {
            InitializeComponent();
            // Este constructor es el que se utiliza para agregar datos
            btnAgregarFalta.Visible = true;
            // Llenar combobox de deportes
            daoDeporte daoDeporte = new daoDeporte();
            cboDeporte.DataSource = daoDeporte.mostrarDeportes();
            cboDeporte.DisplayMember = "nombre";
            cboDeporte.ValueMember = "pkId";
            cboDeporte.SelectedIndex = -1;
            // Modificar el texto del título
        }

        private void formTipoFalta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vwTipoFalta.vwtipofalta' Puede moverla o quitarla según sea necesario.
            this.vwtipofaltaTableAdapter.Fill(this.vwTipoFalta.vwtipofalta);
            cboBuscar.SelectedIndex = 0;
        }

        public void actualizarTablaTipoFalta
 ()
        {
            this.vwtipofaltaTableAdapter.Fill(this.vwTipoFalta.vwtipofalta);
        }

        private void llenarModeloConFilaSeleccionada()
        {
            id = stringAInt(tablaTipoFalta.SelectedRows[0].Cells[0].Value.ToString());
            nombre = tablaTipoFalta.SelectedRows[0].Cells[1].Value.ToString();
            modeloFila.pkId = id;
        }

        private modeloTipoFalta modeloFila = new modeloTipoFalta();

        private void tablaTipoFalta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            txtNombre.Text = nombre;
        }

        private void btnAgregarTipoFalta_Click(object sender, EventArgs e)
        {
            controladorTipoFalta modeloAgregar = new controladorTipoFalta();
            modeloTipoFalta modelo = new modeloTipoFalta();
            modelo.tipo = txtNombre.Text;
            modelo.fkIdDeporte = stringAInt(cboDeporte.SelectedValue.ToString());
            modeloAgregar.agregarTipoFalta(modelo);
            actualizarTablaTipoFalta();
        }

        private void btnModificarTipoFalta_Click(object sender, EventArgs e)
        {
            controladorTipoFalta modeloModificar = new controladorTipoFalta();
            modeloTipoFalta modelo = new modeloTipoFalta();
            modeloFila.tipo = txtNombre.Text;
            modeloFila.fkIdDeporte = stringAInt(cboDeporte.SelectedValue.ToString());
            modeloModificar.modificarTipoFalta(modeloFila);
            actualizarTablaTipoFalta();
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFiltrar.Text))
            {
                vwtipofaltaBindingSource.Filter = string.Empty;
            }
            else
            {
                vwtipofaltaBindingSource.Filter = string.Format("{0}='{1}'", cboBuscar.Text, txtFiltrar.Text);
            }
        }

        private void cboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltrar.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarTablaTipoFalta();
        }

        private void btnEliminarTipoFalta_Click(object sender, EventArgs e)
        {
            int id = stringAInt(tablaTipoFalta.SelectedRows[0].Cells[0].Value.ToString());
            controladorTipoFalta controlador = new controladorTipoFalta();
            modeloTipoFalta modelo = new modeloTipoFalta();
            modelo.pkId = id;
            controlador.eliminarTipoFalta(modelo);
            actualizarTablaTipoFalta();
        }

        private void tablaTipoFalta_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }

        private void parrotGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}