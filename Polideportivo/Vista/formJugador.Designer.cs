
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formJugador));
            this.tablaJugadores = new Zuby.ADGV.AdvancedDataGridView();
            this.vwjugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaJugadores1 = new Polideportivo.tablaJugadores();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.btnActualizar = new ReaLTaiizor.Controls.HopeButton();
            this.vwjugadorTableAdapter = new Polideportivo.tablaJugadoresTableAdapters.vwjugadorTableAdapter();
            this.btnAgregarJugador = new System.Windows.Forms.Button();
            this.pkIdJugadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anotacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkIdRolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkIdEquipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkIdDeporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificarJugador = new System.Windows.Forms.Button();
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwjugadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadores1)).BeginInit();
            this.parrotGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaJugadores
            // 
            this.tablaJugadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaJugadores.AutoGenerateColumns = false;
            this.tablaJugadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaJugadores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaJugadores.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaJugadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaJugadores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaJugadores.DefaultCellStyle = dataGridViewCellStyle1;
            this.tablaJugadores.FilterAndSortEnabled = true;
            this.tablaJugadores.Location = new System.Drawing.Point(69, 123);
            this.tablaJugadores.Name = "tablaJugadores";
            this.tablaJugadores.ReadOnly = true;
            this.tablaJugadores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tablaJugadores.RowHeadersVisible = false;
            this.tablaJugadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaJugadores.Size = new System.Drawing.Size(768, 413);
            this.tablaJugadores.TabIndex = 5;
            this.tablaJugadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaJugadores_CellClick);
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
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.MidnightBlue;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Controls.Add(this.panel1);
            this.parrotGradientPanel1.Controls.Add(this.btnModificarJugador);
            this.parrotGradientPanel1.Controls.Add(this.btnAgregarJugador);
            this.parrotGradientPanel1.Controls.Add(this.btnActualizar);
            this.parrotGradientPanel1.Controls.Add(this.tablaJugadores);
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
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.Navy;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnActualizar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnActualizar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnActualizar.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnActualizar.ForeColor = System.Drawing.Color.Transparent;
            this.btnActualizar.HoverTextColor = System.Drawing.Color.White;
            this.btnActualizar.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnActualizar.Location = new System.Drawing.Point(298, 21);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.PrimaryColor = System.Drawing.Color.SteelBlue;
            this.btnActualizar.Size = new System.Drawing.Size(96, 30);
            this.btnActualizar.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnActualizar.TabIndex = 25;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.White;
            this.btnActualizar.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // vwjugadorTableAdapter
            // 
            this.vwjugadorTableAdapter.ClearBeforeFill = true;
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarJugador.FlatAppearance.BorderSize = 0;
            this.btnAgregarJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarJugador.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarJugador.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarJugador.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarJugador.Image")));
            this.btnAgregarJugador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarJugador.Location = new System.Drawing.Point(387, 71);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(210, 36);
            this.btnAgregarJugador.TabIndex = 27;
            this.btnAgregarJugador.Text = "A G R E G A R";
            this.btnAgregarJugador.UseVisualStyleBackColor = false;
            this.btnAgregarJugador.Click += new System.EventHandler(this.btnAgregarJugador_Click);
            // 
            // pkIdJugadorDataGridViewTextBoxColumn
            // 
            this.pkIdJugadorDataGridViewTextBoxColumn.DataPropertyName = "pkIdJugador";
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
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // anotacionesDataGridViewTextBoxColumn
            // 
            this.anotacionesDataGridViewTextBoxColumn.DataPropertyName = "anotaciones";
            this.anotacionesDataGridViewTextBoxColumn.HeaderText = "Anotaciones";
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
            this.pkIdRolDataGridViewTextBoxColumn.Visible = false;
            // 
            // rolDataGridViewTextBoxColumn
            // 
            this.rolDataGridViewTextBoxColumn.DataPropertyName = "rol";
            this.rolDataGridViewTextBoxColumn.HeaderText = "Rol";
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
            this.pkIdEquipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipoDataGridViewTextBoxColumn
            // 
            this.equipoDataGridViewTextBoxColumn.DataPropertyName = "equipo";
            this.equipoDataGridViewTextBoxColumn.HeaderText = "Equipo";
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
            this.pkIdDeporteDataGridViewTextBoxColumn.Visible = false;
            // 
            // deporteDataGridViewTextBoxColumn
            // 
            this.deporteDataGridViewTextBoxColumn.DataPropertyName = "deporte";
            this.deporteDataGridViewTextBoxColumn.HeaderText = "Deporte";
            this.deporteDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.deporteDataGridViewTextBoxColumn.Name = "deporteDataGridViewTextBoxColumn";
            this.deporteDataGridViewTextBoxColumn.ReadOnly = true;
            this.deporteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // btnModificarJugador
            // 
            this.btnModificarJugador.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificarJugador.FlatAppearance.BorderSize = 0;
            this.btnModificarJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarJugador.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarJugador.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModificarJugador.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarJugador.Image")));
            this.btnModificarJugador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarJugador.Location = new System.Drawing.Point(627, 71);
            this.btnModificarJugador.Name = "btnModificarJugador";
            this.btnModificarJugador.Size = new System.Drawing.Size(210, 36);
            this.btnModificarJugador.TabIndex = 28;
            this.btnModificarJugador.Text = "M O D I F I C A R";
            this.btnModificarJugador.UseVisualStyleBackColor = false;
            this.btnModificarJugador.Click += new System.EventHandler(this.btnModificarJugador_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(69, 71);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(299, 36);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 29;
            this.panel1.Text = "panel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(39, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 1;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Zuby.ADGV.AdvancedDataGridView tablaJugadores;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private tablaJugadores tablaJugadores1;
        private System.Windows.Forms.BindingSource vwjugadorBindingSource;
        private tablaJugadoresTableAdapters.vwjugadorTableAdapter vwjugadorTableAdapter;
        private ReaLTaiizor.Controls.HopeButton btnActualizar;
        private System.Windows.Forms.Button btnAgregarJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdJugadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anotacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdRolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdEquipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdDeporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnModificarJugador;
        private ReaLTaiizor.Controls.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}