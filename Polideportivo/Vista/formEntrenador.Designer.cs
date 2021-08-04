
using Polideportivo.Datos;

namespace Polideportivo.Vista
{
    partial class formEntrenador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEntrenador));
            this.tablaEntrenador = new Zuby.ADGV.AdvancedDataGridView();
            this.pkIdEntrenadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkIdEquipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwentrenadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwEntrenador = new Polideportivo.vwEntrenador();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreEntrenador = new System.Windows.Forms.TextBox();
            this.btnEliminarEntrenador = new System.Windows.Forms.Button();
            this.btnActualizarEntrenador = new System.Windows.Forms.Button();
            this.panelBuscarCol = new System.Windows.Forms.Panel();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnModificarEntrenador = new System.Windows.Forms.Button();
            this.btnAgregarEntrenador = new System.Windows.Forms.Button();
            this.vwentrenadorTableAdapter = new Polideportivo.vwEntrenadorTableAdapters.vwentrenadorTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEntrenador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwentrenadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEntrenador)).BeginInit();
            this.parrotGradientPanel1.SuspendLayout();
            this.panelBuscarCol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaEntrenador
            // 
            this.tablaEntrenador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaEntrenador.AutoGenerateColumns = false;
            this.tablaEntrenador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaEntrenador.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaEntrenador.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaEntrenador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaEntrenador.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaEntrenador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaEntrenador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEntrenador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkIdEntrenadorDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.pkIdEquipoDataGridViewTextBoxColumn,
            this.equipoDataGridViewTextBoxColumn});
            this.tablaEntrenador.DataSource = this.vwentrenadorBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaEntrenador.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaEntrenador.FilterAndSortEnabled = true;
            this.tablaEntrenador.Location = new System.Drawing.Point(85, 143);
            this.tablaEntrenador.Name = "tablaEntrenador";
            this.tablaEntrenador.ReadOnly = true;
            this.tablaEntrenador.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tablaEntrenador.RowHeadersVisible = false;
            this.tablaEntrenador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaEntrenador.Size = new System.Drawing.Size(400, 407);
            this.tablaEntrenador.TabIndex = 5;
            this.tablaEntrenador.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaEntrenador_CellClick);
            this.tablaEntrenador.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.tablaEntrenador_DataError);
            // 
            // pkIdEntrenadorDataGridViewTextBoxColumn
            // 
            this.pkIdEntrenadorDataGridViewTextBoxColumn.DataPropertyName = "pkIdEntrenador";
            this.pkIdEntrenadorDataGridViewTextBoxColumn.HeaderText = "pkIdEntrenador";
            this.pkIdEntrenadorDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pkIdEntrenadorDataGridViewTextBoxColumn.Name = "pkIdEntrenadorDataGridViewTextBoxColumn";
            this.pkIdEntrenadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdEntrenadorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // vwentrenadorBindingSource
            // 
            this.vwentrenadorBindingSource.DataMember = "vwentrenador";
            this.vwentrenadorBindingSource.DataSource = this.vwEntrenador;
            // 
            // vwEntrenador
            // 
            this.vwEntrenador.DataSetName = "vwEntrenador";
            this.vwEntrenador.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.MidnightBlue;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Controls.Add(this.comboBox1);
            this.parrotGradientPanel1.Controls.Add(this.cboRol);
            this.parrotGradientPanel1.Controls.Add(this.label1);
            this.parrotGradientPanel1.Controls.Add(this.lblNombre);
            this.parrotGradientPanel1.Controls.Add(this.txtNombreEntrenador);
            this.parrotGradientPanel1.Controls.Add(this.btnEliminarEntrenador);
            this.parrotGradientPanel1.Controls.Add(this.btnActualizarEntrenador);
            this.parrotGradientPanel1.Controls.Add(this.panelBuscarCol);
            this.parrotGradientPanel1.Controls.Add(this.panel2);
            this.parrotGradientPanel1.Controls.Add(this.btnModificarEntrenador);
            this.parrotGradientPanel1.Controls.Add(this.btnAgregarEntrenador);
            this.parrotGradientPanel1.Controls.Add(this.tablaEntrenador);
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
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.CornflowerBlue;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(568, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 18);
            this.lblNombre.TabIndex = 35;
            this.lblNombre.Text = "NOMBRE";
            // 
            // txtNombreEntrenador
            // 
            this.txtNombreEntrenador.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtNombreEntrenador.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEntrenador.Location = new System.Drawing.Point(571, 46);
            this.txtNombreEntrenador.Name = "txtNombreEntrenador";
            this.txtNombreEntrenador.Size = new System.Drawing.Size(226, 27);
            this.txtNombreEntrenador.TabIndex = 34;
            // 
            // btnEliminarEntrenador
            // 
            this.btnEliminarEntrenador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarEntrenador.BackColor = System.Drawing.Color.White;
            this.btnEliminarEntrenador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEntrenador.FlatAppearance.BorderSize = 0;
            this.btnEliminarEntrenador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminarEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEntrenador.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEntrenador.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarEntrenador.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarEntrenador.Image")));
            this.btnEliminarEntrenador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarEntrenador.Location = new System.Drawing.Point(571, 397);
            this.btnEliminarEntrenador.Name = "btnEliminarEntrenador";
            this.btnEliminarEntrenador.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnEliminarEntrenador.Size = new System.Drawing.Size(226, 58);
            this.btnEliminarEntrenador.TabIndex = 33;
            this.btnEliminarEntrenador.Text = "   E L I M I N A R";
            this.btnEliminarEntrenador.UseVisualStyleBackColor = false;
            this.btnEliminarEntrenador.Click += new System.EventHandler(this.btnEliminarEntrenador_Click);
            // 
            // btnActualizarEntrenador
            // 
            this.btnActualizarEntrenador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarEntrenador.BackColor = System.Drawing.Color.White;
            this.btnActualizarEntrenador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarEntrenador.FlatAppearance.BorderSize = 0;
            this.btnActualizarEntrenador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnActualizarEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEntrenador.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEntrenador.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarEntrenador.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarEntrenador.Image")));
            this.btnActualizarEntrenador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarEntrenador.Location = new System.Drawing.Point(571, 481);
            this.btnActualizarEntrenador.Name = "btnActualizarEntrenador";
            this.btnActualizarEntrenador.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnActualizarEntrenador.Size = new System.Drawing.Size(226, 58);
            this.btnActualizarEntrenador.TabIndex = 32;
            this.btnActualizarEntrenador.Text = "      A C T U A L I Z A R";
            this.btnActualizarEntrenador.UseVisualStyleBackColor = false;
            this.btnActualizarEntrenador.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panelBuscarCol
            // 
            this.panelBuscarCol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBuscarCol.BackColor = System.Drawing.Color.White;
            this.panelBuscarCol.Controls.Add(this.cboBuscar);
            this.panelBuscarCol.Controls.Add(this.pictureBox2);
            this.panelBuscarCol.Location = new System.Drawing.Point(85, 40);
            this.panelBuscarCol.Name = "panelBuscarCol";
            this.panelBuscarCol.Size = new System.Drawing.Size(400, 36);
            this.panelBuscarCol.TabIndex = 31;
            // 
            // cboBuscar
            // 
            this.cboBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBuscar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Items.AddRange(new object[] {
            "nombre"});
            this.cboBuscar.Location = new System.Drawing.Point(36, 6);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(364, 26);
            this.cboBuscar.TabIndex = 32;
            this.cboBuscar.SelectedIndexChanged += new System.EventHandler(this.cboBuscar_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtFiltrar);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(85, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 36);
            this.panel2.TabIndex = 30;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFiltrar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrar.Location = new System.Drawing.Point(37, 9);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(353, 20);
            this.txtFiltrar.TabIndex = 1;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnModificarEntrenador
            // 
            this.btnModificarEntrenador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarEntrenador.BackColor = System.Drawing.Color.White;
            this.btnModificarEntrenador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarEntrenador.FlatAppearance.BorderSize = 0;
            this.btnModificarEntrenador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModificarEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEntrenador.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEntrenador.ForeColor = System.Drawing.Color.Black;
            this.btnModificarEntrenador.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarEntrenador.Image")));
            this.btnModificarEntrenador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarEntrenador.Location = new System.Drawing.Point(571, 311);
            this.btnModificarEntrenador.Name = "btnModificarEntrenador";
            this.btnModificarEntrenador.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnModificarEntrenador.Size = new System.Drawing.Size(226, 58);
            this.btnModificarEntrenador.TabIndex = 28;
            this.btnModificarEntrenador.Text = "    M O D I F I C A R";
            this.btnModificarEntrenador.UseVisualStyleBackColor = false;
            this.btnModificarEntrenador.Click += new System.EventHandler(this.btnModificarEntrenador_Click);
            // 
            // btnAgregarEntrenador
            // 
            this.btnAgregarEntrenador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarEntrenador.BackColor = System.Drawing.Color.White;
            this.btnAgregarEntrenador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarEntrenador.FlatAppearance.BorderSize = 0;
            this.btnAgregarEntrenador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEntrenador.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEntrenador.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarEntrenador.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEntrenador.Image")));
            this.btnAgregarEntrenador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEntrenador.Location = new System.Drawing.Point(571, 225);
            this.btnAgregarEntrenador.Name = "btnAgregarEntrenador";
            this.btnAgregarEntrenador.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAgregarEntrenador.Size = new System.Drawing.Size(226, 58);
            this.btnAgregarEntrenador.TabIndex = 27;
            this.btnAgregarEntrenador.Text = "     A G R E G A R";
            this.btnAgregarEntrenador.UseVisualStyleBackColor = false;
            this.btnAgregarEntrenador.Click += new System.EventHandler(this.btnAgregarEntrenador_Click);
            // 
            // vwentrenadorTableAdapter
            // 
            this.vwentrenadorTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(568, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "NOMBRE";
            // 
            // cboRol
            // 
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRol.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(571, 178);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(121, 27);
            this.cboRol.TabIndex = 38;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(571, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 39;
            // 
            // formEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 595);
            this.Controls.Add(this.parrotGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formEntrenador";
            this.Text = "formEntrenador";
            this.Load += new System.EventHandler(this.formDeporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaEntrenador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwentrenadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEntrenador)).EndInit();
            this.parrotGradientPanel1.ResumeLayout(false);
            this.parrotGradientPanel1.PerformLayout();
            this.panelBuscarCol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Zuby.ADGV.AdvancedDataGridView tablaEntrenador;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private System.Windows.Forms.Button btnAgregarEntrenador;
        private System.Windows.Forms.Button btnModificarEntrenador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnActualizarEntrenador;
        private System.Windows.Forms.Button btnEliminarEntrenador;
        private System.Windows.Forms.TextBox txtNombreEntrenador;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panelBuscarCol;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private vwEntrenador vwEntrenador;
        private System.Windows.Forms.BindingSource vwentrenadorBindingSource;
        private vwEntrenadorTableAdapters.vwentrenadorTableAdapter vwentrenadorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdEntrenadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdEquipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cboRol;
    }
}