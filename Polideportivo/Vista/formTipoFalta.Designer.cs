
using Datos;

namespace Vista
{
    partial class formTipoFalta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTipoFalta));
            this.tablaTipoFalta = new Zuby.ADGV.AdvancedDataGridView();
            this.pkIdTipoFaltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkIdDeporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwtipofaltaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwTipoFalta = new Datos.vwTipoFalta();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.cboDeporte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnEliminarFalta = new System.Windows.Forms.Button();
            this.btnActualizarFalta = new System.Windows.Forms.Button();
            this.panelBuscarCol = new System.Windows.Forms.Panel();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnModificarFalta = new System.Windows.Forms.Button();
            this.btnAgregarFalta = new System.Windows.Forms.Button();
            this.vwtipofaltaTableAdapter = new Datos.vwTipoFaltaTableAdapters.vwtipofaltaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoFalta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwtipofaltaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTipoFalta)).BeginInit();
            this.parrotGradientPanel1.SuspendLayout();
            this.panelBuscarCol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaTipoFalta
            // 
            this.tablaTipoFalta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaTipoFalta.AutoGenerateColumns = false;
            this.tablaTipoFalta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaTipoFalta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaTipoFalta.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaTipoFalta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaTipoFalta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaTipoFalta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaTipoFalta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTipoFalta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkIdTipoFaltaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.pkIdDeporteDataGridViewTextBoxColumn,
            this.deporteDataGridViewTextBoxColumn});
            this.tablaTipoFalta.DataSource = this.vwtipofaltaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaTipoFalta.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaTipoFalta.FilterAndSortEnabled = true;
            this.tablaTipoFalta.Location = new System.Drawing.Point(85, 143);
            this.tablaTipoFalta.Name = "tablaTipoFalta";
            this.tablaTipoFalta.ReadOnly = true;
            this.tablaTipoFalta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tablaTipoFalta.RowHeadersVisible = false;
            this.tablaTipoFalta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaTipoFalta.Size = new System.Drawing.Size(400, 407);
            this.tablaTipoFalta.TabIndex = 5;
            this.tablaTipoFalta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaTipoFalta_CellClick);
            // 
            // pkIdTipoFaltaDataGridViewTextBoxColumn
            // 
            this.pkIdTipoFaltaDataGridViewTextBoxColumn.DataPropertyName = "pkIdTipoFalta";
            this.pkIdTipoFaltaDataGridViewTextBoxColumn.HeaderText = "pkIdTipoFalta";
            this.pkIdTipoFaltaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pkIdTipoFaltaDataGridViewTextBoxColumn.Name = "pkIdTipoFaltaDataGridViewTextBoxColumn";
            this.pkIdTipoFaltaDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdTipoFaltaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // vwtipofaltaBindingSource
            // 
            this.vwtipofaltaBindingSource.DataMember = "vwtipofalta";
            this.vwtipofaltaBindingSource.DataSource = this.vwTipoFalta;
            // 
            // vwTipoFalta
            // 
            this.vwTipoFalta.DataSetName = "vwTipoFalta";
            this.vwTipoFalta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.MidnightBlue;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            this.parrotGradientPanel1.Controls.Add(this.cboDeporte);
            this.parrotGradientPanel1.Controls.Add(this.label1);
            this.parrotGradientPanel1.Controls.Add(this.lblNombre);
            this.parrotGradientPanel1.Controls.Add(this.txtNombre);
            this.parrotGradientPanel1.Controls.Add(this.btnEliminarFalta);
            this.parrotGradientPanel1.Controls.Add(this.btnActualizarFalta);
            this.parrotGradientPanel1.Controls.Add(this.panelBuscarCol);
            this.parrotGradientPanel1.Controls.Add(this.panel2);
            this.parrotGradientPanel1.Controls.Add(this.btnModificarFalta);
            this.parrotGradientPanel1.Controls.Add(this.btnAgregarFalta);
            this.parrotGradientPanel1.Controls.Add(this.tablaTipoFalta);
            this.parrotGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.Low;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel1.Size = new System.Drawing.Size(900, 595);
            this.parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotGradientPanel1.TabIndex = 8;
            this.parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.CornflowerBlue;
            this.parrotGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.parrotGradientPanel1_Paint);
            // 
            // cboDeporte
            // 
            this.cboDeporte.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDeporte.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeporte.FormattingEnabled = true;
            this.cboDeporte.Location = new System.Drawing.Point(571, 147);
            this.cboDeporte.Name = "cboDeporte";
            this.cboDeporte.Size = new System.Drawing.Size(226, 27);
            this.cboDeporte.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(568, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "DEPORTE";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(568, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(156, 18);
            this.lblNombre.TabIndex = 35;
            this.lblNombre.Text = "AGREGAR TIPO FALTA";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(571, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 27);
            this.txtNombre.TabIndex = 34;
            // 
            // btnEliminarFalta
            // 
            this.btnEliminarFalta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarFalta.BackColor = System.Drawing.Color.White;
            this.btnEliminarFalta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarFalta.FlatAppearance.BorderSize = 0;
            this.btnEliminarFalta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminarFalta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFalta.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFalta.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarFalta.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarFalta.Image")));
            this.btnEliminarFalta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarFalta.Location = new System.Drawing.Point(571, 379);
            this.btnEliminarFalta.Name = "btnEliminarFalta";
            this.btnEliminarFalta.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnEliminarFalta.Size = new System.Drawing.Size(226, 58);
            this.btnEliminarFalta.TabIndex = 33;
            this.btnEliminarFalta.Text = "   E L I M I N A R";
            this.btnEliminarFalta.UseVisualStyleBackColor = false;
            this.btnEliminarFalta.Click += new System.EventHandler(this.btnEliminarTipoFalta_Click);
            // 
            // btnActualizarFalta
            // 
            this.btnActualizarFalta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnActualizarFalta.BackColor = System.Drawing.Color.White;
            this.btnActualizarFalta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarFalta.FlatAppearance.BorderSize = 0;
            this.btnActualizarFalta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnActualizarFalta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarFalta.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarFalta.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarFalta.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarFalta.Image")));
            this.btnActualizarFalta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarFalta.Location = new System.Drawing.Point(571, 464);
            this.btnActualizarFalta.Name = "btnActualizarFalta";
            this.btnActualizarFalta.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnActualizarFalta.Size = new System.Drawing.Size(226, 58);
            this.btnActualizarFalta.TabIndex = 32;
            this.btnActualizarFalta.Text = "      A C T U A L I Z A R";
            this.btnActualizarFalta.UseVisualStyleBackColor = false;
            this.btnActualizarFalta.Click += new System.EventHandler(this.btnActualizar_Click);
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
            // btnModificarFalta
            // 
            this.btnModificarFalta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModificarFalta.BackColor = System.Drawing.Color.White;
            this.btnModificarFalta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarFalta.FlatAppearance.BorderSize = 0;
            this.btnModificarFalta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModificarFalta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarFalta.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarFalta.ForeColor = System.Drawing.Color.Black;
            this.btnModificarFalta.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarFalta.Image")));
            this.btnModificarFalta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarFalta.Location = new System.Drawing.Point(571, 292);
            this.btnModificarFalta.Name = "btnModificarFalta";
            this.btnModificarFalta.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnModificarFalta.Size = new System.Drawing.Size(226, 58);
            this.btnModificarFalta.TabIndex = 28;
            this.btnModificarFalta.Text = "    M O D I F I C A R";
            this.btnModificarFalta.UseVisualStyleBackColor = false;
            this.btnModificarFalta.Click += new System.EventHandler(this.btnModificarTipoFalta_Click);
            // 
            // btnAgregarFalta
            // 
            this.btnAgregarFalta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregarFalta.BackColor = System.Drawing.Color.White;
            this.btnAgregarFalta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarFalta.FlatAppearance.BorderSize = 0;
            this.btnAgregarFalta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarFalta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFalta.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFalta.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarFalta.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarFalta.Image")));
            this.btnAgregarFalta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarFalta.Location = new System.Drawing.Point(571, 209);
            this.btnAgregarFalta.Name = "btnAgregarFalta";
            this.btnAgregarFalta.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAgregarFalta.Size = new System.Drawing.Size(226, 58);
            this.btnAgregarFalta.TabIndex = 27;
            this.btnAgregarFalta.Text = "     A G R E G A R";
            this.btnAgregarFalta.UseVisualStyleBackColor = false;
            this.btnAgregarFalta.Click += new System.EventHandler(this.btnAgregarTipoFalta_Click);
            // 
            // vwtipofaltaTableAdapter
            // 
            this.vwtipofaltaTableAdapter.ClearBeforeFill = true;
            // 
            // formTipoFalta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 595);
            this.Controls.Add(this.parrotGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formTipoFalta";
            this.Text = "formTipoFalta";
            this.Load += new System.EventHandler(this.formTipoFalta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoFalta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwtipofaltaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTipoFalta)).EndInit();
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
        private Zuby.ADGV.AdvancedDataGridView tablaTipoFalta;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private System.Windows.Forms.Button btnAgregarFalta;
        private System.Windows.Forms.Button btnModificarFalta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnActualizarFalta;
        private System.Windows.Forms.Button btnEliminarFalta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panelBuscarCol;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDeporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdEntrenadorDataGridViewTextBoxColumn;
        private vwTipoFalta vwTipoFalta;
        private System.Windows.Forms.BindingSource vwtipofaltaBindingSource;
        private Datos.vwTipoFaltaTableAdapters.vwtipofaltaTableAdapter vwtipofaltaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdTipoFaltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdDeporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deporteDataGridViewTextBoxColumn;
    }
}