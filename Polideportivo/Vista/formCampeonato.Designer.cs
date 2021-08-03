using Polideportivo.Datos;
using static Polideportivo.Vista.utilidadForms;
namespace Polideportivo.Vista
{
    partial class formCampeonato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCampeonato));
            this.tablaCampeonatos = new Zuby.ADGV.AdvancedDataGridView();
            this.pkIdCampeonatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campeonatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkIdDeporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkIdTipoCampeonatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCampeonatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwcampeonatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwCampeonato = new Polideportivo.Datos.vwCampeonato();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.btnEliminarCampeonato = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panelBuscarCol = new System.Windows.Forms.Panel();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnModificarCampeonato = new System.Windows.Forms.Button();
            this.btnAgregarCampeonato = new System.Windows.Forms.Button();
            this.vwcampeonatoTableAdapter = new Polideportivo.Datos.vwCampeonatoTableAdapters.vwcampeonatoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCampeonatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcampeonatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCampeonato)).BeginInit();
            this.parrotGradientPanel1.SuspendLayout();
            this.panelBuscarCol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaCampeonatos
            // 
            this.tablaCampeonatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaCampeonatos.AutoGenerateColumns = false;
            this.tablaCampeonatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaCampeonatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaCampeonatos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaCampeonatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaCampeonatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCampeonatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaCampeonatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCampeonatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkIdCampeonatoDataGridViewTextBoxColumn,
            this.campeonatoDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.fechaFinalDataGridViewTextBoxColumn,
            this.pkIdDeporteDataGridViewTextBoxColumn,
            this.deporteDataGridViewTextBoxColumn,
            this.pkIdTipoCampeonatoDataGridViewTextBoxColumn,
            this.tipoCampeonatoDataGridViewTextBoxColumn});
            this.tablaCampeonatos.DataSource = this.vwcampeonatoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaCampeonatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaCampeonatos.FilterAndSortEnabled = true;
            this.tablaCampeonatos.Location = new System.Drawing.Point(69, 123);
            this.tablaCampeonatos.Name = "tablaCampeonatos";
            this.tablaCampeonatos.ReadOnly = true;
            this.tablaCampeonatos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tablaCampeonatos.RowHeadersVisible = false;
            this.tablaCampeonatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCampeonatos.Size = new System.Drawing.Size(768, 413);
            this.tablaCampeonatos.TabIndex = 5;
            this.tablaCampeonatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCampeonatos_CellClick);
            this.tablaCampeonatos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.tablaCampeonatos_DataError);
            // 
            // pkIdCampeonatoDataGridViewTextBoxColumn
            // 
            this.pkIdCampeonatoDataGridViewTextBoxColumn.DataPropertyName = "pkIdCampeonato";
            this.pkIdCampeonatoDataGridViewTextBoxColumn.HeaderText = "pkIdCampeonato";
            this.pkIdCampeonatoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pkIdCampeonatoDataGridViewTextBoxColumn.Name = "pkIdCampeonatoDataGridViewTextBoxColumn";
            this.pkIdCampeonatoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdCampeonatoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pkIdCampeonatoDataGridViewTextBoxColumn.Visible = false;
            // 
            // campeonatoDataGridViewTextBoxColumn
            // 
            this.campeonatoDataGridViewTextBoxColumn.DataPropertyName = "campeonato";
            this.campeonatoDataGridViewTextBoxColumn.HeaderText = "campeonato";
            this.campeonatoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.campeonatoDataGridViewTextBoxColumn.Name = "campeonatoDataGridViewTextBoxColumn";
            this.campeonatoDataGridViewTextBoxColumn.ReadOnly = true;
            this.campeonatoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "fechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "fechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            this.fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaInicioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaFinalDataGridViewTextBoxColumn
            // 
            this.fechaFinalDataGridViewTextBoxColumn.DataPropertyName = "fechaFinal";
            this.fechaFinalDataGridViewTextBoxColumn.HeaderText = "fechaFinal";
            this.fechaFinalDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fechaFinalDataGridViewTextBoxColumn.Name = "fechaFinalDataGridViewTextBoxColumn";
            this.fechaFinalDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaFinalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            this.deporteDataGridViewTextBoxColumn.HeaderText = "deporte";
            this.deporteDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.deporteDataGridViewTextBoxColumn.Name = "deporteDataGridViewTextBoxColumn";
            this.deporteDataGridViewTextBoxColumn.ReadOnly = true;
            this.deporteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pkIdTipoCampeonatoDataGridViewTextBoxColumn
            // 
            this.pkIdTipoCampeonatoDataGridViewTextBoxColumn.DataPropertyName = "pkIdTipoCampeonato";
            this.pkIdTipoCampeonatoDataGridViewTextBoxColumn.HeaderText = "pkIdTipoCampeonato";
            this.pkIdTipoCampeonatoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pkIdTipoCampeonatoDataGridViewTextBoxColumn.Name = "pkIdTipoCampeonatoDataGridViewTextBoxColumn";
            this.pkIdTipoCampeonatoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdTipoCampeonatoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pkIdTipoCampeonatoDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoCampeonatoDataGridViewTextBoxColumn
            // 
            this.tipoCampeonatoDataGridViewTextBoxColumn.DataPropertyName = "tipoCampeonato";
            this.tipoCampeonatoDataGridViewTextBoxColumn.HeaderText = "tipoCampeonato";
            this.tipoCampeonatoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.tipoCampeonatoDataGridViewTextBoxColumn.Name = "tipoCampeonatoDataGridViewTextBoxColumn";
            this.tipoCampeonatoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoCampeonatoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // vwcampeonatoBindingSource
            // 
            this.vwcampeonatoBindingSource.DataMember = "vwcampeonato";
            this.vwcampeonatoBindingSource.DataSource = this.vwCampeonato;
            // 
            // vwCampeonato
            // 
            this.vwCampeonato.DataSetName = "vwCampeonato";
            this.vwCampeonato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.MidnightBlue;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Controls.Add(this.btnEliminarCampeonato);
            this.parrotGradientPanel1.Controls.Add(this.btnActualizar);
            this.parrotGradientPanel1.Controls.Add(this.panelBuscarCol);
            this.parrotGradientPanel1.Controls.Add(this.panel2);
            this.parrotGradientPanel1.Controls.Add(this.btnModificarCampeonato);
            this.parrotGradientPanel1.Controls.Add(this.btnAgregarCampeonato);
            this.parrotGradientPanel1.Controls.Add(this.tablaCampeonatos);
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
            // btnEliminarCampeonato
            // 
            this.btnEliminarCampeonato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarCampeonato.BackColor = System.Drawing.Color.White;
            this.btnEliminarCampeonato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCampeonato.FlatAppearance.BorderSize = 0;
            this.btnEliminarCampeonato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminarCampeonato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCampeonato.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCampeonato.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarCampeonato.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCampeonato.Image")));
            this.btnEliminarCampeonato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCampeonato.Location = new System.Drawing.Point(627, 20);
            this.btnEliminarCampeonato.Name = "btnEliminarCampeonato";
            this.btnEliminarCampeonato.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnEliminarCampeonato.Size = new System.Drawing.Size(210, 36);
            this.btnEliminarCampeonato.TabIndex = 33;
            this.btnEliminarCampeonato.Text = "   E L I M I N A R";
            this.btnEliminarCampeonato.UseVisualStyleBackColor = false;
            this.btnEliminarCampeonato.Click += new System.EventHandler(this.btnEliminarCampeonato_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(392, 20);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnActualizar.Size = new System.Drawing.Size(210, 36);
            this.btnActualizar.TabIndex = 32;
            this.btnActualizar.Text = "      A C T U A L I Z A R";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panelBuscarCol
            // 
            this.panelBuscarCol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBuscarCol.BackColor = System.Drawing.Color.White;
            this.panelBuscarCol.Controls.Add(this.cboBuscar);
            this.panelBuscarCol.Controls.Add(this.pictureBox2);
            this.panelBuscarCol.Location = new System.Drawing.Point(69, 20);
            this.panelBuscarCol.Name = "panelBuscarCol";
            this.panelBuscarCol.Size = new System.Drawing.Size(299, 36);
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
            "campeonato",
            "deporte"});
            this.cboBuscar.Location = new System.Drawing.Point(36, 6);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(263, 26);
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
            this.panel2.Location = new System.Drawing.Point(69, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 36);
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
            this.txtFiltrar.Size = new System.Drawing.Size(252, 20);
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
            // btnModificarCampeonato
            // 
            this.btnModificarCampeonato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarCampeonato.BackColor = System.Drawing.Color.White;
            this.btnModificarCampeonato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarCampeonato.FlatAppearance.BorderSize = 0;
            this.btnModificarCampeonato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModificarCampeonato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCampeonato.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCampeonato.ForeColor = System.Drawing.Color.Black;
            this.btnModificarCampeonato.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarCampeonato.Image")));
            this.btnModificarCampeonato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarCampeonato.Location = new System.Drawing.Point(627, 69);
            this.btnModificarCampeonato.Name = "btnModificarCampeonato";
            this.btnModificarCampeonato.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnModificarCampeonato.Size = new System.Drawing.Size(210, 36);
            this.btnModificarCampeonato.TabIndex = 28;
            this.btnModificarCampeonato.Text = "    M O D I F I C A R";
            this.btnModificarCampeonato.UseVisualStyleBackColor = false;
            this.btnModificarCampeonato.Click += new System.EventHandler(this.btnModificarJugador_Click);
            // 
            // btnAgregarCampeonato
            // 
            this.btnAgregarCampeonato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCampeonato.BackColor = System.Drawing.Color.White;
            this.btnAgregarCampeonato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCampeonato.FlatAppearance.BorderSize = 0;
            this.btnAgregarCampeonato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarCampeonato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCampeonato.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCampeonato.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCampeonato.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCampeonato.Image")));
            this.btnAgregarCampeonato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCampeonato.Location = new System.Drawing.Point(392, 69);
            this.btnAgregarCampeonato.Name = "btnAgregarCampeonato";
            this.btnAgregarCampeonato.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAgregarCampeonato.Size = new System.Drawing.Size(210, 36);
            this.btnAgregarCampeonato.TabIndex = 27;
            this.btnAgregarCampeonato.Text = "     A G R E G A R";
            this.btnAgregarCampeonato.UseVisualStyleBackColor = false;
            this.btnAgregarCampeonato.Click += new System.EventHandler(this.btnAgregarJugador_Click);
            // 
            // vwcampeonatoTableAdapter
            // 
            this.vwcampeonatoTableAdapter.ClearBeforeFill = true;
            // 
            // formCampeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 595);
            this.Controls.Add(this.parrotGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCampeonato";
            this.Text = "formCampeonato";
            this.Load += new System.EventHandler(this.formCampeonato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCampeonatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcampeonatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCampeonato)).EndInit();
            this.parrotGradientPanel1.ResumeLayout(false);
            this.panelBuscarCol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Zuby.ADGV.AdvancedDataGridView tablaCampeonatos;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private System.Windows.Forms.Button btnAgregarCampeonato;
        private System.Windows.Forms.Button btnModificarCampeonato;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBuscarCol;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminarCampeonato;
        private vwCampeonato vwCampeonato;
        private System.Windows.Forms.BindingSource vwcampeonatoBindingSource;
        private Datos.vwCampeonatoTableAdapters.vwcampeonatoTableAdapter vwcampeonatoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdCampeonatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campeonatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdDeporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdTipoCampeonatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCampeonatoDataGridViewTextBoxColumn;
    }
}