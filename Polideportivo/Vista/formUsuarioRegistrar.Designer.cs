
namespace Vista
{
    partial class formUsuarioRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUsuarioRegistrar));
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAnotaciones = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContraseñaUsuario = new System.Windows.Forms.TextBox();
            this.parrotGradientPanel2 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.txtTelefonoUsuario = new System.Windows.Forms.TextBox();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.cboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.parrotGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(52, 74);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(121, 27);
            this.txtNombreUsuario.TabIndex = 1;
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.BackColor = System.Drawing.Color.Transparent;
            this.lblEquipo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo.ForeColor = System.Drawing.Color.White;
            this.lblEquipo.Location = new System.Drawing.Point(222, 107);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(40, 18);
            this.lblEquipo.TabIndex = 4;
            this.lblEquipo.Text = "TIPO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(52, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblAnotaciones
            // 
            this.lblAnotaciones.AutoSize = true;
            this.lblAnotaciones.BackColor = System.Drawing.Color.Transparent;
            this.lblAnotaciones.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnotaciones.ForeColor = System.Drawing.Color.White;
            this.lblAnotaciones.Location = new System.Drawing.Point(52, 107);
            this.lblAnotaciones.Name = "lblAnotaciones";
            this.lblAnotaciones.Size = new System.Drawing.Size(106, 18);
            this.lblAnotaciones.TabIndex = 6;
            this.lblAnotaciones.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(222, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "TELEFONO";
            // 
            // txtContraseñaUsuario
            // 
            this.txtContraseñaUsuario.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaUsuario.Location = new System.Drawing.Point(52, 127);
            this.txtContraseñaUsuario.Name = "txtContraseñaUsuario";
            this.txtContraseñaUsuario.Size = new System.Drawing.Size(121, 27);
            this.txtContraseñaUsuario.TabIndex = 10;
            // 
            // parrotGradientPanel2
            // 
            this.parrotGradientPanel2.BottomLeft = System.Drawing.Color.MidnightBlue;
            this.parrotGradientPanel2.BottomRight = System.Drawing.Color.MidnightBlue;
            this.parrotGradientPanel2.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            this.parrotGradientPanel2.Controls.Add(this.txtTelefonoUsuario);
            this.parrotGradientPanel2.Controls.Add(this.btnRegistrarUsuario);
            this.parrotGradientPanel2.Controls.Add(this.label1);
            this.parrotGradientPanel2.Controls.Add(this.txtNombreUsuario);
            this.parrotGradientPanel2.Controls.Add(this.cboTipoUsuario);
            this.parrotGradientPanel2.Controls.Add(this.lblNombre);
            this.parrotGradientPanel2.Controls.Add(this.lblEquipo);
            this.parrotGradientPanel2.Controls.Add(this.txtContraseñaUsuario);
            this.parrotGradientPanel2.Controls.Add(this.lblAnotaciones);
            this.parrotGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parrotGradientPanel2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.Low;
            this.parrotGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.parrotGradientPanel2.Name = "parrotGradientPanel2";
            this.parrotGradientPanel2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            this.parrotGradientPanel2.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel2.Size = new System.Drawing.Size(413, 297);
            this.parrotGradientPanel2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel2.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotGradientPanel2.TabIndex = 10;
            this.parrotGradientPanel2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel2.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.parrotGradientPanel2.TopRight = System.Drawing.Color.CornflowerBlue;
            // 
            // txtTelefonoUsuario
            // 
            this.txtTelefonoUsuario.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoUsuario.Location = new System.Drawing.Point(222, 74);
            this.txtTelefonoUsuario.Name = "txtTelefonoUsuario";
            this.txtTelefonoUsuario.Size = new System.Drawing.Size(121, 27);
            this.txtTelefonoUsuario.TabIndex = 30;
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
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(53, 196);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(291, 36);
            this.btnRegistrarUsuario.TabIndex = 29;
            this.btnRegistrarUsuario.Text = "     A G R E G A R";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = false;
            // 
            // cboTipoUsuario
            // 
            this.cboTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoUsuario.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoUsuario.FormattingEnabled = true;
            this.cboTipoUsuario.Location = new System.Drawing.Point(222, 127);
            this.cboTipoUsuario.Name = "cboTipoUsuario";
            this.cboTipoUsuario.Size = new System.Drawing.Size(121, 27);
            this.cboTipoUsuario.TabIndex = 16;
            // 
            // formUsuarioRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 297);
            this.Controls.Add(this.parrotGradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formUsuarioRegistrar";
            this.Text = "formUsuarioEventos";
            this.parrotGradientPanel2.ResumeLayout(false);
            this.parrotGradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAnotaciones;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel2;
        public System.Windows.Forms.TextBox txtNombreUsuario;
        public System.Windows.Forms.TextBox txtContraseñaUsuario;
        public System.Windows.Forms.Button btnRegistrarUsuario;
        public System.Windows.Forms.TextBox txtTelefonoUsuario;
        public System.Windows.Forms.ComboBox cboTipoUsuario;
    }
}