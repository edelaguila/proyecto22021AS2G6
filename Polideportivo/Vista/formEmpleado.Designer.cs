
using Datos;

namespace Vista
{
    partial class formEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEmpleado));
            this.tablaEmpleado = new Zuby.ADGV.AdvancedDataGridView();
            this.pkIdEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkIdPuestoEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puestoempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwempleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwEmpleado = new Datos.vwEmpleado();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.cboPuesto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnActualizarEmpleado = new System.Windows.Forms.Button();
            this.panelBuscarCol = new System.Windows.Forms.Panel();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.vwempleadoTableAdapter = new Datos.vwEmpleadoTableAdapters.vwempleadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwempleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEmpleado)).BeginInit();
            this.parrotGradientPanel1.SuspendLayout();
            this.panelBuscarCol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaEmpleado
            // 
            this.tablaEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaEmpleado.AutoGenerateColumns = false;
            this.tablaEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaEmpleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaEmpleado.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaEmpleado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkIdEmpleadoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.pkIdPuestoEmpleadoDataGridViewTextBoxColumn,
            this.puestoempleadoDataGridViewTextBoxColumn});
            this.tablaEmpleado.DataSource = this.vwempleadoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaEmpleado.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaEmpleado.FilterAndSortEnabled = true;
            this.tablaEmpleado.Location = new System.Drawing.Point(85, 143);
            this.tablaEmpleado.Name = "tablaEmpleado";
            this.tablaEmpleado.ReadOnly = true;
            this.tablaEmpleado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tablaEmpleado.RowHeadersVisible = false;
            this.tablaEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaEmpleado.Size = new System.Drawing.Size(400, 407);
            this.tablaEmpleado.TabIndex = 5;
            this.tablaEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaEmpleado_CellClick);
            // 
            // pkIdEmpleadoDataGridViewTextBoxColumn
            // 
            this.pkIdEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "pkIdEmpleado";
            this.pkIdEmpleadoDataGridViewTextBoxColumn.HeaderText = "pkIdEmpleado";
            this.pkIdEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pkIdEmpleadoDataGridViewTextBoxColumn.Name = "pkIdEmpleadoDataGridViewTextBoxColumn";
            this.pkIdEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdEmpleadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // pkIdPuestoEmpleadoDataGridViewTextBoxColumn
            // 
            this.pkIdPuestoEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "pkIdPuestoEmpleado";
            this.pkIdPuestoEmpleadoDataGridViewTextBoxColumn.HeaderText = "pkIdPuestoEmpleado";
            this.pkIdPuestoEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pkIdPuestoEmpleadoDataGridViewTextBoxColumn.Name = "pkIdPuestoEmpleadoDataGridViewTextBoxColumn";
            this.pkIdPuestoEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdPuestoEmpleadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pkIdPuestoEmpleadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // puestoempleadoDataGridViewTextBoxColumn
            // 
            this.puestoempleadoDataGridViewTextBoxColumn.DataPropertyName = "puestoempleado";
            this.puestoempleadoDataGridViewTextBoxColumn.HeaderText = "Puestoempleado";
            this.puestoempleadoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.puestoempleadoDataGridViewTextBoxColumn.Name = "puestoempleadoDataGridViewTextBoxColumn";
            this.puestoempleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.puestoempleadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // vwempleadoBindingSource
            // 
            this.vwempleadoBindingSource.DataMember = "vwempleado";
            this.vwempleadoBindingSource.DataSource = this.vwEmpleado;
            // 
            // vwEmpleado
            // 
            this.vwEmpleado.DataSetName = "vwEmpleado";
            this.vwEmpleado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.MidnightBlue;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            this.parrotGradientPanel1.Controls.Add(this.cboPuesto);
            this.parrotGradientPanel1.Controls.Add(this.label1);
            this.parrotGradientPanel1.Controls.Add(this.lblNombre);
            this.parrotGradientPanel1.Controls.Add(this.txtNombre);
            this.parrotGradientPanel1.Controls.Add(this.btnEliminarEmpleado);
            this.parrotGradientPanel1.Controls.Add(this.btnActualizarEmpleado);
            this.parrotGradientPanel1.Controls.Add(this.panelBuscarCol);
            this.parrotGradientPanel1.Controls.Add(this.panel2);
            this.parrotGradientPanel1.Controls.Add(this.btnModificarEmpleado);
            this.parrotGradientPanel1.Controls.Add(this.btnAgregarEmpleado);
            this.parrotGradientPanel1.Controls.Add(this.tablaEmpleado);
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
            // 
            // cboPuesto
            // 
            this.cboPuesto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPuesto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPuesto.FormattingEnabled = true;
            this.cboPuesto.Location = new System.Drawing.Point(571, 147);
            this.cboPuesto.Name = "cboPuesto";
            this.cboPuesto.Size = new System.Drawing.Size(226, 27);
            this.cboPuesto.TabIndex = 39;
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
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "PUESTO EMPLEADO";
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
            this.lblNombre.Size = new System.Drawing.Size(151, 18);
            this.lblNombre.TabIndex = 35;
            this.lblNombre.Text = "NOMBRE EMPLEADO";
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
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.White;
            this.btnEliminarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEliminarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarEmpleado.Image")));
            this.btnEliminarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(571, 379);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(226, 58);
            this.btnEliminarEmpleado.TabIndex = 33;
            this.btnEliminarEmpleado.Text = "   E L I M I N A R";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnActualizarEmpleado.BackColor = System.Drawing.Color.White;
            this.btnActualizarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnActualizarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnActualizarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEmpleado.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarEmpleado.Image")));
            this.btnActualizarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(571, 464);
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(226, 58);
            this.btnActualizarEmpleado.TabIndex = 32;
            this.btnActualizarEmpleado.Text = "      A C T U A L I Z A R";
            this.btnActualizarEmpleado.UseVisualStyleBackColor = false;
            this.btnActualizarEmpleado.Click += new System.EventHandler(this.btnActualizar_Click);
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
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModificarEmpleado.BackColor = System.Drawing.Color.White;
            this.btnModificarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnModificarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModificarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEmpleado.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnModificarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarEmpleado.Image")));
            this.btnModificarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarEmpleado.Location = new System.Drawing.Point(571, 294);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnModificarEmpleado.Size = new System.Drawing.Size(226, 58);
            this.btnModificarEmpleado.TabIndex = 28;
            this.btnModificarEmpleado.Text = "    M O D I F I C A R";
            this.btnModificarEmpleado.UseVisualStyleBackColor = false;
            this.btnModificarEmpleado.Click += new System.EventHandler(this.btnModificarEmpleado_Click);
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregarEmpleado.BackColor = System.Drawing.Color.White;
            this.btnAgregarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnAgregarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEmpleado.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEmpleado.Image")));
            this.btnAgregarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(571, 209);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(226, 58);
            this.btnAgregarEmpleado.TabIndex = 27;
            this.btnAgregarEmpleado.Text = "     A G R E G A R";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = false;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // vwempleadoTableAdapter
            // 
            this.vwempleadoTableAdapter.ClearBeforeFill = true;
            // 
            // formEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 595);
            this.Controls.Add(this.parrotGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formEmpleado";
            this.Text = "formEmpleado";
            this.Load += new System.EventHandler(this.formEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwempleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEmpleado)).EndInit();
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
        private Zuby.ADGV.AdvancedDataGridView tablaEmpleado;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnModificarEmpleado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnActualizarEmpleado;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panelBuscarCol;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdEntrenadorDataGridViewTextBoxColumn;
        private vwEmpleado vwEmpleado;
        private System.Windows.Forms.BindingSource vwempleadoBindingSource;
        private Datos.vwEmpleadoTableAdapters.vwempleadoTableAdapter vwempleadoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdPuestoEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puestoempleadoDataGridViewTextBoxColumn;
    }
}