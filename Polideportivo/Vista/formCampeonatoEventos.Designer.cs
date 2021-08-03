
namespace Polideportivo.Vista
{
    partial class formCampeonatoEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCampeonatoEventos));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboDeporte = new System.Windows.Forms.ComboBox();
            this.parrotGradientPanel2 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dateFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dateFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnModificarCampeonato = new System.Windows.Forms.Button();
            this.btnAgregarCampeonato = new System.Windows.Forms.Button();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblJugadorEvento = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.parrotGradientPanel2.SuspendLayout();
            this.parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(48, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(48, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.Color.Transparent;
            this.lblRol.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(380, 35);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(40, 18);
            this.lblRol.TabIndex = 9;
            this.lblRol.Text = "TIPO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(213, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "DEPORTE";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(380, 55);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 27);
            this.cboTipo.TabIndex = 17;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // cboDeporte
            // 
            this.cboDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDeporte.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeporte.FormattingEnabled = true;
            this.cboDeporte.Location = new System.Drawing.Point(214, 55);
            this.cboDeporte.Name = "cboDeporte";
            this.cboDeporte.Size = new System.Drawing.Size(121, 27);
            this.cboDeporte.TabIndex = 18;
            this.cboDeporte.SelectedIndexChanged += new System.EventHandler(this.cboDeporte_SelectedIndexChanged);
            // 
            // parrotGradientPanel2
            // 
            this.parrotGradientPanel2.BottomLeft = System.Drawing.Color.MidnightBlue;
            this.parrotGradientPanel2.BottomRight = System.Drawing.Color.MidnightBlue;
            this.parrotGradientPanel2.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel2.Controls.Add(this.label2);
            this.parrotGradientPanel2.Controls.Add(this.lblFechaInicio);
            this.parrotGradientPanel2.Controls.Add(this.dateFechaFinal);
            this.parrotGradientPanel2.Controls.Add(this.dateFechaInicio);
            this.parrotGradientPanel2.Controls.Add(this.btnModificarCampeonato);
            this.parrotGradientPanel2.Controls.Add(this.btnAgregarCampeonato);
            this.parrotGradientPanel2.Controls.Add(this.cboDeporte);
            this.parrotGradientPanel2.Controls.Add(this.cboTipo);
            this.parrotGradientPanel2.Controls.Add(this.label1);
            this.parrotGradientPanel2.Controls.Add(this.lblRol);
            this.parrotGradientPanel2.Controls.Add(this.txtNombre);
            this.parrotGradientPanel2.Controls.Add(this.lblNombre);
            this.parrotGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parrotGradientPanel2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel2.Location = new System.Drawing.Point(0, 62);
            this.parrotGradientPanel2.Name = "parrotGradientPanel2";
            this.parrotGradientPanel2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel2.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel2.Size = new System.Drawing.Size(549, 320);
            this.parrotGradientPanel2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel2.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotGradientPanel2.TabIndex = 10;
            this.parrotGradientPanel2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel2.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.parrotGradientPanel2.TopRight = System.Drawing.Color.CornflowerBlue;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(119, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "FIN";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaInicio.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.Color.White;
            this.lblFechaInicio.Location = new System.Drawing.Point(118, 102);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(51, 18);
            this.lblFechaInicio.TabIndex = 33;
            this.lblFechaInicio.Text = "INICIO";
            // 
            // dateFechaFinal
            // 
            this.dateFechaFinal.CalendarFont = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaFinal.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaFinal.Location = new System.Drawing.Point(121, 188);
            this.dateFechaFinal.Name = "dateFechaFinal";
            this.dateFechaFinal.Size = new System.Drawing.Size(294, 27);
            this.dateFechaFinal.TabIndex = 32;
            this.dateFechaFinal.Value = new System.DateTime(2021, 8, 3, 19, 48, 0, 0);
            // 
            // dateFechaInicio
            // 
            this.dateFechaInicio.CalendarFont = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaInicio.CustomFormat = "dd - yyyy";
            this.dateFechaInicio.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaInicio.Location = new System.Drawing.Point(121, 123);
            this.dateFechaInicio.Name = "dateFechaInicio";
            this.dateFechaInicio.Size = new System.Drawing.Size(294, 27);
            this.dateFechaInicio.TabIndex = 31;
            this.dateFechaInicio.Value = new System.DateTime(2021, 8, 3, 19, 48, 0, 0);
            // 
            // btnModificarCampeonato
            // 
            this.btnModificarCampeonato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarCampeonato.BackColor = System.Drawing.Color.White;
            this.btnModificarCampeonato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarCampeonato.FlatAppearance.BorderSize = 0;
            this.btnModificarCampeonato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCampeonato.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCampeonato.ForeColor = System.Drawing.Color.Black;
            this.btnModificarCampeonato.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarCampeonato.Image")));
            this.btnModificarCampeonato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarCampeonato.Location = new System.Drawing.Point(122, 251);
            this.btnModificarCampeonato.Name = "btnModificarCampeonato";
            this.btnModificarCampeonato.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnModificarCampeonato.Size = new System.Drawing.Size(294, 36);
            this.btnModificarCampeonato.TabIndex = 30;
            this.btnModificarCampeonato.Text = "    M O D I F I C A R";
            this.btnModificarCampeonato.UseVisualStyleBackColor = false;
            this.btnModificarCampeonato.Click += new System.EventHandler(this.btnModificarCampeonato_Click);
            // 
            // btnAgregarCampeonato
            // 
            this.btnAgregarCampeonato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCampeonato.BackColor = System.Drawing.Color.White;
            this.btnAgregarCampeonato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCampeonato.FlatAppearance.BorderSize = 0;
            this.btnAgregarCampeonato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCampeonato.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCampeonato.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCampeonato.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCampeonato.Image")));
            this.btnAgregarCampeonato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCampeonato.Location = new System.Drawing.Point(122, 248);
            this.btnAgregarCampeonato.Name = "btnAgregarCampeonato";
            this.btnAgregarCampeonato.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAgregarCampeonato.Size = new System.Drawing.Size(294, 36);
            this.btnAgregarCampeonato.TabIndex = 29;
            this.btnAgregarCampeonato.Text = "     A G R E G A R";
            this.btnAgregarCampeonato.UseVisualStyleBackColor = false;
            this.btnAgregarCampeonato.Click += new System.EventHandler(this.btnAgregarCampeonato_Click);
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.MidnightBlue;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.DodgerBlue;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Controls.Add(this.pictureBox1);
            this.parrotGradientPanel1.Controls.Add(this.lblJugadorEvento);
            this.parrotGradientPanel1.Controls.Add(this.btnSalir);
            this.parrotGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel1.Size = new System.Drawing.Size(549, 62);
            this.parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotGradientPanel1.TabIndex = 11;
            this.parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.DarkBlue;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lblJugadorEvento
            // 
            this.lblJugadorEvento.AutoSize = true;
            this.lblJugadorEvento.BackColor = System.Drawing.Color.Transparent;
            this.lblJugadorEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugadorEvento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblJugadorEvento.Location = new System.Drawing.Point(172, 20);
            this.lblJugadorEvento.Name = "lblJugadorEvento";
            this.lblJugadorEvento.Size = new System.Drawing.Size(239, 25);
            this.lblJugadorEvento.TabIndex = 23;
            this.lblJugadorEvento.Text = "AGREGAR JUGADOR";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(500, 16);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(32, 32);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // formCampeonatoEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 382);
            this.Controls.Add(this.parrotGradientPanel2);
            this.Controls.Add(this.parrotGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCampeonatoEventos";
            this.Text = "formCampeonatoEventos";
            this.parrotGradientPanel2.ResumeLayout(false);
            this.parrotGradientPanel2.PerformLayout();
            this.parrotGradientPanel1.ResumeLayout(false);
            this.parrotGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboDeporte;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel2;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Label lblJugadorEvento;
        private System.Windows.Forms.Button btnModificarCampeonato;
        private System.Windows.Forms.Button btnAgregarCampeonato;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateFechaInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dateFechaFinal;
    }
}