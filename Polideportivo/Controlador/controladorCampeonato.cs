using Modelo.DAO;
using Modelo.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista;
using static Vista.utilidadForms;

namespace Controlador
{
    public class controladorCampeonato
    {
        private formCampeonato vista;

        private int id;
        private string nombre;
        private string fechaInicio;
        private string fechaFinal;
        private int fkIdDeporte;
        private int fkIdTipoCampeonato;

        private dtoCampeonato modeloFila = new dtoCampeonato();

        public controladorCampeonato(formCampeonato Vista)
        {
            vista = Vista;
            // Eventos
            vista.Load += new EventHandler(cargarForm);
            vista.tablaCampeonatos.CellClick += new DataGridViewCellEventHandler(clickCeldaDeLaTabla);
            vista.btnActualizar.Click += new EventHandler(clickActualizarCampeonato);
            vista.btnAgregarCampeonato.Click += new EventHandler(clickAgregarCampeonato);
            vista.btnModificarCampeonato.Click += new EventHandler(clickModificarCampeonato);
            vista.btnEliminarCampeonato.Click += new EventHandler(clickEliminarCampeonato);
            vista.txtFiltrar.TextChanged += new EventHandler(cambioEnTextoFiltrarCampeonato);
            vista.cboBuscar.SelectedIndexChanged += new EventHandler(opcionSeleccionadaBuscarCampeonato);
        }

        private void opcionSeleccionadaBuscarCampeonato(object sender, EventArgs e)
        {
            vista.txtFiltrar.Text = "";
        }

        private void clickActualizarCampeonato(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void clickEliminarCampeonato(object sender, EventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            daoCampeonato controlador = new daoCampeonato();
            controlador.eliminarCampeonato(modeloFila);
            actualizarTabla();
        }

        private void clickAgregarCampeonato(object sender, EventArgs e)
        {
            abrirForm(new formCampeonatoEventos(this));
        }

        private void clickModificarCampeonato(object sender, EventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            abrirForm(new formCampeonatoEventos(modeloFila, this));
        }

        private void clickCeldaDeLaTabla(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
        }

        private void cargarForm(object sender, EventArgs e)
        {
            try
            {
                vista.vwcampeonatoTableAdapter.Fill(vista.vwCampeonato.vwcampeonato);
            }
            catch (MySqlException error)
            {
                abrirForm(new formError(error));
            }

            vista.cboBuscar.SelectedIndex = 0;
        }

        public void actualizarTabla()
        {
            vista.vwcampeonatoTableAdapter.Fill(vista.vwCampeonato.vwcampeonato);
        }

        private void cambioEnTextoFiltrarCampeonato(object sender, EventArgs e)
        {
            filtrarTabla();
        }

        private void filtrarTabla()
        {
            if (string.IsNullOrEmpty(vista.txtFiltrar.Text))
            {
                vista.vwcampeonatoBindingSource.Filter = string.Empty;
            }
            else
            {
                vista.vwcampeonatoBindingSource.Filter = string.Format("{0}='{1}'", vista.cboBuscar.Text, vista.txtFiltrar.Text);
            }
        }

        public void llenarModeloConFilaSeleccionada()
        {
            id = stringAInt(vista.tablaCampeonatos.SelectedRows[0].Cells[0].Value.ToString());
            nombre = vista.tablaCampeonatos.SelectedRows[0].Cells[1].Value.ToString();
            fechaInicio = vista.tablaCampeonatos.SelectedRows[0].Cells[2].Value.ToString();
            fechaFinal = vista.tablaCampeonatos.SelectedRows[0].Cells[3].Value.ToString();
            fkIdDeporte = stringAInt(vista.tablaCampeonatos.SelectedRows[0].Cells[4].Value.ToString());
            fkIdTipoCampeonato = stringAInt(vista.tablaCampeonatos.SelectedRows[0].Cells[6].Value.ToString());
            modeloFila.pkId = id;
            modeloFila.nombre = nombre;
            modeloFila.fechaInicio = fechaInicio;
            modeloFila.fechaFinal = fechaFinal;
            modeloFila.fkIdDeporte = fkIdDeporte;
            modeloFila.fkIdTipoCampeonato = fkIdTipoCampeonato;
        }
    }
}