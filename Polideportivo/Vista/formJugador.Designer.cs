
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
            this.tablaJugadores = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtJugadorFiltrar = new System.Windows.Forms.TextBox();
            this.tablaAvanzada = new Zuby.ADGV.AdvancedDataGridView();
            this.tablajugadorespruba1 = new Polideportivo.tablajugadorespruba1();
            this.tablajugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablajugadoresTableAdapter = new Polideportivo.tablajugadorespruba1TableAdapters.tablajugadoresTableAdapter();
            this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAvanzada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablajugadorespruba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablajugadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
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
            this.button2.Location = new System.Drawing.Point(199, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(417, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ver jugadores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tablaJugadores
            // 
            this.tablaJugadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaJugadores.Location = new System.Drawing.Point(12, 55);
            this.tablaJugadores.Name = "tablaJugadores";
            this.tablaJugadores.ReadOnly = true;
            this.tablaJugadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaJugadores.Size = new System.Drawing.Size(804, 95);
            this.tablaJugadores.TabIndex = 2;
            this.tablaJugadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaJugadores_CellContentClick);
            this.tablaJugadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaJugadores_CellContentClick);
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
            // 
            // tablaAvanzada
            // 
            this.tablaAvanzada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAvanzada.FilterAndSortEnabled = true;
            this.tablaAvanzada.Location = new System.Drawing.Point(52, 156);
            this.tablaAvanzada.Name = "tablaAvanzada";
            this.tablaAvanzada.ReadOnly = true;
            this.tablaAvanzada.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tablaAvanzada.Size = new System.Drawing.Size(640, 142);
            this.tablaAvanzada.TabIndex = 5;
            // 
            // tablajugadorespruba1
            // 
            this.tablajugadorespruba1.DataSetName = "tablajugadorespruba1";
            this.tablajugadorespruba1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablajugadoresBindingSource
            // 
            this.tablajugadoresBindingSource.DataMember = "tablajugadores";
            this.tablajugadoresBindingSource.DataSource = this.tablajugadorespruba1;
            // 
            // tablajugadoresTableAdapter
            // 
            this.tablajugadoresTableAdapter.ClearBeforeFill = true;
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
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.equipoDataGridViewTextBoxColumn,
            this.rolDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.tablajugadoresBindingSource;
            this.advancedDataGridView1.FilterAndSortEnabled = true;
            this.advancedDataGridView1.Location = new System.Drawing.Point(162, 148);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridView1.Size = new System.Drawing.Size(511, 150);
            this.advancedDataGridView1.TabIndex = 6;
            // 
            // formJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 595);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.tablaAvanzada);
            this.Controls.Add(this.txtJugadorFiltrar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.tablaJugadores);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formJugador";
            this.Text = "formJugador";
            this.Load += new System.EventHandler(this.formJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAvanzada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablajugadorespruba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablajugadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView tablaJugadores;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtJugadorFiltrar;
        private Zuby.ADGV.AdvancedDataGridView tablaAvanzada;
        private tablajugadorespruba1 tablajugadorespruba1;
        private System.Windows.Forms.BindingSource tablajugadoresBindingSource;
        private tablajugadorespruba1TableAdapters.tablajugadoresTableAdapter tablajugadoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
    }
}