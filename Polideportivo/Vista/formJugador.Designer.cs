
namespace Polideportivo.Vista
{
    partial class formJugador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtJugadorFiltrar = new System.Windows.Forms.TextBox();
            this.advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.vwJugador = new Polideportivo.vwJugador();
            this.vwjugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwjugadorTableAdapter = new Polideportivo.vwJugadorTableAdapters.vwjugadorTableAdapter();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anotacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwJugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwjugadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ingresar jugador";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(417, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ver jugadores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(643, 340);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            // 
            // txtJugadorFiltrar
            // 
            this.txtJugadorFiltrar.Location = new System.Drawing.Point(227, 29);
            this.txtJugadorFiltrar.Name = "txtJugadorFiltrar";
            this.txtJugadorFiltrar.Size = new System.Drawing.Size(100, 20);
            this.txtJugadorFiltrar.TabIndex = 4;
            this.txtJugadorFiltrar.TextChanged += new System.EventHandler(this.txtJugadorFiltrar_TextChanged);
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.anotacionesDataGridViewTextBoxColumn,
            this.rolDataGridViewTextBoxColumn,
            this.equipoDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.vwjugadorBindingSource;
            this.advancedDataGridView1.FilterAndSortEnabled = true;
            this.advancedDataGridView1.Location = new System.Drawing.Point(199, 125);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridView1.Size = new System.Drawing.Size(475, 150);
            this.advancedDataGridView1.TabIndex = 5;
            // 
            // vwJugador
            // 
            this.vwJugador.DataSetName = "vwJugador";
            this.vwJugador.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwjugadorBindingSource
            // 
            this.vwjugadorBindingSource.DataMember = "vwjugador";
            this.vwjugadorBindingSource.DataSource = this.vwJugador;
            // 
            // vwjugadorTableAdapter
            // 
            this.vwjugadorTableAdapter.ClearBeforeFill = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // anotacionesDataGridViewTextBoxColumn
            // 
            this.anotacionesDataGridViewTextBoxColumn.DataPropertyName = "anotaciones";
            this.anotacionesDataGridViewTextBoxColumn.HeaderText = "anotaciones";
            this.anotacionesDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.anotacionesDataGridViewTextBoxColumn.Name = "anotacionesDataGridViewTextBoxColumn";
            this.anotacionesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // rolDataGridViewTextBoxColumn
            // 
            this.rolDataGridViewTextBoxColumn.DataPropertyName = "rol";
            this.rolDataGridViewTextBoxColumn.HeaderText = "rol";
            this.rolDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
            this.rolDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // equipoDataGridViewTextBoxColumn
            // 
            this.equipoDataGridViewTextBoxColumn.DataPropertyName = "equipo";
            this.equipoDataGridViewTextBoxColumn.HeaderText = "equipo";
            this.equipoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.equipoDataGridViewTextBoxColumn.Name = "equipoDataGridViewTextBoxColumn";
            this.equipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // formJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 595);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.txtJugadorFiltrar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formJugador";
            this.Text = "formJugador";
            this.Load += new System.EventHandler(this.formJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwJugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwjugadorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtJugadorFiltrar;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private vwJugador vwJugador;
        private System.Windows.Forms.BindingSource vwjugadorBindingSource;
        private vwJugadorTableAdapters.vwjugadorTableAdapter vwjugadorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anotacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
    }
}