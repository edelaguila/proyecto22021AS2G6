
namespace Polideportivo.Vista
{
    partial class formRol
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRol));
            this.tablaDeportes = new Zuby.ADGV.AdvancedDataGridView();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreDeporte = new System.Windows.Forms.TextBox();
            this.btnEliminarDeporte = new System.Windows.Forms.Button();
            this.btnActualizarDeporte = new System.Windows.Forms.Button();
            this.panelBuscarCol = new System.Windows.Forms.Panel();
            this.cboBuscarDeporte = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFiltrarDeporte = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnModificarDeporte = new System.Windows.Forms.Button();
            this.btnAgregarDeporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeportes)).BeginInit();
            this.parrotGradientPanel1.SuspendLayout();
            this.panelBuscarCol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaDeportes
            // 
            this.tablaDeportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaDeportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaDeportes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaDeportes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaDeportes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaDeportes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDeportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaDeportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaDeportes.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaDeportes.FilterAndSortEnabled = true;
            this.tablaDeportes.Location = new System.Drawing.Point(85, 143);
            this.tablaDeportes.Name = "tablaDeportes";
            this.tablaDeportes.ReadOnly = true;
            this.tablaDeportes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tablaDeportes.RowHeadersVisible = false;
            this.tablaDeportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDeportes.Size = new System.Drawing.Size(400, 407);
            this.tablaDeportes.TabIndex = 5;
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.MidnightBlue;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Controls.Add(this.lblNombre);
            this.parrotGradientPanel1.Controls.Add(this.txtNombreDeporte);
            this.parrotGradientPanel1.Controls.Add(this.btnEliminarDeporte);
            this.parrotGradientPanel1.Controls.Add(this.btnActualizarDeporte);
            this.parrotGradientPanel1.Controls.Add(this.panelBuscarCol);
            this.parrotGradientPanel1.Controls.Add(this.panel2);
            this.parrotGradientPanel1.Controls.Add(this.btnModificarDeporte);
            this.parrotGradientPanel1.Controls.Add(this.btnAgregarDeporte);
            this.parrotGradientPanel1.Controls.Add(this.tablaDeportes);
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
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(568, 92);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 18);
            this.lblNombre.TabIndex = 35;
            this.lblNombre.Text = "NOMBRE";
            // 
            // txtNombreDeporte
            // 
            this.txtNombreDeporte.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDeporte.Location = new System.Drawing.Point(571, 113);
            this.txtNombreDeporte.Name = "txtNombreDeporte";
            this.txtNombreDeporte.Size = new System.Drawing.Size(226, 27);
            this.txtNombreDeporte.TabIndex = 34;
            // 
            // btnEliminarDeporte
            // 
            this.btnEliminarDeporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarDeporte.BackColor = System.Drawing.Color.White;
            this.btnEliminarDeporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarDeporte.FlatAppearance.BorderSize = 0;
            this.btnEliminarDeporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminarDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDeporte.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDeporte.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarDeporte.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarDeporte.Image")));
            this.btnEliminarDeporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarDeporte.Location = new System.Drawing.Point(571, 357);
            this.btnEliminarDeporte.Name = "btnEliminarDeporte";
            this.btnEliminarDeporte.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnEliminarDeporte.Size = new System.Drawing.Size(226, 58);
            this.btnEliminarDeporte.TabIndex = 33;
            this.btnEliminarDeporte.Text = "   E L I M I N A R";
            this.btnEliminarDeporte.UseVisualStyleBackColor = false;
            this.btnEliminarDeporte.Click += new System.EventHandler(this.btnEliminarDeporte_Click);
            // 
            // btnActualizarDeporte
            // 
            this.btnActualizarDeporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarDeporte.BackColor = System.Drawing.Color.White;
            this.btnActualizarDeporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarDeporte.FlatAppearance.BorderSize = 0;
            this.btnActualizarDeporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnActualizarDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarDeporte.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarDeporte.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarDeporte.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarDeporte.Image")));
            this.btnActualizarDeporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarDeporte.Location = new System.Drawing.Point(571, 441);
            this.btnActualizarDeporte.Name = "btnActualizarDeporte";
            this.btnActualizarDeporte.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnActualizarDeporte.Size = new System.Drawing.Size(226, 58);
            this.btnActualizarDeporte.TabIndex = 32;
            this.btnActualizarDeporte.Text = "      A C T U A L I Z A R";
            this.btnActualizarDeporte.UseVisualStyleBackColor = false;
            this.btnActualizarDeporte.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panelBuscarCol
            // 
            this.panelBuscarCol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBuscarCol.BackColor = System.Drawing.Color.White;
            this.panelBuscarCol.Controls.Add(this.cboBuscarDeporte);
            this.panelBuscarCol.Controls.Add(this.pictureBox2);
            this.panelBuscarCol.Location = new System.Drawing.Point(85, 40);
            this.panelBuscarCol.Name = "panelBuscarCol";
            this.panelBuscarCol.Size = new System.Drawing.Size(400, 36);
            this.panelBuscarCol.TabIndex = 31;
            // 
            // cboBuscarDeporte
            // 
            this.cboBuscarDeporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBuscarDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBuscarDeporte.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuscarDeporte.FormattingEnabled = true;
            this.cboBuscarDeporte.Items.AddRange(new object[] {
            "nombre",
            "anotaciones",
            "deporte",
            "rol",
            "equipo"});
            this.cboBuscarDeporte.Location = new System.Drawing.Point(36, 6);
            this.cboBuscarDeporte.Name = "cboBuscarDeporte";
            this.cboBuscarDeporte.Size = new System.Drawing.Size(364, 26);
            this.cboBuscarDeporte.TabIndex = 32;
            this.cboBuscarDeporte.SelectedIndexChanged += new System.EventHandler(this.cboBuscar_SelectedIndexChanged);
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
            this.panel2.Controls.Add(this.txtFiltrarDeporte);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(85, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 36);
            this.panel2.TabIndex = 30;
            // 
            // txtFiltrarDeporte
            // 
            this.txtFiltrarDeporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrarDeporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFiltrarDeporte.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarDeporte.Location = new System.Drawing.Point(37, 9);
            this.txtFiltrarDeporte.Name = "txtFiltrarDeporte";
            this.txtFiltrarDeporte.Size = new System.Drawing.Size(353, 20);
            this.txtFiltrarDeporte.TabIndex = 1;
            this.txtFiltrarDeporte.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
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
            // btnModificarDeporte
            // 
            this.btnModificarDeporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarDeporte.BackColor = System.Drawing.Color.White;
            this.btnModificarDeporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarDeporte.FlatAppearance.BorderSize = 0;
            this.btnModificarDeporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModificarDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarDeporte.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDeporte.ForeColor = System.Drawing.Color.Black;
            this.btnModificarDeporte.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarDeporte.Image")));
            this.btnModificarDeporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarDeporte.Location = new System.Drawing.Point(571, 271);
            this.btnModificarDeporte.Name = "btnModificarDeporte";
            this.btnModificarDeporte.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnModificarDeporte.Size = new System.Drawing.Size(226, 58);
            this.btnModificarDeporte.TabIndex = 28;
            this.btnModificarDeporte.Text = "    M O D I F I C A R";
            this.btnModificarDeporte.UseVisualStyleBackColor = false;
            this.btnModificarDeporte.Click += new System.EventHandler(this.btnModificarDeporte_Click);
            // 
            // btnAgregarDeporte
            // 
            this.btnAgregarDeporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarDeporte.BackColor = System.Drawing.Color.White;
            this.btnAgregarDeporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarDeporte.FlatAppearance.BorderSize = 0;
            this.btnAgregarDeporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDeporte.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDeporte.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarDeporte.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarDeporte.Image")));
            this.btnAgregarDeporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDeporte.Location = new System.Drawing.Point(571, 185);
            this.btnAgregarDeporte.Name = "btnAgregarDeporte";
            this.btnAgregarDeporte.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAgregarDeporte.Size = new System.Drawing.Size(226, 58);
            this.btnAgregarDeporte.TabIndex = 27;
            this.btnAgregarDeporte.Text = "     A G R E G A R";
            this.btnAgregarDeporte.UseVisualStyleBackColor = false;
            this.btnAgregarDeporte.Click += new System.EventHandler(this.btnAgregarDeporte_Click);
            // 
            // formRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 595);
            this.Controls.Add(this.parrotGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRol";
            this.Text = "formRol";
            this.Load += new System.EventHandler(this.formDeporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeportes)).EndInit();
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
        private Zuby.ADGV.AdvancedDataGridView tablaDeportes;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private System.Windows.Forms.Button btnAgregarDeporte;
        private System.Windows.Forms.Button btnModificarDeporte;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFiltrarDeporte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnActualizarDeporte;
        private System.Windows.Forms.Button btnEliminarDeporte;
        private System.Windows.Forms.TextBox txtNombreDeporte;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panelBuscarCol;
        private System.Windows.Forms.ComboBox cboBuscarDeporte;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}