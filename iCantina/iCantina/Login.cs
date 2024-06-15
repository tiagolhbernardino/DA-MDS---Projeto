using iCantina.controller;
using iCantina.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        // Entrar usando a tecla 'Enter' sem precisar clicar no button 'Login'
        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Simula o clique do button
                buttonLogIn.PerformClick();

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
                buttonLogIn.PerformClick();

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
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string Username = textBoxUsername.Text;
            string Password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                labelErro.Visible = true;
                labelErro.Text = "Todos os campos são de preenchimento obrigatório";
                return;
            }
            
        }


        // Button para fechar o form de Login
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
