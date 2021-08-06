using Polideportivo.Controlador;
using Polideportivo.Modelo;
using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using static Polideportivo.Vista.utilidadForms;

namespace Polideportivo.Vista
{
    public partial class formCampeonato : Form
    {
        private int id;
        private string nombre;
        private string fechaInicio;
        private string fechaFinal;
        private int fkIdDeporte;
        private int fkIdTipoCampeonato;

        public formCampeonato()
        {
            InitializeComponent();
        }

        private void formCampeonato_Load(object sender, EventArgs e)
        {
            try
            {
                this.vwcampeonatoTableAdapter.Fill(this.vwCampeonato.vwcampeonato);
            }
            catch (OdbcException error)
            {
                abrirForm(new formError(error));
            }

            cboBuscar.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modeloCampeonato modelo = new modeloCampeonato();
            controladorCampeonato db = new controladorCampeonato();
            //db.agregarJugador(modelo);
        }

        public void actualizarTabla()
        {
            this.vwcampeonatoTableAdapter.Fill(this.vwCampeonato.vwcampeonato);
        }

        private void txtJugadorFiltrar_TextChanged(object sender, EventArgs e)
        {
            filtrarTabla();
        }

        public void llenarModeloConFilaSeleccionada()
        {
            id = stringAInt(tablaCampeonatos.SelectedRows[0].Cells[0].Value.ToString());
            nombre = tablaCampeonatos.SelectedRows[0].Cells[1].Value.ToString();
            fechaInicio = tablaCampeonatos.SelectedRows[0].Cells[2].Value.ToString();
            fechaFinal = tablaCampeonatos.SelectedRows[0].Cells[3].Value.ToString();
            fkIdDeporte = stringAInt(tablaCampeonatos.SelectedRows[0].Cells[4].Value.ToString());
            fkIdTipoCampeonato = stringAInt(tablaCampeonatos.SelectedRows[0].Cells[6].Value.ToString());
            modeloFila.pkId = id;
            modeloFila.nombre = nombre;
            modeloFila.fechaInicio = fechaInicio;
            modeloFila.fechaFinal = fechaFinal;
            modeloFila.fkIdDeporte = fkIdDeporte;
            modeloFila.fkIdTipoCampeonato = fkIdTipoCampeonato;
        }

        private modeloCampeonato modeloFila = new modeloCampeonato();

        private void tablaCampeonatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            abrirForm(new formCampeonatoEventos(this));
        }

        private void btnModificarJugador_Click(object sender, EventArgs e)
        {
            abrirForm(new formCampeonatoEventos(modeloFila, this));
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
        }

        private void cboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltrar.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void btnEliminarCampeonato_Click(object sender, EventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            controladorCampeonato controlador = new controladorCampeonato();
            controlador.eliminarCampeonato(modeloFila);
            actualizarTabla();
        }

        private void filtrarTabla()
        {
            if (string.IsNullOrEmpty(txtFiltrar.Text))
            {
                vwcampeonatoBindingSource.Filter = string.Empty;
            }
            else
            {
                vwcampeonatoBindingSource.Filter = string.Format("{0}='{1}'", cboBuscar.Text, txtFiltrar.Text);
            }
        }

        private void tablaCampeonatos_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            //MessageBox.Show(anError.RowIndex + " " + anError.ColumnIndex);
            //MessageBox.Show("Error happened " + anError.Context.ToString());

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                //MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                //MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                //MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                //MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                //DataGridView view = (DataGridView)sender;
                //view.Rows[anError.RowIndex].ErrorText = "an error";
                //view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                //anError.ThrowException = false;
            }
        }
    }
}