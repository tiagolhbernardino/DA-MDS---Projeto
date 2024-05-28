using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace iCantina.views
{
    public partial class Faturas : Form
    {
        public Faturas()
        {
            InitializeComponent();
        }

        private void Closed_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormularioPrincipal principal = new FormularioPrincipal();

            Hide();
            principal.FormClosed += Closed_FormClosed;
            principal.Show();
            

        }

        private void checkBoxAluno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAluno.Checked==true)
            {
                checkBoxProfessor.Checked = false;
                labelEmail.Text = "Numero de aluno";
                labelEmail.Visible = true;
                textBoxEmail.Visible = true;
                

            }
            else if (checkBoxAluno.Checked == false)
            {
                labelEmail.Visible = false;
                textBoxEmail.Visible = false;

            }

           
        }

        private void checkBoxProfessor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProfessor.Checked == true)
            {
                checkBoxAluno.Checked = false;
                labelEmail.Text = "Email";
                labelEmail.Visible = true;
                textBoxEmail.Visible = true;

            }
            else if (checkBoxProfessor.Checked == false)
            {
                labelEmail.Visible = false;
                textBoxEmail.Visible = false;

            }
        

        }
    }
}
