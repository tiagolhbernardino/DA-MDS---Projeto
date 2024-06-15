using iCantina.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.views
{
    public partial class FormularioPrincipal : Form
    {
        private Form formularioAtivo;
        private bool isImagem1 = true;

        public FormularioPrincipal()
        {
            InitializeComponent();
        }
        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            pictureBoxMenu.Image = Image.FromFile("../../Assets/menu/Menu_White.png");
        }


        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        private void gunaConsole_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();

                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }


        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ButtonMaxime_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            
        }
        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void trocarFormulario(Form novoFormulario)
        {
            // Elimina o fromulário caso já estaja outro abreto
            if (formularioAtivo != null)
            {
                formularioAtivo.Close();
                panelContainer.Controls.Remove(formularioAtivo);
            }

            // Configurar o novo formulário
            formularioAtivo = novoFormulario;
            novoFormulario.TopLevel = false;
            novoFormulario.FormBorderStyle = FormBorderStyle.None;
            novoFormulario.Dock = DockStyle.Fill;

            // Adicionar o novo formulário ao painel
            panelContainer.Controls.Add(novoFormulario);
            panelContainer.Tag = novoFormulario;

            novoFormulario.BringToFront();
            novoFormulario.Show();
        }

        // Menu
        private void funcionButtonMenu()
        {
            if (buttonMenu.Checked == false)
            {
                if (isImagem1)
                {
                    // Mudar de cor dos buttons menu
                    buttonReservation.FillColor = Color.OrangeRed;
                    pictureBoxReservation.BackColor = Color.OrangeRed;
                    buttonClient.FillColor = Color.OrangeRed;
                    pictureBoxClient.BackColor = Color.OrangeRed;
                    buttonEmployee.FillColor = Color.OrangeRed;
                    pictureBoxEmployee.BackColor = Color.OrangeRed;


                    // Mudar de cor no button menu
                    buttonMenu.FillColor = Color.White;
                    pictureBoxMenu.BackColor = Color.White;

                    pictureBoxMenu.Image = Image.FromFile("../../Assets/menu/Menu_Black.png");
                    
                    // divenir local dos buttons do submenu
                    buttonSubmenu1.Location = new System.Drawing.Point(0, 159);
                    buttonSubmenu2.Location = new System.Drawing.Point(0, 219);
                    buttonSubmenu3.Location = new System.Drawing.Point(0, 279);
                    buttonSubmenu4.Location = new System.Drawing.Point(0, 339);


                    // trocar o nome dos button do submenu
                    buttonSubmenu1.Text = "Pratos";
                    buttonSubmenu2.Text = "Extras";
                    buttonSubmenu3.Text = "Multa";
                    buttonSubmenu4.Text = "Fatura";

                    // tronar visivel o submenu
                    panelSubmenu.Visible = true;
                    buttonSubmenu1.Visible = true;
                    buttonSubmenu2.Visible = true;
                    buttonSubmenu3.Visible = true;
                    buttonSubmenu4.Visible = true;
                }
                else
                {
                    buttonMenu.FillColor = Color.OrangeRed;
                    pictureBoxMenu.BackColor = Color.OrangeRed;
                    pictureBoxMenu.Image = Image.FromFile("../../Assets/menu/Menu_White.png");
                    // tronar visivel o submenu
                    panelSubmenu.Visible = false;
                }

                isImagem1 = !isImagem1;


                
            }
        }
        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            funcionButtonMenu();
        }
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            funcionButtonMenu();
        }

        // Reservation
        private void ButtonReservation_Click(object sender, EventArgs e)
        {
            if (buttonReservation.Checked == false)
            {
                // Mudar de cor dos buttons menu
                buttonMenu.FillColor = Color.OrangeRed;
                buttonMenu.ForeColor = Color.White;
                buttonClient.FillColor = Color.OrangeRed;
                buttonClient.ForeColor = Color.White;
                buttonEmployee.FillColor = Color.OrangeRed;
                buttonEmployee.ForeColor = Color.White;

                // Mudar de cor no button menu
                buttonReservation.FillColor = Color.White;
                buttonReservation.ForeColor = Color.Black;


                // divenir local dos buttons do submenu
                buttonSubmenu1.Location = new System.Drawing.Point(0, 192);
                buttonSubmenu2.Location = new System.Drawing.Point(0, 252);
                buttonSubmenu3.Location = new System.Drawing.Point(0, 312);


                // trocar o nome dos button do submenu
                buttonSubmenu1.Text = "Pratos";
                buttonSubmenu2.Text = "Lista Pratos";
                buttonSubmenu3.Text = "Extras";

                // tronar visivel o submenu
                panelSubmenu.Visible = true;
                buttonSubmenu1.Visible = true;
                buttonSubmenu2.Visible = true;
                buttonSubmenu3.Visible = true;
                buttonSubmenu4.Visible = false;
            }
        }

        // Client
        private void ButtonClient_Click(object sender, EventArgs e)
        {
            if (buttonClient.Checked == false)
            {
                buttonMenu.FillColor = Color.OrangeRed;
                buttonMenu.ForeColor = Color.White;
                buttonReservation.FillColor = Color.OrangeRed;
                buttonReservation.ForeColor = Color.White;
                buttonEmployee.FillColor = Color.OrangeRed;
                buttonEmployee.ForeColor = Color.White;

                buttonClient.FillColor = Color.White;
                buttonClient.ForeColor = Color.Black;
            }

            trocarFormulario(new Faturas());
        }

        // Employee
        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            if (buttonClient.Checked == false)
            {
                buttonMenu.FillColor = Color.OrangeRed;
                buttonMenu.ForeColor = Color.White;
                buttonReservation.FillColor = Color.OrangeRed;
                buttonReservation.ForeColor = Color.White;
                buttonEmployee.FillColor = Color.OrangeRed;
                buttonEmployee.ForeColor = Color.White;

                buttonClient.FillColor = Color.White;
                buttonClient.ForeColor = Color.Black;
            }

            trocarFormulario(new Faturas());
        }


        // Button Submenus
        private void buttonSubmenu1_Click(object sender, EventArgs e)
        {
            if(buttonSubmenu1.Text == "Pratos")
            {
                // tornar invisivel o submenu
                panelSubmenu.Visible = false;
                buttonSubmenu1.Visible = false;
                buttonSubmenu2.Visible = false;
                buttonSubmenu3.Visible = false;
                buttonSubmenu4.Visible = false;

                // inserir o furmolario no form principal
                trocarFormulario(new Faturas());
            }
            

            if (buttonSubmenu1.Text == "Pratos")
            {                   
                // tornar invisivel o submenu
                panelSubmenu.Visible = false;
                buttonSubmenu1.Visible = false;
                buttonSubmenu2.Visible = false;
                buttonSubmenu3.Visible = false;

                // inserir o furmolario no form principal
                trocarFormulario(new Faturas());
            }
        }
        private void buttonSubmenu2_Click(object sender, EventArgs e)
        {
            if (buttonSubmenu2.Text == "Extras")
            {
                // tornar invisivel o submenu
                panelSubmenu.Visible = false;
                buttonSubmenu1.Visible = false;
                buttonSubmenu2.Visible = false;
                buttonSubmenu3.Visible = false;
                buttonSubmenu4.Visible = false;

                // inserir o furmolario no form principal
                trocarFormulario(new FromExtra());
            }


            if (buttonSubmenu2.Text == "Lista Pratos")
            {
                // tornar invisivel o submenu
                panelSubmenu.Visible = false;
                buttonSubmenu1.Visible = false;
                buttonSubmenu2.Visible = false;
                buttonSubmenu3.Visible = false;

                // inserir o furmolario no form principal
                trocarFormulario(new ListaPratos());
            }
        }
        private void buttonSubmenu3_Click(object sender, EventArgs e)
        {
            if (buttonSubmenu3.Text == "Multa")
            {
                // tornar invisivel o submenu
                panelSubmenu.Visible = false;
                buttonSubmenu1.Visible = false;
                buttonSubmenu2.Visible = false;
                buttonSubmenu3.Visible = false;
                buttonSubmenu4.Visible = false;

                // inserir o furmolario no form principal
                trocarFormulario(new Faturas());
            }


            if (buttonSubmenu3.Text == "Extras")
            {
                // tornar invisivel o submenu
                panelSubmenu.Visible = false;
                buttonSubmenu1.Visible = false;
                buttonSubmenu2.Visible = false;
                buttonSubmenu3.Visible = false;

                // inserir o furmolario no form principal
                trocarFormulario(new FromExtra());
            }
        }
        private void buttonSubmenu4_Click(object sender, EventArgs e)
        {
            if (buttonSubmenu4.Text == "Fatura")
            {
                // tornar invisivel o submenu
                panelSubmenu.Visible = false;
                buttonSubmenu1.Visible = false;
                buttonSubmenu2.Visible = false;
                buttonSubmenu3.Visible = false;
                buttonSubmenu4.Visible = false;

                // inserir o furmolario no form principal
                trocarFormulario(new Faturas());
            }
        }

        
    }
}
