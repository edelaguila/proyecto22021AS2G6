
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
            this.button2 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtJugadorFiltrar = new System.Windows.Forms.TextBox();
            this.vwJugador = new Polideportivo.vwJugador();
            this.vwjugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwjugadorTableAdapter = new Polideportivo.vwJugadorTableAdapters.vwjugadorTableAdapter();
            this.tablaJugadores = new Zuby.ADGV.AdvancedDataGridView();
            this.pkIdJugadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anotacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkIdEquipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarJugador = new System.Windows.Forms.Button();
            this.btnModificarJugador = new System.Windows.Forms.Button();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.vwJugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwjugadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadores)).BeginInit();
            this.parrotGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(111, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtJugadorFiltrar
            // 
            this.txtJugadorFiltrar.Location = new System.Drawing.Point(69, 66);
            this.txtJugadorFiltrar.Name = "txtJugadorFiltrar";
            this.txtJugadorFiltrar.Size = new System.Drawing.Size(659, 20);
            this.txtJugadorFiltrar.TabIndex = 4;
            this.txtJugadorFiltrar.TextChanged += new System.EventHandler(this.txtJugadorFiltrar_TextChanged);
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
            // tablaJugadores
            // 
            this.tablaJugadores.AutoGenerateColumns = false;
            this.tablaJugadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkIdJugadorDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.anotacionesDataGridViewTextBoxColumn,
            this.rolDataGridViewTextBoxColumn,
            this.pkIdEquipoDataGridViewTextBoxColumn,
            this.equipoDataGridViewTextBoxColumn});
            this.tablaJugadores.DataSource = this.vwjugadorBindingSource;
            this.tablaJugadores.FilterAndSortEnabled = true;
            this.tablaJugadores.Location = new System.Drawing.Point(69, 92);
            this.tablaJugadores.Name = "tablaJugadores";
            this.tablaJugadores.ReadOnly = true;
            this.tablaJugadores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tablaJugadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaJugadores.Size = new System.Drawing.Size(659, 405);
            this.tablaJugadores.TabIndex = 5;
            this.tablaJugadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaJugadores_CellClick);
            this.tablaJugadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaJugadores_CellContentClick);
            // 
            // pkIdJugadorDataGridViewTextBoxColumn
            // 
            this.pkIdJugadorDataGridViewTextBoxColumn.DataPropertyName = "pkIdJugador";
            this.pkIdJugadorDataGridViewTextBoxColumn.FillWeight = 97.4026F;
            this.pkIdJugadorDataGridViewTextBoxColumn.HeaderText = "pkIdJugador";
            this.pkIdJugadorDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pkIdJugadorDataGridViewTextBoxColumn.Name = "pkIdJugadorDataGridViewTextBoxColumn";
            this.pkIdJugadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdJugadorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pkIdJugadorDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.FillWeight = 98.68805F;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // anotacionesDataGridViewTextBoxColumn
            // 
            this.anotacionesDataGridViewTextBoxColumn.DataPropertyName = "anotaciones";
            this.anotacionesDataGridViewTextBoxColumn.FillWeight = 99.76485F;
            this.anotacionesDataGridViewTextBoxColumn.HeaderText = "anotaciones";
            this.anotacionesDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.anotacionesDataGridViewTextBoxColumn.Name = "anotacionesDataGridViewTextBoxColumn";
            this.anotacionesDataGridViewTextBoxColumn.ReadOnly = true;
            this.anotacionesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // rolDataGridViewTextBoxColumn
            // 
            this.rolDataGridViewTextBoxColumn.DataPropertyName = "rol";
            this.rolDataGridViewTextBoxColumn.FillWeight = 100.6668F;
            this.rolDataGridViewTextBoxColumn.HeaderText = "rol";
            this.rolDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
            this.rolDataGridViewTextBoxColumn.ReadOnly = true;
            this.rolDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pkIdEquipoDataGridViewTextBoxColumn
            // 
            this.pkIdEquipoDataGridViewTextBoxColumn.DataPropertyName = "pkIdEquipo";
            this.pkIdEquipoDataGridViewTextBoxColumn.FillWeight = 101.4224F;
            this.pkIdEquipoDataGridViewTextBoxColumn.HeaderText = "pkIdEquipo";
            this.pkIdEquipoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pkIdEquipoDataGridViewTextBoxColumn.Name = "pkIdEquipoDataGridViewTextBoxColumn";
            this.pkIdEquipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdEquipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pkIdEquipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipoDataGridViewTextBoxColumn
            // 
            this.equipoDataGridViewTextBoxColumn.DataPropertyName = "equipo";
            this.equipoDataGridViewTextBoxColumn.FillWeight = 102.0553F;
            this.equipoDataGridViewTextBoxColumn.HeaderText = "equipo";
            this.equipoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.equipoDataGridViewTextBoxColumn.Name = "equipoDataGridViewTextBoxColumn";
            this.equipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.Location = new System.Drawing.Point(298, 19);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(108, 23);
            this.btnAgregarJugador.TabIndex = 6;
            this.btnAgregarJugador.Text = "Agregar jugador";
            this.btnAgregarJugador.UseVisualStyleBackColor = true;
            this.btnAgregarJugador.Click += new System.EventHandler(this.btnAgregarJugador_Click);
            // 
            // btnModificarJugador
            // 
            this.btnModificarJugador.Location = new System.Drawing.Point(412, 28);
            this.btnModificarJugador.Name = "btnModificarJugador";
            this.btnModificarJugador.Size = new System.Drawing.Size(121, 23);
            this.btnModificarJugador.TabIndex = 7;
            this.btnModificarJugador.Text = "Modificar jugador";
            this.btnModificarJugador.UseVisualStyleBackColor = true;
            this.btnModificarJugador.Click += new System.EventHandler(this.btnModificarJugador_Click);
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.Fuchsia;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Controls.Add(this.btnAgregarJugador);
            this.parrotGradientPanel1.Controls.Add(this.tablaJugadores);
            this.parrotGradientPanel1.Controls.Add(this.btnModificarJugador);
            this.parrotGradientPanel1.Controls.Add(this.txtJugadorFiltrar);
            this.parrotGradientPanel1.Controls.Add(this.txtId);
            this.parrotGradientPanel1.Controls.Add(this.button2);
            this.parrotGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel1.Size = new System.Drawing.Size(900, 595);
            this.parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotGradientPanel1.TabIndex = 8;
            this.parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // formJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 595);
            this.Controls.Add(this.parrotGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formJugador";
            this.Text = "formJugador";
            this.Load += new System.EventHandler(this.formJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwJugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwjugadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadores)).EndInit();
            this.parrotGradientPanel1.ResumeLayout(false);
            this.parrotGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtJugadorFiltrar;
        private vwJugador vwJugador;
        private System.Windows.Forms.BindingSource vwjugadorBindingSource;
        private vwJugadorTableAdapters.vwjugadorTableAdapter vwjugadorTableAdapter;
        private Zuby.ADGV.AdvancedDataGridView tablaJugadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdJugadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anotacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdEquipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAgregarJugador;
        private System.Windows.Forms.Button btnModificarJugador;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
    }
}