
namespace Vista
{
    partial class formUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUsuario));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Lbl = new System.Windows.Forms.Label();
            this.panelUsuario = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(206, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Lbl.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl.ForeColor = System.Drawing.Color.White;
            this.Lbl.Location = new System.Drawing.Point(202, 23);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(135, 18);
            this.Lbl.TabIndex = 0;
            this.Lbl.Text = "NOMBRE USUARIO";
            // 
            // panelUsuario
            // 
            this.panelUsuario.BottomLeft = System.Drawing.Color.MidnightBlue;
            this.panelUsuario.BottomRight = System.Drawing.Color.MidnightBlue;
            this.panelUsuario.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            this.panelUsuario.Controls.Add(this.btnRegistrarUsuario);
            this.panelUsuario.Controls.Add(this.pictureBox2);
            this.panelUsuario.Controls.Add(this.txtContraseña);
            this.panelUsuario.Controls.Add(this.label1);
            this.panelUsuario.Controls.Add(this.btnIngresar);
            this.panelUsuario.Controls.Add(this.txtNombre);
            this.panelUsuario.Controls.Add(this.Lbl);
            this.panelUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsuario.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.Low;
            this.panelUsuario.Location = new System.Drawing.Point(0, 62);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            this.panelUsuario.PrimerColor = System.Drawing.Color.White;
            this.panelUsuario.Size = new System.Drawing.Size(413, 297);
            this.panelUsuario.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.panelUsuario.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.panelUsuario.TabIndex = 10;
            this.panelUsuario.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.panelUsuario.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.panelUsuario.TopRight = System.Drawing.Color.CornflowerBlue;
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarUsuario.BackColor = System.Drawing.Color.White;
            this.btnRegistrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarUsuario.FlatAppearance.BorderSize = 0;
            this.btnRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarUsuario.Image")));
            this.btnRegistrarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(84, 225);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(243, 36);
            this.btnRegistrarUsuario.TabIndex = 33;
            this.btnRegistrarUsuario.Text = " CREAR NUEVO USUARIO";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(63, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(205, 110);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(132, 27);
            this.txtContraseña.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(202, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "CONTRASEÑA";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresar.BackColor = System.Drawing.Color.White;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.Black;
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(84, 174);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnIngresar.Size = new System.Drawing.Size(243, 36);
            this.btnIngresar.TabIndex = 29;
            this.btnIngresar.Text = "  INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.MidnightBlue;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.DodgerBlue;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            this.parrotGradientPanel1.Controls.Add(this.lblIniciarSesion);
            this.parrotGradientPanel1.Controls.Add(this.btnSalir);
            this.parrotGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.Low;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel1.Size = new System.Drawing.Size(413, 62);
            this.parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotGradientPanel1.TabIndex = 11;
            this.parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.DarkBlue;
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIniciarSesion.Location = new System.Drawing.Point(24, 16);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(184, 25);
            this.lblIniciarSesion.TabIndex = 23;
            this.lblIniciarSesion.Text = "INICIAR SESION";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(364, 16);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(32, 32);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.TabStop = false;
            // 
            // formUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 359);
            this.Controls.Add(this.panelUsuario);
            this.Controls.Add(this.parrotGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formUsuario";
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.parrotGradientPanel1.ResumeLayout(false);
            this.parrotGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.Label Lbl;
        public System.Windows.Forms.PictureBox btnSalir;
        public System.Windows.Forms.Label lblIniciarSesion;
        public System.Windows.Forms.Button btnIngresar;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox txtContraseña;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnRegistrarUsuario;
        public ReaLTaiizor.Controls.ParrotGradientPanel panelUsuario;
    }
}