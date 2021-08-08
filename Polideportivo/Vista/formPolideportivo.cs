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
        private FlowLayoutPanel subMenuActivo = null;

        // Botones sin submenú
        private void btnDeportes_Click(object sender, EventArgs e)
        {
            botonSeleccionadoSinSubmenu(panelMenuDeportes);
            gestorDeFormActivo(new formDeporte(), "DEPORTES");
            cerrarOtrosSubmenusActivos();
        }

        private void btnMenuJugador_Click(object sender, EventArgs e)
        {
            botonSeleccionadoSinSubmenu(panelMenuJugadores);
            gestorDeFormActivo(new formJugador(), "JUGADORES");
            cerrarOtrosSubmenusActivos();
        }

        private void btnMenuEquipo_Click(object sender, EventArgs e)
        {
            botonSeleccionadoSinSubmenu(panelMenuEquipos);
            gestorDeFormActivo(new formEquipo(), "EQUIPO");
            cerrarOtrosSubmenusActivos();
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            botonSeleccionadoSinSubmenu(panelMenuRoles);
            gestorDeFormActivo(new formRol(), "ROLES");
            cerrarOtrosSubmenusActivos();
        }

        private void btnMenuEntrenador_Click(object sender, EventArgs e)
        {
            botonSeleccionadoSinSubmenu(panelMenuEntrenador);
            gestorDeFormActivo(new formEntrenador(), "ENTRENADOR");
            cerrarOtrosSubmenusActivos();
        }

        private void btnMenuEmpleado_Click(object sender, EventArgs e)
        {
            botonSeleccionadoSinSubmenu(panelMenuEmpleado);
            gestorDeFormActivo(new formEmpleado(), "EMPLEADO");
            cerrarOtrosSubmenusActivos();
        }

        private void btnMenuFalta_Click(object sender, EventArgs e)
        {
            botonSeleccionadoSinSubmenu(panelMenuFaltas);
            gestorDeFormActivo(new formTipoFalta(), "TIPOS DE FALTAS");
            cerrarOtrosSubmenusActivos();
        }

        //Botones con submenú
        private void btnMenuCampeonato_Click(object sender, EventArgs e)
        {
            botonSeleccionadoConSubmenu(panelMenuCampeonato, panelSubmenuCampeonatos);
            gestorDeFormActivo(new formCampeonato(), "CAMPEONATO");
            comprobarSiEsElMismoSubMenu(panelSubmenuCampeonatos);
        }

        private void btnMenuPartido_Click(object sender, EventArgs e)
        {
            botonSeleccionadoConSubmenu(panelMenuPartidos, panelSubMenuPartidos);
            gestorDeFormActivo(new formPartido(), "PARTIDO");
            comprobarSiEsElMismoSubMenu(panelSubMenuPartidos);
        }

        // Submenús
        private void btnSubMenuParticipante_Click(object sender, EventArgs e)
        {
            gestorDeFormActivoSubmenu(new formParticipante(), "PARTICIPANTES DE CAMPEONATOS");
            botonSeleccionadoDentroDeSubmenu(panelMenuCampeonato, btnSubMenuParticipante);
        }

        private void btnSubMenuPosiciones_Click(object sender, EventArgs e)
        {
            gestorDeFormActivoSubmenu(new formParticipante(), "TABLA DE POSICIONES");
            botonSeleccionadoDentroDeSubmenu(panelMenuCampeonato, btnSubMenuPosiciones);
        }

        private void btnSubMenuPartidosResultado_Click(object sender, EventArgs e)
        {
            gestorDeFormActivoSubmenu(new formParticipante(), "RESULTADOS DE PARTIDOS");
            botonSeleccionadoDentroDeSubmenu(panelMenuPartidos, btnSubMenuPartidosResultado);
        }

        private void gestorDeFormActivo(Form formHijo, string formHijoActual)
        {
            lblTituloPrincipal.Text = formHijoActual;
            if (formPrincipalAnterior == formHijoActual)
            {
                cerrarFormActivo();
                formPrincipalAnterior = "";
                lblTituloPrincipal.Text = "POLIDEPORTIVO";
                subMenuActivo = null;
                botonSeleccionado.BackColor = Color.Transparent;
            }
            else
            {
                formPrincipalAnterior = formHijoActual;
                cerrarFormActivo();
                abrirFormHijo(formHijo, panelPrincipal);
            }
        }

        private void gestorDeFormActivoSubmenu(Form formHijo, string formHijoActual)
        {
            lblTituloPrincipal.Text = formHijoActual;
            if (formPrincipalAnterior == formHijoActual)
            {
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

        private FlowLayoutPanel botonSeleccionado = null;

        private void botonSeleccionadoConSubmenu(FlowLayoutPanel btn, FlowLayoutPanel subbtns)
        {
            resetearColores();
            btn.BackColor = Color.FromArgb(18, 57, 112);
            botonSeleccionado = btn;
            subbtns.BackColor = Color.FromArgb(24, 63, 105);
        }

        private void botonSeleccionadoSinSubmenu(FlowLayoutPanel btn)
        {
            resetearColores();
            btn.BackColor = Color.FromArgb(18, 57, 112);
            botonSeleccionado = btn;
        }

        private void botonSeleccionadoDentroDeSubmenu(FlowLayoutPanel btnPrincipal, Button btn)
        {
            resetearColores();
            btn.BackColor = Color.FromArgb(18, 57, 112);
            botonSeleccionado = btnPrincipal;
            btnPrincipal.BackColor = Color.FromArgb(24, 63, 105);
        }

        private void resetearColores()
        {
            btnSubMenuPosiciones.BackColor = Color.Transparent;
            btnSubMenuParticipante.BackColor = Color.Transparent;
            btnSubMenuPartidosResultado.BackColor = Color.Transparent;
            panelMenuEquipos.BackColor = Color.Transparent;
            panelMenuCampeonato.BackColor = Color.Transparent;
            panelMenuDeportes.BackColor = Color.Transparent;
            panelMenuEmpleado.BackColor = Color.Transparent;
            panelMenuEntrenador.BackColor = Color.Transparent;
            panelMenuFaltas.BackColor = Color.Transparent;
            panelMenuJugadores.BackColor = Color.Transparent;
            panelMenuRoles.BackColor = Color.Transparent;
            panelMenuPartidos.BackColor = Color.Transparent;
        }

        private void comprobarSiEsElMismoSubMenu(FlowLayoutPanel submenu)
        {
            if (subMenuActivo == submenu)
            {
            }
            else
            {
                cerrarOtrosSubmenusActivos();
                gestorDeSubMenu(submenu);
            }
        }

        private void cerrarOtrosSubmenusActivos()
        {
            if (subMenuActivo == null)
            {
            }
            else
            {
                subMenuActivo.Visible = false;
                subMenuActivo = null;
            }
        }

        private void gestorDeSubMenu(FlowLayoutPanel subpanel)
        {
            if (subpanel.Visible == false)
            {
                subMenuActivo = subpanel;
                subpanel.Visible = true;
            }
            else
            {
                subMenuActivo = null;
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