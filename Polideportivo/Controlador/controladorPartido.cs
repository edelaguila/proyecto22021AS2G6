using Vista;
using System;
using System.Windows.Forms;
using Modelo.DTO;
using Modelo.DAO;
using static Vista.utilidadForms;

namespace Controlador
{
    /// <summary>
    /// Clase que gestiona la tabla de partidos de la base de datos
    /// </summary>
    public class controladorPartido
    {
        private formPartido vista;

        // Se declaran los campos que se van a llenar a partir de la fila seleccionada de la tabla
        private int id;

        private string equipo1;
        private string equipo2;
        private int fkIdCampeonato;
        private int fkIdEmpleado;
        private int fkIdResultado;
        private int fkIdEstado;
        private int fkIdFase;
        private string campo;
        private string fecha;
        private dtoPartido modeloFila = new dtoPartido();

        /// <summary>
        /// Método que sirve para cargar los eventos que van dentro de cada elemento en el formPartido
        /// </summary>
        /// <param name="Vista"></param>
        public controladorPartido(formPartido Vista)
        {
            vista = Vista;
            // Creación de eventos
            vista.Load += new EventHandler(cargarForm);
            vista.tablaPartidos.CellClick += new DataGridViewCellEventHandler(clickCeldaDeLaTabla);
            vista.btnActualizar.Click += new EventHandler(clickActualizarPartido);
            vista.btnAgregarPartido.Click += new EventHandler(clickAgregarPartido);
            vista.btnModificar.Click += new EventHandler(clickModificarPartido);
            vista.btnEliminar.Click += new EventHandler(clickEliminarPartido);
            vista.txtFiltrar.TextChanged += new EventHandler(cambioEnTextoFiltrarPartido);
            vista.cboBuscar.SelectedIndexChanged += new EventHandler(opcionSeleccionadaBuscarPartido);
        }

        public controladorPartido()
        {
        }
        /// <summary>
        /// étodo que sirve para cargar la tablaPartido con las vistas creadas en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargarForm(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vwPartido.vwpartido' Puede moverla o quitarla según sea necesario.
            vista.vwpartidoTableAdapter.Fill(vista.vwPartido.vwpartido);
            vista.cboBuscar.SelectedIndex = 0;
            vista.tablaPartidos.CurrentCell = vista.tablaPartidos.Rows[0].Cells[1];
            llenarModeloConFilaSeleccionada();
        }
        /// <summary>
        /// Método para llenar la tabla con la fila seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickCeldaDeLaTabla(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
        }
        /// <summary>
        /// Método que actualiza la tablaPartido 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickActualizarPartido(object sender, EventArgs e)
        {
            actualizarTablaPartido();
        }
        /// <summary>
        /// Método que abre el formPartidoEventos para agregar nuevos partidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickAgregarPartido(object sender, EventArgs e)
        {
            abrirForm(new formPartidoEventos(this));
        }
        /// <summary>
        /// Método que abre el formPartidoEventos para modificar el partido seleccionado en la tabla 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickModificarPartido(object sender, EventArgs e)
        {
            abrirForm(new formPartidoEventos(modeloFila, this));
        }
        /// <summary>
        /// Método que filtra dentro de la tabla con el texto que se ingrese dentro del textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opcionSeleccionadaBuscarPartido(object sender, EventArgs e)
        {
            vista.txtFiltrar.Text = "";
        }
        /// <summary>
        /// Método para eliminar el partido seleccionado dentro de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickEliminarPartido(object sender, EventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            daoPartido daoPartido = new daoPartido();
            daoPartido.eliminarPartido(modeloFila);
            actualizarTablaPartido();
        }
        /// <summary>
        ///  Método que sirve para filtrar los datos dentro la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cambioEnTextoFiltrarPartido(object sender, EventArgs e)
        {
            filtrarTabla();
        }
        /// <summary>
        /// Método para actualizar los datos de la tablaPartido
        /// </summary>
        public void actualizarTablaPartido()
        {
            vista.vwpartidoTableAdapter.Fill(vista.vwPartido.vwpartido);
        }
        /// <summary>
        /// Método que sirve para llenar la tabla con las vistas creadas en la base de datos, dependiendo de cada fila que se haya creado
        /// </summary>
        public void llenarModeloConFilaSeleccionada()
        {
            id = stringAInt(vista.tablaPartidos.SelectedRows[0].Cells[0].Value.ToString());
            equipo1 = vista.tablaPartidos.SelectedRows[0].Cells[2].Value.ToString();
            equipo2 = vista.tablaPartidos.SelectedRows[0].Cells[3].Value.ToString();
            campo = vista.tablaPartidos.SelectedRows[0].Cells[4].Value.ToString();
            fecha = vista.tablaPartidos.SelectedRows[0].Cells[9].Value.ToString();
            fkIdEstado = stringAInt(vista.tablaPartidos.SelectedRows[0].Cells[5].Value.ToString());
            fkIdCampeonato = stringAInt(vista.tablaPartidos.SelectedRows[0].Cells[6].Value.ToString());
            fkIdEmpleado = stringAInt(vista.tablaPartidos.SelectedRows[0].Cells[7].Value.ToString());
            fkIdResultado = stringAInt(vista.tablaPartidos.SelectedRows[0].Cells[8].Value.ToString());
            fkIdFase = stringAInt(vista.tablaPartidos.SelectedRows[0].Cells[10].Value.ToString());
            modeloFila.pkId = id;
            modeloFila.equipo1 = equipo1;
            modeloFila.equipo2 = equipo2;
            modeloFila.fkIdEstadoPartido = fkIdEstado;
            modeloFila.fkIdCampeonato = fkIdCampeonato;
            modeloFila.fkIdEmpleado = fkIdEmpleado;
            modeloFila.fkIdFase = fkIdFase;
        }
        /// <summary>
        /// Método para filtrar la tabla con los datos que se deseen ver
        /// </summary>
        private void filtrarTabla()
        {
            if (string.IsNullOrEmpty(vista.txtFiltrar.Text))
            {
                vista.vwpartidoBindingSource.Filter = string.Empty;
            }
            else
            {
                vista.vwpartidoBindingSource.Filter = string.Format("{0}='{1}'", vista.cboBuscar.Text, vista.txtFiltrar.Text);
            }
        }
    }
}