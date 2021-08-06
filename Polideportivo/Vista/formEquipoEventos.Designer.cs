
namespace Vista
{
    partial class formEquipoEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEquipoEventos));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.parrotGradientPanel2 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.cboDeporte = new System.Windows.Forms.ComboBox();
            this.btnModificarEquipo = new System.Windows.Forms.Button();
            this.btnAgregarEquipo = new System.Windows.Forms.Button();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEquipoEvento = new System.Windows.Forms.Label();
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
            this.txtNombre.Location = new System.Drawing.Point(52, 98);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 27);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(52, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(125, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NOMBRE EQUIPO";
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.BackColor = System.Drawing.Color.Transparent;
            this.lblDeporte.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporte.ForeColor = System.Drawing.Color.White;
            this.lblDeporte.Location = new System.Drawing.Point(208, 78);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(72, 18);
            this.lblDeporte.TabIndex = 6;
            this.lblDeporte.Text = "DEPORTE";
            // 
            // parrotGradientPanel2
            // 
            this.parrotGradientPanel2.BottomLeft = System.Drawing.Color.MidnightBlue;
            this.parrotGradientPanel2.BottomRight = System.Drawing.Color.MidnightBlue;
            this.parrotGradientPanel2.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            this.parrotGradientPanel2.Controls.Add(this.cboDeporte);
            this.parrotGradientPanel2.Controls.Add(this.btnModificarEquipo);
            this.parrotGradientPanel2.Controls.Add(this.btnAgregarEquipo);
            this.parrotGradientPanel2.Controls.Add(this.txtNombre);
            this.parrotGradientPanel2.Controls.Add(this.lblNombre);
            this.parrotGradientPanel2.Controls.Add(this.lblDeporte);
            this.parrotGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parrotGradientPanel2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.Low;
            this.parrotGradientPanel2.Location = new System.Drawing.Point(0, 62);
            this.parrotGradientPanel2.Name = "parrotGradientPanel2";
            this.parrotGradientPanel2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            this.parrotGradientPanel2.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel2.Size = new System.Drawing.Size(401, 313);
            this.parrotGradientPanel2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel2.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotGradientPanel2.TabIndex = 10;
            this.parrotGradientPanel2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel2.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.parrotGradientPanel2.TopRight = System.Drawing.Color.CornflowerBlue;
            // 
            // cboDeporte
            // 
            this.cboDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDeporte.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeporte.FormattingEnabled = true;
            this.cboDeporte.Location = new System.Drawing.Point(211, 99);
            this.cboDeporte.Name = "cboDeporte";
            this.cboDeporte.Size = new System.Drawing.Size(121, 27);
            this.cboDeporte.TabIndex = 32;
            // 
            // btnModificarEquipo
            // 
            this.btnModificarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarEquipo.BackColor = System.Drawing.Color.White;
            this.btnModificarEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarEquipo.FlatAppearance.BorderSize = 0;
            this.btnModificarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEquipo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEquipo.ForeColor = System.Drawing.Color.Black;
            this.btnModificarEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarEquipo.Image")));
            this.btnModificarEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarEquipo.Location = new System.Drawing.Point(52, 199);
            this.btnModificarEquipo.Name = "btnModificarEquipo";
            this.btnModificarEquipo.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnModificarEquipo.Size = new System.Drawing.Size(291, 36);
            this.btnModificarEquipo.TabIndex = 30;
            this.btnModificarEquipo.Text = "    MODIFICAR";
            this.btnModificarEquipo.UseVisualStyleBackColor = false;
            this.btnModificarEquipo.Click += new System.EventHandler(this.btnModificarJugador_Click);
            // 
            // btnAgregarEquipo
            // 
            this.btnAgregarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarEquipo.BackColor = System.Drawing.Color.White;
            this.btnAgregarEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarEquipo.FlatAppearance.BorderSize = 0;
            this.btnAgregarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEquipo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEquipo.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEquipo.Image")));
            this.btnAgregarEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEquipo.Location = new System.Drawing.Point(52, 199);
            this.btnAgregarEquipo.Name = "btnAgregarEquipo";
            this.btnAgregarEquipo.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAgregarEquipo.Size = new System.Drawing.Size(291, 36);
            this.btnAgregarEquipo.TabIndex = 29;
            this.btnAgregarEquipo.Text = "     A G R E G A R";
            this.btnAgregarEquipo.UseVisualStyleBackColor = false;
            this.btnAgregarEquipo.Click += new System.EventHandler(this.btnAgregarJugador_Click);
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.MidnightBlue;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.DodgerBlue;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            this.parrotGradientPanel1.Controls.Add(this.pictureBox1);
            this.parrotGradientPanel1.Controls.Add(this.lblEquipoEvento);
            this.parrotGradientPanel1.Controls.Add(this.btnSalir);
            this.parrotGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.Low;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel1.Size = new System.Drawing.Size(401, 62);
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
            this.pictureBox1.Location = new System.Drawing.Point(22, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lblEquipoEvento
            // 
            this.lblEquipoEvento.AutoSize = true;
            this.lblEquipoEvento.BackColor = System.Drawing.Color.Transparent;
            this.lblEquipoEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipoEvento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEquipoEvento.Location = new System.Drawing.Point(79, 20);
            this.lblEquipoEvento.Name = "lblEquipoEvento";
            this.lblEquipoEvento.Size = new System.Drawing.Size(216, 25);
            this.lblEquipoEvento.TabIndex = 23;
            this.lblEquipoEvento.Text = "AGREGAR EQUIPO";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(352, 16);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(32, 32);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // formEquipoEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 375);
            this.Controls.Add(this.parrotGradientPanel2);
            this.Controls.Add(this.parrotGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formEquipoEventos";
            this.Text = "formEquipoEventos";
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
        private System.Windows.Forms.Label lblDeporte;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel2;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Label lblEquipoEvento;
        private System.Windows.Forms.Button btnModificarEquipo;
        private System.Windows.Forms.Button btnAgregarEquipo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboDeporte;
    }
}