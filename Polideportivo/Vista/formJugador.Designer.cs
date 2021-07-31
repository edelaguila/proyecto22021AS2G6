
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
            this.txtJugadorFiltrar = new System.Windows.Forms.TextBox();
            this.btnModificarJugador = new System.Windows.Forms.Button();
            this.tablaJugadores = new Zuby.ADGV.AdvancedDataGridView();
            this.pkIdJugadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anotacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkIdRolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkIdEquipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkIdDeporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwjugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaJugadores1 = new Polideportivo.tablaJugadores();
            this.btnAgregarJugador = new System.Windows.Forms.Button();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.vwjugadorTableAdapter = new Polideportivo.tablaJugadoresTableAdapters.vwjugadorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwjugadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadores1)).BeginInit();
            this.parrotGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtJugadorFiltrar
            // 
            this.txtJugadorFiltrar.Location = new System.Drawing.Point(69, 66);
            this.txtJugadorFiltrar.Name = "txtJugadorFiltrar";
            this.txtJugadorFiltrar.Size = new System.Drawing.Size(659, 20);
            this.txtJugadorFiltrar.TabIndex = 4;
            this.txtJugadorFiltrar.TextChanged += new System.EventHandler(this.txtJugadorFiltrar_TextChanged);
            // 
            // btnModificarJugador
            // 
            this.btnModificarJugador.Location = new System.Drawing.Point(518, 28);
            this.btnModificarJugador.Name = "btnModificarJugador";
            this.btnModificarJugador.Size = new System.Drawing.Size(121, 23);
            this.btnModificarJugador.TabIndex = 7;
            this.btnModificarJugador.Text = "Modificar jugador";
            this.btnModificarJugador.UseVisualStyleBackColor = true;
            this.btnModificarJugador.Click += new System.EventHandler(this.btnModificarJugador_Click);
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
            this.pkIdRolDataGridViewTextBoxColumn,
            this.rolDataGridViewTextBoxColumn,
            this.pkIdEquipoDataGridViewTextBoxColumn,
            this.equipoDataGridViewTextBoxColumn,
            this.pkIdDeporteDataGridViewTextBoxColumn,
            this.deporteDataGridViewTextBoxColumn});
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
            // 
            // pkIdJugadorDataGridViewTextBoxColumn
            // 
            this.pkIdJugadorDataGridViewTextBoxColumn.DataPropertyName = "pkIdJugador";
            this.pkIdJugadorDataGridViewTextBoxColumn.HeaderText = "pkIdJugador";
            this.pkIdJugadorDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pkIdJugadorDataGridViewTextBoxColumn.Name = "pkIdJugadorDataGridViewTextBoxColumn";
            this.pkIdJugadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdJugadorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // anotacionesDataGridViewTextBoxColumn
            // 
            this.anotacionesDataGridViewTextBoxColumn.DataPropertyName = "anotaciones";
            this.anotacionesDataGridViewTextBoxColumn.HeaderText = "anotaciones";
            this.anotacionesDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.anotacionesDataGridViewTextBoxColumn.Name = "anotacionesDataGridViewTextBoxColumn";
            this.anotacionesDataGridViewTextBoxColumn.ReadOnly = true;
            this.anotacionesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pkIdRolDataGridViewTextBoxColumn
            // 
            this.pkIdRolDataGridViewTextBoxColumn.DataPropertyName = "pkIdRol";
            this.pkIdRolDataGridViewTextBoxColumn.HeaderText = "pkIdRol";
            this.pkIdRolDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pkIdRolDataGridViewTextBoxColumn.Name = "pkIdRolDataGridViewTextBoxColumn";
            this.pkIdRolDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdRolDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // rolDataGridViewTextBoxColumn
            // 
            this.rolDataGridViewTextBoxColumn.DataPropertyName = "rol";
            this.rolDataGridViewTextBoxColumn.HeaderText = "rol";
            this.rolDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
            this.rolDataGridViewTextBoxColumn.ReadOnly = true;
            this.rolDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pkIdEquipoDataGridViewTextBoxColumn
            // 
            this.pkIdEquipoDataGridViewTextBoxColumn.DataPropertyName = "pkIdEquipo";
            this.pkIdEquipoDataGridViewTextBoxColumn.HeaderText = "pkIdEquipo";
            this.pkIdEquipoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pkIdEquipoDataGridViewTextBoxColumn.Name = "pkIdEquipoDataGridViewTextBoxColumn";
            this.pkIdEquipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdEquipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // equipoDataGridViewTextBoxColumn
            // 
            this.equipoDataGridViewTextBoxColumn.DataPropertyName = "equipo";
            this.equipoDataGridViewTextBoxColumn.HeaderText = "equipo";
            this.equipoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.equipoDataGridViewTextBoxColumn.Name = "equipoDataGridViewTextBoxColumn";
            this.equipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pkIdDeporteDataGridViewTextBoxColumn
            // 
            this.pkIdDeporteDataGridViewTextBoxColumn.DataPropertyName = "pkIdDeporte";
            this.pkIdDeporteDataGridViewTextBoxColumn.HeaderText = "pkIdDeporte";
            this.pkIdDeporteDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pkIdDeporteDataGridViewTextBoxColumn.Name = "pkIdDeporteDataGridViewTextBoxColumn";
            this.pkIdDeporteDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdDeporteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // deporteDataGridViewTextBoxColumn
            // 
            this.deporteDataGridViewTextBoxColumn.DataPropertyName = "deporte";
            this.deporteDataGridViewTextBoxColumn.HeaderText = "deporte";
            this.deporteDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.deporteDataGridViewTextBoxColumn.Name = "deporteDataGridViewTextBoxColumn";
            this.deporteDataGridViewTextBoxColumn.ReadOnly = true;
            this.deporteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // vwjugadorBindingSource
            // 
            this.vwjugadorBindingSource.DataMember = "vwjugador";
            this.vwjugadorBindingSource.DataSource = this.tablaJugadores1;
            // 
            // tablaJugadores1
            // 
            this.tablaJugadores1.DataSetName = "tablaJugadores";
            this.tablaJugadores1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.Location = new System.Drawing.Point(404, 28);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(108, 23);
            this.btnAgregarJugador.TabIndex = 6;
            this.btnAgregarJugador.Text = "Agregar jugador";
            this.btnAgregarJugador.UseVisualStyleBackColor = true;
            this.btnAgregarJugador.Click += new System.EventHandler(this.btnAgregarJugador_Click);
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
            // vwjugadorTableAdapter
            // 
            this.vwjugadorTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwjugadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadores1)).EndInit();
            this.parrotGradientPanel1.ResumeLayout(false);
            this.parrotGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtJugadorFiltrar;
        private System.Windows.Forms.Button btnModificarJugador;
        private Zuby.ADGV.AdvancedDataGridView tablaJugadores;
        private System.Windows.Forms.Button btnAgregarJugador;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private tablaJugadores tablaJugadores1;
        private System.Windows.Forms.BindingSource vwjugadorBindingSource;
        private tablaJugadoresTableAdapters.vwjugadorTableAdapter vwjugadorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdJugadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anotacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdRolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdEquipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdDeporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deporteDataGridViewTextBoxColumn;
    }
}