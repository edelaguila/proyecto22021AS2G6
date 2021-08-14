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
    /// <summary>
    /// Clase que gestiona la tabla de campeonatos de la base de datos
    /// </summary>
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


        /// <summary>
        /// Método que sirve para cargar los eventos que van dentro de cada elemento en el formCampeonato
        /// </summary>
        /// <param name="Vista"></param>
        public controladorCampeonato(formCampeonato Vista)
        {
            vista = Vista;
            // Creación de eventos
            vista.Load += new EventHandler(cargarForm);
            vista.tablaCampeonatos.CellClick += new DataGridViewCellEventHandler(clickCeldaDeLaTabla);
            vista.btnActualizar.Click += new EventHandler(clickActualizarCampeonato);
            vista.btnAgregarCampeonato.Click += new EventHandler(clickAgregarCampeonato);
            vista.btnModificarCampeonato.Click += new EventHandler(clickModificarCampeonato);
            vista.btnEliminarCampeonato.Click += new EventHandler(clickEliminarCampeonato);
            vista.txtFiltrar.TextChanged += new EventHandler(cambioEnTextoFiltrarCampeonato);
            vista.cboBuscar.SelectedIndexChanged += new EventHandler(opcionSeleccionadaBuscarCampeonato);
        }

        /// <summary>
        /// Método que sirve para filtrar la tabla con lo ingresado en el textbox de filtrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opcionSeleccionadaBuscarCampeonato(object sender, EventArgs e)
        {
            vista.txtFiltrar.Text = "";
        }

        /// <summary>
        /// Método que manda a llamar la función de actualizar tabla, para que se actualice la tablaCampeonato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickActualizarCampeonato(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        /// <summary>
        /// Método que sirve para eliminar la opción seleccionada de la tabla 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickEliminarCampeonato(object sender, EventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            daoCampeonato controlador = new daoCampeonato();
            controlador.eliminarCampeonato(modeloFila);
            actualizarTabla();
        }

        /// <summary>
        /// Método que manda a llamar el formCampeonatoEventos para poder agregar nuevos campeonatos a la tabla 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickAgregarCampeonato(object sender, EventArgs e)
        {
            abrirForm(new formCampeonatoEventos(this));
        }

        /// <summary>
        /// Método que manda a llamar el formCampeonatoEventos para poder modificar campeonatos de la tabla 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickModificarCampeonato(object sender, EventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            abrirForm(new formCampeonatoEventos(modeloFila, this));
        }

        /// <summary>
        /// Método que sirve para llenar los modelos creados con los datos que estan seleccionados en la tabla 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickCeldaDeLaTabla(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
        }

        /// <summary>
        /// Método que sirve para cargar en las tablas las vistas creadas en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Método que sirve para actualizar los datos dentro de la tabla
        /// </summary>
        public void actualizarTabla()
        {
            vista.vwcampeonatoTableAdapter.Fill(vista.vwCampeonato.vwcampeonato);
        }

        /// <summary>
        /// Método que manda a llamar el método filtrarTabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cambioEnTextoFiltrarCampeonato(object sender, EventArgs e)
        {
            filtrarTabla();
        }

        /// <summary>
        /// Método que sirve para filtrar los datos que están dentro dentro de la tabla jugadores
        /// </summary>
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

        /// <summary>
        /// Método que sirve para llenar la tabla con las vistas creadas en la base de datos, dependiendo de cada fila que se haya creado
        /// </summary>
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