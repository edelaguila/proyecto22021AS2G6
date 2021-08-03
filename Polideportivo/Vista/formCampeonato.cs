using Polideportivo.AccesoDatos;
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

        }

        modeloCampeonato modeloFila = new modeloCampeonato();
        private void tablaCampeonatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = stringAInt(tablaCampeonatos.SelectedRows[0].Cells[0].Value.ToString());
            string nombre = tablaCampeonatos.SelectedRows[0].Cells[1].Value.ToString();
            string fechaInicio = tablaCampeonatos.SelectedRows[0].Cells[2].Value.ToString();
            string fechaFinal = tablaCampeonatos.SelectedRows[0].Cells[3].Value.ToString();
            int fkIdDeporte = stringAInt(tablaCampeonatos.SelectedRows[0].Cells[4].Value.ToString());
            int fkIdTipoCampeonato = stringAInt(tablaCampeonatos.SelectedRows[0].Cells[6].Value.ToString());
            modeloFila.pkId = id;
            modeloFila.nombre = nombre;
            modeloFila.fechaInicio = fechaInicio;
            modeloFila.fechaFinal = fechaFinal;
            modeloFila.fkIdDeporte = fkIdDeporte;
            modeloFila.fkIdTipoCampeonato = fkIdTipoCampeonato;
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
            if (string.IsNullOrEmpty(txtFiltrar.Text))
            {
                vwcampeonatoBindingSource.Filter = string.Empty;
            }
            else
            {
                vwcampeonatoBindingSource.Filter = string.Format("{0}='{1}'", cboBuscar.Text, txtFiltrar.Text);
            }
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
            int id = stringAInt(tablaCampeonatos.SelectedRows[0].Cells[0].Value.ToString());
            controladorCampeonato controlador = new controladorCampeonato();
            modeloCampeonato modelo = new modeloCampeonato();
            modelo.pkId = id;
            controlador.eliminarCampeonato(modelo);
            actualizarTabla();
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
