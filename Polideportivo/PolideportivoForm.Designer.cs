namespace Polideportivo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuLateralWrapPanel = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.ContenidoPanel = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.MenuSuperiorPanel = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Polideportivo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.MenuSuperiorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuLateralWrapPanel
            // 
            this.MenuLateralWrapPanel.BottomLeft = System.Drawing.Color.Black;
            this.MenuLateralWrapPanel.BottomRight = System.Drawing.Color.Fuchsia;
            this.MenuLateralWrapPanel.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.MenuLateralWrapPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuLateralWrapPanel.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.MenuLateralWrapPanel.Location = new System.Drawing.Point(0, 77);
            this.MenuLateralWrapPanel.Name = "MenuLateralWrapPanel";
            this.MenuLateralWrapPanel.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.MenuLateralWrapPanel.PrimerColor = System.Drawing.Color.White;
            this.MenuLateralWrapPanel.Size = new System.Drawing.Size(329, 823);
            this.MenuLateralWrapPanel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.MenuLateralWrapPanel.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.MenuLateralWrapPanel.TabIndex = 2;
            this.MenuLateralWrapPanel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.MenuLateralWrapPanel.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.MenuLateralWrapPanel.TopRight = System.Drawing.Color.Fuchsia;
            this.MenuLateralWrapPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuLateralWrapPanel_Paint);
            // 
            // ContenidoPanel
            // 
            this.ContenidoPanel.BottomLeft = System.Drawing.Color.Black;
            this.ContenidoPanel.BottomRight = System.Drawing.Color.Fuchsia;
            this.ContenidoPanel.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.ContenidoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenidoPanel.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.ContenidoPanel.Location = new System.Drawing.Point(329, 77);
            this.ContenidoPanel.Name = "ContenidoPanel";
            this.ContenidoPanel.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.ContenidoPanel.PrimerColor = System.Drawing.Color.White;
            this.ContenidoPanel.Size = new System.Drawing.Size(1071, 823);
            this.ContenidoPanel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.ContenidoPanel.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.ContenidoPanel.TabIndex = 2;
            this.ContenidoPanel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ContenidoPanel.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.ContenidoPanel.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // MenuSuperiorPanel
            // 
            this.MenuSuperiorPanel.BottomLeft = System.Drawing.Color.Black;
            this.MenuSuperiorPanel.BottomRight = System.Drawing.Color.Fuchsia;
            this.MenuSuperiorPanel.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.MenuSuperiorPanel.Controls.Add(this.Salir);
            this.MenuSuperiorPanel.Controls.Add(this.Restaurar);
            this.MenuSuperiorPanel.Controls.Add(this.Minimizar);
            this.MenuSuperiorPanel.Controls.Add(this.Maximizar);
            this.MenuSuperiorPanel.Controls.Add(this.Polideportivo);
            this.MenuSuperiorPanel.Controls.Add(this.pictureBox1);
            this.MenuSuperiorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuSuperiorPanel.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.MenuSuperiorPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuSuperiorPanel.Name = "MenuSuperiorPanel";
            this.MenuSuperiorPanel.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.MenuSuperiorPanel.PrimerColor = System.Drawing.Color.White;
            this.MenuSuperiorPanel.Size = new System.Drawing.Size(1400, 77);
            this.MenuSuperiorPanel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.MenuSuperiorPanel.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.MenuSuperiorPanel.TabIndex = 1;
            this.MenuSuperiorPanel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.MenuSuperiorPanel.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.MenuSuperiorPanel.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // Restaurar
            // 
            this.Restaurar.BackColor = System.Drawing.Color.Transparent;
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1304, 23);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(32, 32);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 4;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1266, 23);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(32, 32);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 1;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.BackColor = System.Drawing.Color.Transparent;
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(1304, 23);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(32, 32);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 3;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Polideportivo
            // 
            this.Polideportivo.AutoSize = true;
            this.Polideportivo.BackColor = System.Drawing.Color.Transparent;
            this.Polideportivo.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Polideportivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Polideportivo.Location = new System.Drawing.Point(97, 30);
            this.Polideportivo.Name = "Polideportivo";
            this.Polideportivo.Size = new System.Drawing.Size(232, 25);
            this.Polideportivo.TabIndex = 1;
            this.Polideportivo.Text = "P O L I D E P O R T I V O";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Transparent;
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1342, 23);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(32, 32);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 5;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.ContenidoPanel);
            this.Controls.Add(this.MenuLateralWrapPanel);
            this.Controls.Add(this.MenuSuperiorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MenuSuperiorPanel.ResumeLayout(false);
            this.MenuSuperiorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel MenuLateralWrapPanel;
        private ReaLTaiizor.Controls.ParrotGradientPanel ContenidoPanel;
        private ReaLTaiizor.Controls.ParrotGradientPanel MenuSuperiorPanel;
        private System.Windows.Forms.Label Polideportivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Salir;
    }
}

