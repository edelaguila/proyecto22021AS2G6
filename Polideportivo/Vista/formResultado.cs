using Controlador;
using Modelo;
using System;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formResultado : Form
    {
        // Se declaran los campos que se van a llenar a partir de la fila seleccionada de la tabla
        private int id;

        private string equipo1;
        private string equipo2;
        private string campo;
        private string fecha;
        private string fase;
        private int fkIdCampeonato;
        private int fkIdEmpleado;
        private int fkIdResultado;
        private int fkIdEstado;
        private int anotacionesEquipo1;
        private int anotacionesEquipo2;

        // Se declara un modelo jugador para que guarde los datos de la fila sin perderlos
        private modeloResultado modeloFila = new modeloResultado();

        public formResultado()
        {
            InitializeComponent();
        }

        private void formResultado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vwPartido.vwpartido' Puede moverla o quitarla según sea necesario.
            this.vwpartidoTableAdapter.Fill(this.vwPartido.vwpartido);
            
            cboBuscar.SelectedIndex = 0;
            tablaPartidos.CurrentCell = tablaPartidos.Rows[0].Cells[1];
            llenarModeloConFilaSeleccionada();
        }

        public void actualizarTablaResultado()
        {
            this.vwpartidoTableAdapter.Fill(this.vwPartido.vwpartido);
        }

        private void tablapartidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
        }

        //private void btnAgregarResultado_Click(object sender, EventArgs e)
        //{
        //    abrirForm(new formResultadoEvento(this));
        //}

        private void btnModificar_Click(object sender, EventArgs e)
        {
            abrirForm(new formResultadoEvento(modeloFila, this));
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            filtrarTabla();
        }

        private void cboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltrar.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarTablaResultado();
        }

        private void btnEliminarPartido_Click(object sender, EventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            controladorResultado controlador = new controladorResultado();
            controlador.eliminarPartido(modeloFila);
            actualizarTablaResultado();
        }

        private void tablaPartidos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }

        public void llenarModeloConFilaSeleccionada()
        {
            id = stringAInt(tablaPartidos.SelectedRows[0].Cells[0].Value.ToString());
            fase = tablaPartidos.SelectedRows[0].Cells[1].Value.ToString();
            equipo1 = tablaPartidos.SelectedRows[0].Cells[2].Value.ToString();
            equipo2 = tablaPartidos.SelectedRows[0].Cells[3].Value.ToString();
            campo = tablaPartidos.SelectedRows[0].Cells[4].Value.ToString();
            fecha = tablaPartidos.SelectedRows[0].Cells[9].Value.ToString();
            anotacionesEquipo1 = stringAInt(tablaPartidos.SelectedRows[0].Cells[10].Value.ToString());
            anotacionesEquipo2 = stringAInt(tablaPartidos.SelectedRows[0].Cells[11].Value.ToString());
            fkIdEstado = stringAInt(tablaPartidos.SelectedRows[0].Cells[5].Value.ToString());
            fkIdCampeonato = stringAInt(tablaPartidos.SelectedRows[0].Cells[6].Value.ToString());
            fkIdEmpleado = stringAInt(tablaPartidos.SelectedRows[0].Cells[7].Value.ToString());
            fkIdResultado = stringAInt(tablaPartidos.SelectedRows[0].Cells[8].Value.ToString());
            modeloFila.pkId = id;
            modeloFila.equipo1 = equipo1;
            modeloFila.equipo2 = equipo2;
            modeloFila.fkIdEstadoPartido = fkIdEstado;
            modeloFila.fkIdCampeonato = fkIdCampeonato;
            modeloFila.fkIdEmpleado = fkIdEmpleado;
            modeloFila.anotacionesEquipo1 = anotacionesEquipo1;
            modeloFila.anotacionesEquipo2 = anotacionesEquipo2;
        }

        private void filtrarTabla()
        {
            if (string.IsNullOrEmpty(txtFiltrar.Text))
            {
                vwpartidoBindingSource.Filter = string.Empty;
            }
            else
            {
                vwpartidoBindingSource.Filter = string.Format("{0}='{1}'", cboBuscar.Text, txtFiltrar.Text);
            }
        }

        //private void btnAgregarPartido_Click_1(object sender, EventArgs e)
        //{
        //    abrirForm(new formResultadoEvento(this));
        //}

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            abrirForm(new formResultadoEvento(modeloFila, this));
        }
    }
}