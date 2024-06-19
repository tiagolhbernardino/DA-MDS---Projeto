using iCantina.controller;
using iCantina.models;
using iCantina.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.PeerToPeer;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.SessionState;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace iCantina
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        private void panelFormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();

                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        // Entrar usando a tecla 'Enter' sem precisar clicar no button 'Login'
        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Simula o clique do button
                buttonLogin.PerformClick();

                // Indica que o evento foi tratado
                e.Handled = true;

                // Previne que a tecla 'Enter' seja processada pelo controle
                e.SuppressKeyPress = true;
            }
        }
        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Simula o clique do button
                buttonLogin.PerformClick();

                // Indica que o evento foi tratado
                e.Handled = true;

                // Previne que a tecla 'Enter' seja processada pelo controle
                e.SuppressKeyPress = true;
            }
        }

        
        // Função para fechar o form depois de entra
        private void Closed_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        // button para confirmar se login se o 'Username' e 'Password' estiverem certas entra no form
        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                textBoxError.Visible = true;
                textBoxError.Text = "Username ou Password Incorretos";
            }

            using (var db = new iCantinaContext())
            {
                var funcionario = db.utilizadors.OfType<Funcionario>().FirstOrDefault(u => u.Username == username && u.Password == password);

                if (funcionario != null)
                {
                    sessionManager.Login(funcionario);

                    FormMain formMain = new FormMain();

                    Hide();
                    formMain.FormClosed += Closed_FormClosed;
                    formMain.ShowDialog();
                }
                else
                {
                    textBoxError.Visible = true;
                    textBoxError.Text = "Username ou Password Incorretos";

                }
            }
        }


        // Button para fechar o form de Login
        private void labelExist_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxVisibilityPassword_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxVisibilityPassword.Image = Image.FromFile("../../Assets/Login/icons/Visibility_On_Black.png");

            textBoxPassword.UseSystemPasswordChar = false;
            textBoxPassword.PasswordChar = '\0';
            textBoxPassword.Refresh();
        }

        private void pictureBoxVisibilityPassword_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxVisibilityPassword.Image = Image.FromFile("../../Assets/Login/icons/Visibility_Off_Black.png");

            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.PasswordChar = '•';
            textBoxPassword.Refresh();
        }
    }
}
