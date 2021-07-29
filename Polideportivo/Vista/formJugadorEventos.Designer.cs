
namespace Polideportivo.Vista
{
    partial class formJugadorEventos
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblAnotaciones = new System.Windows.Forms.Label();
            this.btnAgregarJugador = new System.Windows.Forms.Button();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboRoles = new Polideportivo.cboRoles();
            this.cboEquipo = new System.Windows.Forms.ComboBox();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboEquipos = new Polideportivo.cboEquipos();
            this.txtAnotaciones = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.equipoTableAdapter = new Polideportivo.cboEquiposTableAdapters.equipoTableAdapter();
            this.rolTableAdapter = new Polideportivo.cboRolesTableAdapters.rolTableAdapter();
            this.btnModificar = new System.Windows.Forms.Button();
            this.parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(50, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(33, 132);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(43, 13);
            this.lblEquipo.TabIndex = 4;
            this.lblEquipo.Text = "Equipo:";
            // 
            // lblAnotaciones
            // 
            this.lblAnotaciones.AutoSize = true;
            this.lblAnotaciones.Location = new System.Drawing.Point(19, 82);
            this.lblAnotaciones.Name = "lblAnotaciones";
            this.lblAnotaciones.Size = new System.Drawing.Size(69, 13);
            this.lblAnotaciones.TabIndex = 6;
            this.lblAnotaciones.Text = "Anotaciones:";
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.Location = new System.Drawing.Point(150, 283);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarJugador.TabIndex = 8;
            this.btnAgregarJugador.Text = "Agregar";
            this.btnAgregarJugador.UseVisualStyleBackColor = true;
            this.btnAgregarJugador.Click += new System.EventHandler(this.btnAgregarJugador_Click);
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.Fuchsia;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Controls.Add(this.btnModificar);
            this.parrotGradientPanel1.Controls.Add(this.cboRol);
            this.parrotGradientPanel1.Controls.Add(this.cboEquipo);
            this.parrotGradientPanel1.Controls.Add(this.txtAnotaciones);
            this.parrotGradientPanel1.Controls.Add(this.lblRol);
            this.parrotGradientPanel1.Controls.Add(this.lblEquipo);
            this.parrotGradientPanel1.Controls.Add(this.lblAnotaciones);
            this.parrotGradientPanel1.Controls.Add(this.btnAgregarJugador);
            this.parrotGradientPanel1.Controls.Add(this.lblNombre);
            this.parrotGradientPanel1.Controls.Add(this.txtNombre);
            this.parrotGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel1.Size = new System.Drawing.Size(401, 359);
            this.parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotGradientPanel1.TabIndex = 9;
            this.parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
            this.parrotGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.parrotGradientPanel1_Paint);
            // 
            // cboRol
            // 
            this.cboRol.DataSource = this.rolBindingSource;
            this.cboRol.DisplayMember = "nombre";
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(138, 165);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(121, 21);
            this.cboRol.TabIndex = 12;
            this.cboRol.ValueMember = "pkId";
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "rol";
            this.rolBindingSource.DataSource = this.cboRoles;
            // 
            // cboRoles
            // 
            this.cboRoles.DataSetName = "cboRoles";
            this.cboRoles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboEquipo
            // 
            this.cboEquipo.DataSource = this.equipoBindingSource;
            this.cboEquipo.DisplayMember = "nombre";
            this.cboEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEquipo.FormattingEnabled = true;
            this.cboEquipo.Location = new System.Drawing.Point(138, 124);
            this.cboEquipo.Name = "cboEquipo";
            this.cboEquipo.Size = new System.Drawing.Size(121, 21);
            this.cboEquipo.TabIndex = 11;
            this.cboEquipo.ValueMember = "pkId";
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataMember = "equipo";
            this.equipoBindingSource.DataSource = this.cboEquipos;
            // 
            // cboEquipos
            // 
            this.cboEquipos.DataSetName = "cboEquipos";
            this.cboEquipos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtAnotaciones
            // 
            this.txtAnotaciones.Location = new System.Drawing.Point(138, 82);
            this.txtAnotaciones.Name = "txtAnotaciones";
            this.txtAnotaciones.Size = new System.Drawing.Size(121, 20);
            this.txtAnotaciones.TabIndex = 10;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(50, 173);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(26, 13);
            this.lblRol.TabIndex = 9;
            this.lblRol.Text = "Rol:";
            // 
            // equipoTableAdapter
            // 
            this.equipoTableAdapter.ClearBeforeFill = true;
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(150, 237);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // formJugadorEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 359);
            this.Controls.Add(this.parrotGradientPanel1);
            this.Name = "formJugadorEventos";
            this.Text = "formJugadorEventos";
            this.Load += new System.EventHandler(this.formJugadorEventos_Load);
            this.parrotGradientPanel1.ResumeLayout(false);
            this.parrotGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEquipos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblAnotaciones;
        private System.Windows.Forms.Button btnAgregarJugador;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.ComboBox cboEquipo;
        private System.Windows.Forms.TextBox txtAnotaciones;
        private cboEquipos cboEquipos;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private cboEquiposTableAdapters.equipoTableAdapter equipoTableAdapter;
        private cboRoles cboRoles;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private cboRolesTableAdapters.rolTableAdapter rolTableAdapter;
        private System.Windows.Forms.Button btnModificar;
    }
}