
﻿using Polideportivo.AccesoDatos;
using Polideportivo.Modelo;
using System;
using System.Windows.Forms;
using static Polideportivo.Vista.utilidadForms;

namespace Polideportivo.Vista
{
    public partial class formPartido : Form
    {

        // Se declaran los campos que se van a llenar a partir de la fila seleccionada de la tabla
        int id;
        string equipo1;
        string equipo2;
        string campo;
        string fecha;
        string fase;
        int fkIdCampeonato;
        int fkIdEmpleado;
        int fkIdResultado;
        int fkIdEstado;

        // Se declara un modelo jugador para que guarde los datos de la fila sin perderlos
        modeloPartido modeloFila = new modeloPartido();

        public formPartido()
        {
            InitializeComponent();
        }

        private void formPartido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vwPartido.vwpartido' Puede moverla o quitarla según sea necesario.
            this.vwpartidoTableAdapter.Fill(this.vwPartido.vwpartido);
            tablaJugadores.CurrentCell = tablaJugadores.Rows[0].Cells[1];
            cboBuscar.SelectedIndex = 0;
            llenarModeloConFilaSeleccionada();
        }



        public void actualizarTablaPartido()
        {
            this.vwpartidoTableAdapter.Fill(this.vwPartido.vwpartido);
        }




        private void tablaJugadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
        }



        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            abrirForm(new formPartidoEventos(this));
        }

        private void btnModificarJugador_Click(object sender, EventArgs e)
        {
            //abrirForm(new formJugadorEventos(modeloFila, this));

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
            actualizarTablaPartido();
        }

        private void btnEliminarPartido_Click(object sender, EventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            controladorPartido controlador = new controladorPartido();
            controlador.eliminarPartido(modeloFila);
            actualizarTablaPartido();
        }

        private void tablaJugadores_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Es necesario para que no den errores cuando se cambia rápidamente pestañas del menú
        }

        public void llenarModeloConFilaSeleccionada()
        {
            //id= stringAInt(tablaJugadores.SelectedRows[0].Cells[0].Value.ToString());
            //nombre = tablaJugadores.SelectedRows[0].Cells[1].Value.ToString();
            //anotaciones = stringAInt(tablaJugadores.SelectedRows[0].Cells[2].Value.ToString());
            //fkIdEquipo = stringAInt(tablaJugadores.SelectedRows[0].Cells[3].Value.ToString());
            //fkIdRol = stringAInt(tablaJugadores.SelectedRows[0].Cells[5].Value.ToString());
            //fkIdDeporte = stringAInt(tablaJugadores.SelectedRows[0].Cells[7].Value.ToString());
            //modeloFila.pkId = id;
            //modeloFila.nombre = nombre;
            //modeloFila.anotaciones = anotaciones;
            //modeloFila.fkIdEquipo = fkIdEquipo;
            //modeloFila.fkIdRol = fkIdRol;
            //modeloFila.fkIdDeporte = fkIdDeporte;
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

    }
}
