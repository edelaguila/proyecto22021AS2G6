using Polideportivo.AccesoDatos;
using Polideportivo.Controlador;
using Polideportivo.Modelo;
using System;
using System.Windows.Forms;
using static Polideportivo.Vista.utilidadForms;

namespace Polideportivo.Vista
{
    public partial class formEntrenador : Form
    {




        public formEntrenador()
        {
            InitializeComponent();
            // Este constructor es el que se utiliza para agregar datos
            btnAgregarEntrenador.Visible = true;
            // Llenar combobox de deportes
            controladorDeporte deportes = new controladorDeporte();
            cboDeporte.DataSource = deportes.mostrarDeportes();
            cboDeporte.DisplayMember = "nombre";
            cboDeporte.ValueMember = "pkId";
            cboDeporte.SelectedIndex = -1;
            // Modificar el texto del título
        }



        private void formDeporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vwEntrenador.vwentrenador' Puede moverla o quitarla según sea necesario.
            this.vwentrenadorTableAdapter.Fill(this.vwEntrenador.vwentrenador);
            // TODO: esta línea de código carga datos en la tabla 'vwEntrenador.vwentrenador' Puede moverla o quitarla según sea necesario.
            cboBuscar.SelectedIndex = 0;

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            modeloDeporte modelo = new modeloDeporte();
            controladorDeporte db = new controladorDeporte();
        }


        public void actualizarTablaEntrenador()
        {
            this.vwentrenadorTableAdapter.Fill(this.vwEntrenador.vwentrenador);
        }


        modeloEntrenador modeloFila = new modeloEntrenador();
        private void tablaEntrenador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = stringAInt(tablaEntrenador.SelectedRows[0].Cells[0].Value.ToString());
            string nombre = tablaEntrenador.SelectedRows[0].Cells[1].Value.ToString();
            txtNombre.Text = nombre;
            modeloFila.pkId = id;

        }
         private void cboDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDeporte.SelectedIndex > -1)
            {
               
                // Llenar la combobox de equipo dependiendo del deporte elegido
                modeloEquipo modeloequipo = new modeloEquipo();
                modeloequipo.fkIdDeporte = stringAInt(cboDeporte.SelectedValue.ToString());
                controladorEquipo equipo = new controladorEquipo(modeloequipo);
                cboEquipo.DataSource = equipo.mostrarEquipoPorDeporte();
                cboEquipo.DisplayMember = "nombre";
                cboEquipo.ValueMember = "pkId";
            }
        }

        private void btnAgregarEntrenador_Click(object sender, EventArgs e)
        {
            controladorEntrenador modeloAgregar = new controladorEntrenador();
            modeloEntrenador modelo = new modeloEntrenador();
            modelo.nombre = txtNombre.Text;
            modelo.fkIdDeporte = stringAInt(cboDeporte.SelectedValue.ToString());
            modelo.fkIdEquipo = stringAInt(cboEquipo.SelectedValue.ToString());
            modeloAgregar.agregarEntrenador(modelo);
            actualizarTablaEntrenador();
        }

        private void btnModificarEntrenador_Click(object sender, EventArgs e)
        {
            controladorEntrenador modeloModificar = new controladorEntrenador();
            modeloEntrenador modelo = new modeloEntrenador();
            modelo.nombre = txtNombre.Text;
            modelo.fkIdDeporte = stringAInt(cboDeporte.SelectedValue.ToString());
            modelo.fkIdEquipo = stringAInt(cboEquipo.SelectedValue.ToString());
            modeloModificar.modificarEntrenador(modelo);
            actualizarTablaEntrenador();
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFiltrar.Text))
            {
                vwentrenadorBindingSource.Filter = string.Empty;
            }
            else
            {
                vwentrenadorBindingSource.Filter = string.Format("{0}='{1}'", cboBuscar.Text, txtFiltrar.Text);
            }
        }

        private void cboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltrar.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarTablaEntrenador();
        }

        private void btnEliminarEntrenador_Click(object sender, EventArgs e)
        {
            int id = stringAInt(tablaEntrenador.SelectedRows[0].Cells[0].Value.ToString());
            controladorEntrenador controlador = new controladorEntrenador();
            modeloEntrenador modelo = new modeloEntrenador();
            modelo.pkId = id;
            controlador.eliminarEntrenador(modelo);
            actualizarTablaEntrenador();
        }

        private void tablaEntrenador_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }
    }
}