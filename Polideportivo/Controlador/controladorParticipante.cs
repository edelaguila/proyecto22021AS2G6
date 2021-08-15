using Vista;
using System;
using static Vista.utilidadForms;
using System.Windows.Forms;
using Modelo.DTO;
using Modelo.DAO;

namespace Controlador
{
    /// <summary>
    /// Clase que gestiona la tabla de participantes de la base de datos
    /// </summary>
    public class controladorParticipante
    {
        private formParticipante vista;
        private int id;
        private int puntos;
        private int fkIdCampeonato;
        private int fkIdEquipo;
        private int fkIdFase;
        private int fkIdEstadoParticipante;

        private dtoParticipante modeloFila = new dtoParticipante();
        /// <summary>
        /// Método que sirve para cargar los eventos que van dentro de cada elemento en el formParticipante
        /// </summary>
        /// <param name="Vista"></param>
        public controladorParticipante(formParticipante Vista)
        {
            vista = Vista;
            // Creación de eventos
            vista.Load += new EventHandler(formParticipante_Load);
            vista.tablaParticipantes.CellClick += new DataGridViewCellEventHandler(tablapartidos_CellClick);
            vista.btnActualizar.Click += new EventHandler(btnActualizar_Click);
            vista.btnAgregarParticipante.Click += new EventHandler(btnAgregarParticipante_Click);
            vista.btnModificar.Click += new EventHandler(btnModificar_Click);
            vista.btnEliminar.Click += new EventHandler(btnEliminar_Click_1);
            vista.txtFiltrar.TextChanged += new EventHandler(txtFiltrar_TextChanged);
            vista.cboBuscar.SelectedIndexChanged += new EventHandler(cboBuscar_SelectedIndexChanged);
        }
        public controladorParticipante()
        {
        }
        /// <summary>
        /// Método que sirve para cargar en las tablas las vistas creadas en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formParticipante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vwParticipante.vwparticipante' Puede moverla o quitarla según sea necesario.
            vista.vwparticipanteTableAdapter.Fill(vista.vwParticipante.vwparticipante);
            vista.cboBuscar.SelectedIndex = 0;
            vista.tablaParticipantes.CurrentCell = vista.tablaParticipantes.Rows[0].Cells[2];
            llenarModeloConFilaSeleccionada();
        }
        /// <summary>
        /// Método que sirve para actualizar los datos dentro de la tabla
        /// </summary>
        public void actualizarTablaParticipante()
        {
            vista.vwparticipanteTableAdapter.Fill(vista.vwParticipante.vwparticipante);
        }
        /// <summary>
        /// Método que manda a llamar la función de llenarModeloConFilaSeleccionada para llenar la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tablapartidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
        }
        /// <summary>
        /// Método que manda a llamar la función de filtrarTabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            filtrarTabla();
        }
        /// <summary>
        /// Método para filtrar los datos en la tabla con lo ingresado en el txtFiltrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            vista.txtFiltrar.Text = "";
        }
        /// <summary>
        /// Método que manda a llamar a la función actualizarTablaParticipante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarTablaParticipante();
        }
        /// <summary>
        /// Método que sirve para eliminar la opción seleccionada de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            daoParticipante controlador = new daoParticipante();
            controlador.eliminarParticipante(modeloFila);
            actualizarTablaParticipante();
        }
        /// <summary>
        /// Método que manda a llamar el formParticipanteEventos para poder agregar nuevos participantes a la tabla 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarParticipante_Click(object sender, EventArgs e)
        {
            abrirForm(new formParticipanteEventos(this));
        }
        /// <summary>
        /// Método que manda a llamar el formParticipanteEventos para poder modificar participantes de la tabla 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            abrirForm(new formParticipanteEventos(modeloFila, this));
        }


        /// <summary>
        /// Método que sirve para llenar la tabla con las vistas creadas en la base de datos, dependiendo de cada fila que se haya creado
        /// </summary>
        public void llenarModeloConFilaSeleccionada()
        {
            id = stringAInt(vista.tablaParticipantes.SelectedRows[0].Cells[0].Value.ToString());
            puntos = stringAInt(vista.tablaParticipantes.SelectedRows[0].Cells[2].Value.ToString());
            fkIdCampeonato = stringAInt(vista.tablaParticipantes.SelectedRows[0].Cells[3].Value.ToString());
            fkIdEquipo = stringAInt(vista.tablaParticipantes.SelectedRows[0].Cells[1].Value.ToString());
            fkIdFase = stringAInt(vista.tablaParticipantes.SelectedRows[0].Cells[4].Value.ToString());
            fkIdEstadoParticipante = stringAInt(vista.tablaParticipantes.SelectedRows[0].Cells[5].Value.ToString());
            modeloFila.pkId = id;
            modeloFila.puntos = puntos;
            modeloFila.fkIdCampeonato = fkIdCampeonato;
            modeloFila.fkIdEquipo = fkIdEquipo;
            modeloFila.fkIdFase = fkIdFase;
            modeloFila.fkIdEstadoParticipante = fkIdEstadoParticipante;
        }
        /// <summary>
        /// Método para filtrar los datos dentro de la tabla
        /// </summary>
        private void filtrarTabla()
        {
            if (string.IsNullOrEmpty(vista.txtFiltrar.Text))
            {
                vista.vwparticipanteBindingSource.Filter = string.Empty;
            }
            else
            {
                vista.vwparticipanteBindingSource.Filter = string.Format("{0}='{1}'", vista.cboBuscar.Text, vista.txtFiltrar.Text);
            }
        }

       
    }
}
