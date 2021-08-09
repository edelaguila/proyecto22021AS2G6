
using Datos;
using Polideportivo;

namespace Vista
{
    partial class formResultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formResultado));
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.tablaPartidos = new Zuby.ADGV.AdvancedDataGridView();
            this.pkIdPartidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipo2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anotacionesEquipo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anotacionesEquipo2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkIdCampeonatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campeonatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkIdEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkIdEstadoPartidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwpartidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwPartido = new Datos.vwPartido();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panelBuscarCol = new System.Windows.Forms.Panel();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregarPartido = new System.Windows.Forms.Button();
            this.vwpartidoTableAdapter = new Datos.vwPartidoTableAdapters.vwpartidoTableAdapter();
            this.parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPartidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwpartidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPartido)).BeginInit();
            this.panelBuscarCol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.MidnightBlue;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            this.parrotGradientPanel1.Controls.Add(this.tablaPartidos);
            this.parrotGradientPanel1.Controls.Add(this.btnEliminar);
            this.parrotGradientPanel1.Controls.Add(this.btnActualizar);
            this.parrotGradientPanel1.Controls.Add(this.panelBuscarCol);
            this.parrotGradientPanel1.Controls.Add(this.panel2);
            this.parrotGradientPanel1.Controls.Add(this.btnModificar);
            this.parrotGradientPanel1.Controls.Add(this.btnAgregarPartido);
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
            // tablaPartidos
            // 
            this.tablaPartidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaPartidos.AutoGenerateColumns = false;
            this.tablaPartidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaPartidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaPartidos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaPartidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaPartidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaPartidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPartidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkIdPartidoDataGridViewTextBoxColumn,
            this.equipo1DataGridViewTextBoxColumn,
            this.equipo2DataGridViewTextBoxColumn,
            this.campoDataGridViewTextBoxColumn,
            this.anotacionesEquipo1DataGridViewTextBoxColumn,
            this.anotacionesEquipo2DataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.faseDataGridViewTextBoxColumn,
            this.pkIdCampeonatoDataGridViewTextBoxColumn,
            this.campeonatoDataGridViewTextBoxColumn,
            this.pkIdEmpleadoDataGridViewTextBoxColumn,
            this.empleadoDataGridViewTextBoxColumn,
            this.pkIdEstadoPartidoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.tablaPartidos.DataSource = this.vwpartidoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaPartidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaPartidos.FilterAndSortEnabled = true;
            this.tablaPartidos.Location = new System.Drawing.Point(69, 157);
            this.tablaPartidos.Name = "tablaPartidos";
            this.tablaPartidos.ReadOnly = true;
            this.tablaPartidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tablaPartidos.RowHeadersVisible = false;
            this.tablaPartidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPartidos.Size = new System.Drawing.Size(768, 413);
            this.tablaPartidos.TabIndex = 34;
            // 
            // pkIdPartidoDataGridViewTextBoxColumn
            // 
            this.pkIdPartidoDataGridViewTextBoxColumn.DataPropertyName = "pkIdPartido";
            this.pkIdPartidoDataGridViewTextBoxColumn.HeaderText = "pkIdPartido";
            this.pkIdPartidoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pkIdPartidoDataGridViewTextBoxColumn.Name = "pkIdPartidoDataGridViewTextBoxColumn";
            this.pkIdPartidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdPartidoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pkIdPartidoDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipo1DataGridViewTextBoxColumn
            // 
            this.equipo1DataGridViewTextBoxColumn.DataPropertyName = "equipo1";
            this.equipo1DataGridViewTextBoxColumn.HeaderText = "equipo1";
            this.equipo1DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.equipo1DataGridViewTextBoxColumn.Name = "equipo1DataGridViewTextBoxColumn";
            this.equipo1DataGridViewTextBoxColumn.ReadOnly = true;
            this.equipo1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // equipo2DataGridViewTextBoxColumn
            // 
            this.equipo2DataGridViewTextBoxColumn.DataPropertyName = "equipo2";
            this.equipo2DataGridViewTextBoxColumn.HeaderText = "equipo2";
            this.equipo2DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.equipo2DataGridViewTextBoxColumn.Name = "equipo2DataGridViewTextBoxColumn";
            this.equipo2DataGridViewTextBoxColumn.ReadOnly = true;
            this.equipo2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // campoDataGridViewTextBoxColumn
            // 
            this.campoDataGridViewTextBoxColumn.DataPropertyName = "campo";
            this.campoDataGridViewTextBoxColumn.HeaderText = "campo";
            this.campoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.campoDataGridViewTextBoxColumn.Name = "campoDataGridViewTextBoxColumn";
            this.campoDataGridViewTextBoxColumn.ReadOnly = true;
            this.campoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.campoDataGridViewTextBoxColumn.Visible = false;
            // 
            // anotacionesEquipo1DataGridViewTextBoxColumn
            // 
            this.anotacionesEquipo1DataGridViewTextBoxColumn.DataPropertyName = "anotacionesEquipo1";
            this.anotacionesEquipo1DataGridViewTextBoxColumn.HeaderText = "anotacionesEquipo1";
            this.anotacionesEquipo1DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.anotacionesEquipo1DataGridViewTextBoxColumn.Name = "anotacionesEquipo1DataGridViewTextBoxColumn";
            this.anotacionesEquipo1DataGridViewTextBoxColumn.ReadOnly = true;
            this.anotacionesEquipo1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // anotacionesEquipo2DataGridViewTextBoxColumn
            // 
            this.anotacionesEquipo2DataGridViewTextBoxColumn.DataPropertyName = "anotacionesEquipo2";
            this.anotacionesEquipo2DataGridViewTextBoxColumn.HeaderText = "anotacionesEquipo2";
            this.anotacionesEquipo2DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.anotacionesEquipo2DataGridViewTextBoxColumn.Name = "anotacionesEquipo2DataGridViewTextBoxColumn";
            this.anotacionesEquipo2DataGridViewTextBoxColumn.ReadOnly = true;
            this.anotacionesEquipo2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fechaDataGridViewTextBoxColumn.Visible = false;
            // 
            // faseDataGridViewTextBoxColumn
            // 
            this.faseDataGridViewTextBoxColumn.DataPropertyName = "fase";
            this.faseDataGridViewTextBoxColumn.HeaderText = "fase";
            this.faseDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.faseDataGridViewTextBoxColumn.Name = "faseDataGridViewTextBoxColumn";
            this.faseDataGridViewTextBoxColumn.ReadOnly = true;
            this.faseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.faseDataGridViewTextBoxColumn.Visible = false;
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
            // pkIdEmpleadoDataGridViewTextBoxColumn
            // 
            this.pkIdEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "pkIdEmpleado";
            this.pkIdEmpleadoDataGridViewTextBoxColumn.HeaderText = "pkIdEmpleado";
            this.pkIdEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pkIdEmpleadoDataGridViewTextBoxColumn.Name = "pkIdEmpleadoDataGridViewTextBoxColumn";
            this.pkIdEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdEmpleadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pkIdEmpleadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // empleadoDataGridViewTextBoxColumn
            // 
            this.empleadoDataGridViewTextBoxColumn.DataPropertyName = "empleado";
            this.empleadoDataGridViewTextBoxColumn.HeaderText = "empleado";
            this.empleadoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.empleadoDataGridViewTextBoxColumn.Name = "empleadoDataGridViewTextBoxColumn";
            this.empleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.empleadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.empleadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // pkIdEstadoPartidoDataGridViewTextBoxColumn
            // 
            this.pkIdEstadoPartidoDataGridViewTextBoxColumn.DataPropertyName = "pkIdEstadoPartido";
            this.pkIdEstadoPartidoDataGridViewTextBoxColumn.HeaderText = "pkIdEstadoPartido";
            this.pkIdEstadoPartidoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pkIdEstadoPartidoDataGridViewTextBoxColumn.Name = "pkIdEstadoPartidoDataGridViewTextBoxColumn";
            this.pkIdEstadoPartidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdEstadoPartidoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pkIdEstadoPartidoDataGridViewTextBoxColumn.Visible = false;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.estadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // vwpartidoBindingSource
            // 
            this.vwpartidoBindingSource.DataMember = "vwpartido";
            this.vwpartidoBindingSource.DataSource = this.vwPartido;
            // 
            // vwPartido
            // 
            this.vwPartido.DataSetName = "vwPartido";
            this.vwPartido.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(627, 36);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(210, 36);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "   E L I M I N A R";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminarPartido_Click);
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
            this.btnActualizar.Location = new System.Drawing.Point(392, 36);
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
            this.panelBuscarCol.Location = new System.Drawing.Point(69, 36);
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
            "nombre",
            "anotaciones",
            "deporte",
            "rol",
            "equipo"});
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
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtFiltrar);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(69, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 36);
            this.panel2.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
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
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(627, 85);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnModificar.Size = new System.Drawing.Size(210, 36);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "    M O D I F I C A R";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnAgregarPartido
            // 
            this.btnAgregarPartido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarPartido.BackColor = System.Drawing.Color.White;
            this.btnAgregarPartido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPartido.FlatAppearance.BorderSize = 0;
            this.btnAgregarPartido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPartido.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPartido.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarPartido.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarPartido.Image")));
            this.btnAgregarPartido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPartido.Location = new System.Drawing.Point(392, 85);
            this.btnAgregarPartido.Name = "btnAgregarPartido";
            this.btnAgregarPartido.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAgregarPartido.Size = new System.Drawing.Size(210, 36);
            this.btnAgregarPartido.TabIndex = 27;
            this.btnAgregarPartido.Text = "     A G R E G A R";
            this.btnAgregarPartido.UseVisualStyleBackColor = false;
            // 
            // vwpartidoTableAdapter
            // 
            this.vwpartidoTableAdapter.ClearBeforeFill = true;
            // 
            // formResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 595);
            this.Controls.Add(this.parrotGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formResultado";
            this.Text = "formJugadorPlantilla1";
            this.Load += new System.EventHandler(this.formResultado_Load);
            this.parrotGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPartidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwpartidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPartido)).EndInit();
            this.panelBuscarCol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private System.Windows.Forms.Button btnAgregarPartido;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBuscarCol;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdEstadoDataGridViewTextBoxColumn;
        private Zuby.ADGV.AdvancedDataGridView tablaPartidos;
        private vwPartido vwPartido;
        private System.Windows.Forms.BindingSource vwpartidoBindingSource;
        private Datos.vwPartidoTableAdapters.vwpartidoTableAdapter vwpartidoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdPartidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipo2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anotacionesEquipo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anotacionesEquipo2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdCampeonatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campeonatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdEstadoPartidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}