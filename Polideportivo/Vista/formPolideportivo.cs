using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class formPolideportivo : Form
    {
        /// <summary>
        /// Inicializa los componentes dentro del form lo que son los páneles
        /// </summary>
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
        /// <summary>
        /// Al presionar el botón de restaurar restaura la ventana a su tamaño original
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Maximizar.Visible = true;
            Restaurar.Visible = false;
        }
        /// <summary>
        /// Al presionar el botón de minimizar, minimiza la ventana del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Al presionar el botón de maximizar, maximiza la ventana del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }
        /// <summary>
        /// Al presionar el boton de salir, finaliza el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Da las instrucciones de tamaño de lo que es los páneles laterales del menú
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLateral_Click(object sender, EventArgs e)
        {
            if (panelLateralInterno.Width == 250)
            {
                panelLateralInterno.Width = 55;
                panelLateralWrapper.Width = 92;
                separadorLogo.Width = 51;
                separadorLogo.Location = new Point(2, 64);
                imgTitulo.Location = new Point(6, 16);
            }
            else
            {
                panelLateralInterno.Width = 250;
                panelLateralWrapper.Width = 280;

                separadorLogo.Width = 220;
                separadorLogo.Location = new Point(12, 64);
                imgTitulo.Location = new Point(29, 16);
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

        private void btnSubMenuPosiciones_Click(object sender, EventArgs e)
        {
            gestorDeFormActivoSubmenu(new formParticipante(), "TABLA DE POSICIONES");
            botonSeleccionadoDentroDeSubmenu(panelMenuCampeonato, btnSubMenuPosiciones);
        }

        private void btnSubMenuPartidosResultado_Click(object sender, EventArgs e)
        {
            gestorDeFormActivoSubmenu(new formResultado(), "RESULTADO");
            botonSeleccionadoDentroDeSubmenu(panelMenuPartidos, btnSubMenuPartidosResultado);
        }
        /// <summary>
        /// Su función es para gestionar los forms activos a la hora de seleccionar otro
        /// </summary>
        /// <param name="formHijo"></param>
        /// <param name="formHijoActual"></param>
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
        /// <summary>
        /// Su función es gestionar los submenus del menú
        /// </summary>
        /// <param name="formHijo"></param>
        /// <param name="formHijoActual"></param>
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

        /// <summary>
        /// Funcíon para que los forms queden dentro del panel de dentro sin necesidad de cerrar la barra lateral del menú
        /// </summary>
        /// <param name="formHijo"></param>
        /// <param name="panel"></param>
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
        /// <summary>
        /// Su función es cerrar el form que se abrió al presionar dos veces en el botón
        /// </summary>
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