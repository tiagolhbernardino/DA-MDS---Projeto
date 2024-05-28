using iCantina.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Closed_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string Username = textBoxUsername.Text;
            string Password = textBoxPassword.Text;

            if (Username == "admin" && Password == "admin")
            {
                FormularioPrincipal principal = new FormularioPrincipal();

                Hide();
                principal.FormClosed += Closed_FormClosed;
                principal.ShowDialog();

            }else if(Username!="admin" || Password != "admin")      
            {
                labelErro.Visible = true;
                labelErro.Text = "Username ou Password está incorreta";
            }
            else if(Username =="admin" || Password != "admin")
            {
                labelErro.Visible = true;
                labelErro.Text = "Password Errada";
            }
            else if (Username!="admin" || Password == "admin")
            {
                labelErro.Visible= true;
                labelErro.Text = "Username não existe";
            }
        }

        
    }
}
