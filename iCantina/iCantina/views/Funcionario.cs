using iCantina.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Interception;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.views
{
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            // variaveis dos dados das TextBoxes 
            string name = TextBoxName.Text;
            string nif = TextBoxNif.Text;
            string username = TextBoxUsername.Text;

            // Verifica se os campos estão preenchidos
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(nif) || string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Campos preenchimento obrigatório");
                return;
            }

            
        }
    } 
}