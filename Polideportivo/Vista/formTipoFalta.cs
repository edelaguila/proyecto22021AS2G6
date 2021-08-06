using Polideportivo.AccesoDatos;
using Polideportivo.Controlador;
using Polideportivo.Modelo;
using System;
using System.Windows.Forms;
using static Polideportivo.Vista.utilidadForms;

namespace Polideportivo.Vista
{
    public partial class formTipoFalta : Form
    {
        private int id;
        private string nombre;
        public formTipoFalta()
        {
            InitializeComponent();
            // Este constructor es el que se utiliza para agregar datos
            btnAgregarEmpleado.Visible = true;
            // Llenar combobox de deportes
            controladorPuesto puesto = new controladorPuesto();
            controladorEmpleado empleado = new controladorEmpleado();
            cboDeporte.DataSource = puesto.mostrarPuesto();
            cboDeporte.DisplayMember = "nombre";
            cboDeporte.ValueMember = "pkId";
            cboDeporte.SelectedIndex = -1;
            // Modificar el texto del título
        }



        private void formEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vwEmpleado.vwempleado' Puede moverla o quitarla según sea necesario.
            this.vwempleadoTableAdapter.Fill(this.vwEmpleado.vwempleado);

            cboBuscar.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            modeloEmpleado modelo = new modeloEmpleado();
            controladorEmpleado db = new controladorEmpleado();
        }


        public void actualizarTablaEmpleado
 ()
        {
            this.vwempleadoTableAdapter.Fill(this.vwEmpleado.vwempleado);
        }
        private void llenarModeloConFilaSeleccionada()
        {
            id = stringAInt(tablaTipoFalta.SelectedRows[0].Cells[0].Value.ToString());
            nombre = tablaTipoFalta.SelectedRows[0].Cells[1].Value.ToString();
            modeloFila.pkId = id;
        }

        modeloEntrenador modeloFila = new modeloEntrenador();
        private void tablaEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            llenarModeloConFilaSeleccionada();
            txtNombre.Text = nombre;

        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            controladorEmpleado modeloAgregar = new controladorEmpleado();
            modeloEmpleado modelo = new modeloEmpleado();
            modelo.nombre = txtNombre.Text;
            modelo.fkIdPuestoEmpleado = stringAInt(cboDeporte.SelectedValue.ToString());
            modeloAgregar.agregarEmpleado(modelo);
            actualizarTablaEmpleado();
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            controladorEmpleado modeloModificar = new controladorEmpleado();
            modeloEmpleado modelo = new modeloEmpleado();
            modelo.nombre = txtNombre.Text;
            modelo.fkIdPuestoEmpleado = stringAInt(cboDeporte.SelectedValue.ToString());
            modeloModificar.modificarEmpleado(modelo);
            actualizarTablaEmpleado();
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFiltrar.Text))
            {
                vwempleadoBindingSource.Filter = string.Empty;
            }
            else
            {
                vwempleadoBindingSource.Filter = string.Format("{0}='{1}'", cboBuscar.Text, txtFiltrar.Text);
            }
        }

        private void cboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltrar.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarTablaEmpleado();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            int id = stringAInt(tablaTipoFalta.SelectedRows[0].Cells[0].Value.ToString());
            controladorEmpleado controlador = new controladorEmpleado();
            modeloEmpleado modelo = new modeloEmpleado();
            modelo.pkId = id;
            controlador.eliminarEmpleado(modelo);
            actualizarTablaEmpleado();
        }

        private void tablaEmpleado_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }


    }
}