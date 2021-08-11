using Vista;
using System;
using static Vista.utilidadForms;
using System.Windows.Forms;
using Modelo.DTO;
using Modelo.DAO;

namespace Controlador
{
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

        private void formParticipante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vwParticipante.vwparticipante' Puede moverla o quitarla según sea necesario.
            vista.vwparticipanteTableAdapter.Fill(vista.vwParticipante.vwparticipante);
            vista.cboBuscar.SelectedIndex = 0;
            vista.tablaParticipantes.CurrentCell = vista.tablaParticipantes.Rows[0].Cells[2];
            llenarModeloConFilaSeleccionada();
        }

        public void actualizarTablaParticipante()
        {
            vista.vwparticipanteTableAdapter.Fill(vista.vwParticipante.vwparticipante);
        }

        private void tablapartidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            filtrarTabla();
        }

        private void cboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            vista.txtFiltrar.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarTablaParticipante();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            daoParticipante controlador = new daoParticipante();
            controlador.eliminarParticipante(modeloFila);
            actualizarTablaParticipante();
        }

        //private void btnEliminar_Click(object sender, EventArgs e)
        //{
          
        //}

        private void btnAgregarParticipante_Click(object sender, EventArgs e)
        {
            abrirForm(new formParticipanteEventos(this));
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            abrirForm(new formParticipanteEventos(modeloFila, this));
        }

       


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
