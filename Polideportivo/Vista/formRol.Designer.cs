
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRol));
            this.tablaRol = new Zuby.ADGV.AdvancedDataGridView();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.btnEliminarRol = new System.Windows.Forms.Button();
            this.btnActualizarRol = new System.Windows.Forms.Button();
            this.panelBuscarCol = new System.Windows.Forms.Panel();
            this.cboBuscarRol = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFiltrarRol = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnModificarRol = new System.Windows.Forms.Button();
            this.btnAgregarRol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRol)).BeginInit();
            this.parrotGradientPanel1.SuspendLayout();
            this.panelBuscarCol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaRol
            // 
            this.tablaRol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaRol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaRol.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaRol.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaRol.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaRol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.tablaRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaRol.DefaultCellStyle = dataGridViewCellStyle10;
            this.tablaRol.FilterAndSortEnabled = true;
            this.tablaRol.Location = new System.Drawing.Point(85, 143);
            this.tablaRol.Name = "tablaRol";
            this.tablaRol.ReadOnly = true;
            this.tablaRol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tablaRol.RowHeadersVisible = false;
            this.tablaRol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaRol.Size = new System.Drawing.Size(400, 407);
            this.tablaRol.TabIndex = 5;
            this.tablaRol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaRol_CellClick);
            this.tablaRol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaRol_CellContentClick);
            this.tablaRol.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.tablaRol_DataError);
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.MidnightBlue;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Controls.Add(this.lblNombre);
            this.parrotGradientPanel1.Controls.Add(this.txtNombreRol);
            this.parrotGradientPanel1.Controls.Add(this.btnEliminarRol);
            this.parrotGradientPanel1.Controls.Add(this.btnActualizarRol);
            this.parrotGradientPanel1.Controls.Add(this.panelBuscarCol);
            this.parrotGradientPanel1.Controls.Add(this.panel2);
            this.parrotGradientPanel1.Controls.Add(this.btnModificarRol);
            this.parrotGradientPanel1.Controls.Add(this.btnAgregarRol);
            this.parrotGradientPanel1.Controls.Add(this.tablaRol);
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
            // txtNombreRol
            // 
            this.txtNombreRol.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRol.Location = new System.Drawing.Point(571, 113);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(226, 27);
            this.txtNombreRol.TabIndex = 34;
            this.txtNombreRol.TextChanged += new System.EventHandler(this.txtNombreRol_TextChanged);
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarRol.BackColor = System.Drawing.Color.White;
            this.btnEliminarRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarRol.FlatAppearance.BorderSize = 0;
            this.btnEliminarRol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarRol.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRol.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarRol.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarRol.Image")));
            this.btnEliminarRol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarRol.Location = new System.Drawing.Point(571, 357);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnEliminarRol.Size = new System.Drawing.Size(226, 58);
            this.btnEliminarRol.TabIndex = 33;
            this.btnEliminarRol.Text = "   E L I M I N A R";
            this.btnEliminarRol.UseVisualStyleBackColor = false;
            this.btnEliminarRol.Click += new System.EventHandler(this.btnElinimarRol_Click);
            // 
            // btnActualizarRol
            // 
            this.btnActualizarRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarRol.BackColor = System.Drawing.Color.White;
            this.btnActualizarRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarRol.FlatAppearance.BorderSize = 0;
            this.btnActualizarRol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnActualizarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarRol.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarRol.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarRol.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarRol.Image")));
            this.btnActualizarRol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarRol.Location = new System.Drawing.Point(571, 441);
            this.btnActualizarRol.Name = "btnActualizarRol";
            this.btnActualizarRol.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnActualizarRol.Size = new System.Drawing.Size(226, 58);
            this.btnActualizarRol.TabIndex = 32;
            this.btnActualizarRol.Text = "      A C T U A L I Z A R";
            this.btnActualizarRol.UseVisualStyleBackColor = false;
            this.btnActualizarRol.Click += new System.EventHandler(this.btnActualizarRol_Click);
            // 
            // panelBuscarCol
            // 
            this.panelBuscarCol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBuscarCol.BackColor = System.Drawing.Color.White;
            this.panelBuscarCol.Controls.Add(this.cboBuscarRol);
            this.panelBuscarCol.Controls.Add(this.pictureBox2);
            this.panelBuscarCol.Location = new System.Drawing.Point(85, 40);
            this.panelBuscarCol.Name = "panelBuscarCol";
            this.panelBuscarCol.Size = new System.Drawing.Size(400, 36);
            this.panelBuscarCol.TabIndex = 31;
            // 
            // cboBuscarRol
            // 
            this.cboBuscarRol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBuscarRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBuscarRol.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuscarRol.FormattingEnabled = true;
            this.cboBuscarRol.Items.AddRange(new object[] {
            "nombre",
            "anotaciones",
            "deporte",
            "rol",
            "equipo"});
            this.cboBuscarRol.Location = new System.Drawing.Point(36, 6);
            this.cboBuscarRol.Name = "cboBuscarRol";
            this.cboBuscarRol.Size = new System.Drawing.Size(364, 26);
            this.cboBuscarRol.TabIndex = 32;
            this.cboBuscarRol.SelectedIndexChanged += new System.EventHandler(this.cboBuscar_SelectedIndexChanged);
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
            this.panel2.Controls.Add(this.txtFiltrarRol);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(85, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 36);
            this.panel2.TabIndex = 30;
            // 
            // txtFiltrarRol
            // 
            this.txtFiltrarRol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrarRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFiltrarRol.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarRol.Location = new System.Drawing.Point(37, 9);
            this.txtFiltrarRol.Name = "txtFiltrarRol";
            this.txtFiltrarRol.Size = new System.Drawing.Size(353, 20);
            this.txtFiltrarRol.TabIndex = 1;
            this.txtFiltrarRol.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
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
            // btnModificarRol
            // 
            this.btnModificarRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarRol.BackColor = System.Drawing.Color.White;
            this.btnModificarRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarRol.FlatAppearance.BorderSize = 0;
            this.btnModificarRol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModificarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarRol.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarRol.ForeColor = System.Drawing.Color.Black;
            this.btnModificarRol.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarRol.Image")));
            this.btnModificarRol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarRol.Location = new System.Drawing.Point(571, 271);
            this.btnModificarRol.Name = "btnModificarRol";
            this.btnModificarRol.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnModificarRol.Size = new System.Drawing.Size(226, 58);
            this.btnModificarRol.TabIndex = 28;
            this.btnModificarRol.Text = "    M O D I F I C A R";
            this.btnModificarRol.UseVisualStyleBackColor = false;
            this.btnModificarRol.Click += new System.EventHandler(this.btnModificarRol_Click);
            // 
            // btnAgregarRol
            // 
            this.btnAgregarRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarRol.BackColor = System.Drawing.Color.White;
            this.btnAgregarRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarRol.FlatAppearance.BorderSize = 0;
            this.btnAgregarRol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRol.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRol.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarRol.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarRol.Image")));
            this.btnAgregarRol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRol.Location = new System.Drawing.Point(571, 185);
            this.btnAgregarRol.Name = "btnAgregarRol";
            this.btnAgregarRol.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAgregarRol.Size = new System.Drawing.Size(226, 58);
            this.btnAgregarRol.TabIndex = 27;
            this.btnAgregarRol.Text = "     A G R E G A R";
            this.btnAgregarRol.UseVisualStyleBackColor = false;
            this.btnAgregarRol.Click += new System.EventHandler(this.btnAgregarRol_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.tablaRol)).EndInit();
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
        private Zuby.ADGV.AdvancedDataGridView tablaRol;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private System.Windows.Forms.Button btnAgregarRol;
        private System.Windows.Forms.Button btnModificarRol;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFiltrarRol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnActualizarRol;
        private System.Windows.Forms.Button btnEliminarRol;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panelBuscarCol;
        private System.Windows.Forms.ComboBox cboBuscarRol;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}