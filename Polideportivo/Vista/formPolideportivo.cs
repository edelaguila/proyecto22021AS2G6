using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class formPolideportivo : Form
    {
        public formPolideportivo()
        {
            InitializeComponent();
            panelLateralInterno.HorizontalScroll.Maximum = 0;
            panelLateralInterno.VerticalScroll.Maximum = 0;
            panelLateralInterno.AutoScroll = false;
            panelLateralInterno.VerticalScroll.Visible = false;
            panelLateralInterno.AutoScroll = true;
            panelLateralInterno.AutoScrollPosition = new Point(panelLateralInterno.AutoScrollPosition.X, 0);
            panelLateralInterno.VerticalScroll.Value = 0;

            this.panelLateralInterno.MouseWheel += panelLateralInterno_MouseWheel;
            panelMenuCampeonato.Select();
            panelSubmenuCampeonatos.Visible = false;
            panelSubMenuPartidos.Visible = false;
            //
        }

        protected override void OnResizeBegin(EventArgs e)
        {
            SuspendLayout();
            base.OnResizeBegin(e);
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            ResumeLayout();
            base.OnResizeEnd(e);
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Maximizar.Visible = true;
            Restaurar.Visible = false;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLateral_Click(object sender, EventArgs e)
        {
            if (panelLateralInterno.Width == 250)
            {
                panelLateralInterno.Width = 77;
                panelLateralWrapper.Width = 105;
                separadorLogo.Width = 57;
            }
            else
            {
                panelLateralInterno.Width = 250;
                panelLateralWrapper.Width = 280;

                separadorLogo.Width = 220;
            }
        }

        private Form formActivo = null;
        private string formPrincipalAnterior = "";
        private bool subMenuActivo = false;

        private void btnDeportes_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new formDeporte(), "DEPORTES");
            botonSeleccionadoSinSubmenu(panelMenuDeportes);
        }

        private void btnMenuJugador_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new formJugador(), "JUGADORES");
            botonSeleccionadoSinSubmenu(panelMenuJugadores);
        }

        private void btnMenuEquipo_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new formEquipo(), "EQUIPO");
            botonSeleccionadoSinSubmenu(panelMenuEquipos);
        }

        private void btnMenuCampeonato_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new formCampeonato(), "CAMPEONATO");
            gestorDeSubMenu(panelSubmenuCampeonatos);
            botonSeleccionadoConSubmenu(panelMenuCampeonato, panelSubmenuCampeonatos);
        }

        private void btnMenuPartido_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new formPartido(), "PARTIDO");
            gestorDeSubMenu(panelSubMenuPartidos);
            botonSeleccionadoConSubmenu(panelMenuPartidos, panelSubMenuPartidos);
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new formRol(), "ROLES");
            botonSeleccionadoSinSubmenu(panelMenuRoles);
        }

        private void btnMenuEntrenador_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new formEntrenador(), "ENTRENADOR");
            botonSeleccionadoSinSubmenu(panelMenuEntrenador);
        }

        private void btnMenuEmpleado_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new formEmpleado(), "EMPLEADO");
            botonSeleccionadoSinSubmenu(panelMenuEmpleado);
        }

        private void btnMenuFalta_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new formTipoFalta(), "TIPOS DE FALTAS");
            botonSeleccionadoSinSubmenu(panelMenuFaltas);
        }

        // Submenús
        private void btnSubMenuParticipante_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new formParticipante(), "PARTICIPANTES DE CAMPEONATOS");
            botonSeleccionadoDentroDeSubmenu(panelMenuCampeonato, btnSubMenuParticipante);
        }

        private void btnSubMenuPosiciones_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new formParticipante(), "TABLA DE POSICIONES");
            botonSeleccionadoDentroDeSubmenu(panelMenuCampeonato, btnSubMenuPosiciones);
        }

        private void gestorDeFormActivo(Form formHijo, string formHijoActual)
        {
            lblTituloPrincipal.Text = formHijoActual;
            if (formPrincipalAnterior == formHijoActual)
            {
                cerrarFormActivo();
                formPrincipalAnterior = "";
                lblTituloPrincipal.Text = "POLIDEPORTIVO";
            }
            else
            {
                formPrincipalAnterior = formHijoActual;
                cerrarFormActivo();
                abrirFormHijo(formHijo, panelPrincipal);
            }
        }

        private void abrirFormHijo(Form formHijo, Panel panel)
        {
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panel.Controls.Add(formHijo);
            panel.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void cerrarFormActivo()
        {
            if (formActivo != null)
            {
                formActivo.Close();
                formActivo = null;
            }
        }

        private void botonSeleccionadoConSubmenu(FlowLayoutPanel btn, FlowLayoutPanel subbtns)
        {
            resetearColores();
            btn.BackColor = Color.FromArgb(18, 57, 112);
            subbtns.BackColor = Color.FromArgb(24, 63, 105);
        }

        private void botonSeleccionadoSinSubmenu(FlowLayoutPanel btn)
        {
            resetearColores();
            btn.BackColor = Color.FromArgb(18, 57, 112);
        }

        private void botonSeleccionadoDentroDeSubmenu(FlowLayoutPanel btnPrincipal, Button btn)
        {
            resetearColores();
            btn.BackColor = Color.FromArgb(18, 57, 112);
            btnPrincipal.BackColor = Color.FromArgb(24, 63, 105);
        }

        private void resetearColores()
        {
            btnSubMenuPosiciones.BackColor = Color.Transparent;
            btnSubMenuParticipante.BackColor = Color.Transparent;
            panelMenuEquipos.BackColor = Color.Transparent;
            panelMenuCampeonato.BackColor = Color.Transparent;
            panelMenuDeportes.BackColor = Color.Transparent;
            panelMenuEmpleado.BackColor = Color.Transparent;
            panelMenuEntrenador.BackColor = Color.Transparent;
            panelMenuFaltas.BackColor = Color.Transparent;
            panelMenuJugadores.BackColor = Color.Transparent;
            panelMenuPartidos.BackColor = Color.Transparent;
            panelMenuRoles.BackColor = Color.Transparent;
            panelSubmenuCampeonatos.BackColor = Color.Transparent;
        }

        private void gestorDeSubMenu(FlowLayoutPanel subpanel)
        {
            if (subpanel.Visible == false)
            {
                subpanel.Visible = true;
            }
            else
            {
                subpanel.Visible = false;
            }
        }

        //Evento Hover -> panelLateralInterno.Focus();

        private void panelLateralInterno_MouseWheel(object sender, MouseEventArgs e)
        {
            panelLateralInterno.Invalidate();
        }
    }
}