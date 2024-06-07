using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.views
{
    public partial class GestaoCliente : Form
    {
        public GestaoCliente()
        {
            InitializeComponent();

        }


        private void buttonCriar_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string nif = textBoxNif.Text;
            string multiescolha = textBoxMultiEscolha.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(nif) || string.IsNullOrEmpty(multiescolha))

            {
                MessageBox.Show("Campos preenchimento obrigatório");
                return;
            }

            if (textBoxMultiEscolha.Name == "textBoxProfessor")
            {
                try
                {
                    MailAddress adr = new MailAddress(multiescolha);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Email incorreto");
                    return;
                }
            }
        }
        private void checkBoxProfessor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProfessor.Checked == true)
            {
                checkBoxAluno.Checked = false;

                labelmultiescolha.Text = "Email";
                labelmultiescolha.Visible = true;
                textBoxMultiEscolha.Visible = true;
                textBoxMultiEscolha.Name = "textBoxProfessor";


            }
            else if (checkBoxProfessor.Checked == false)
            {
                labelmultiescolha.Visible = false;
                textBoxMultiEscolha.Visible = false;
            }
        }

        private void checkBoxAluno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAluno.Checked == true)
            {
                checkBoxProfessor.Checked = false;

                labelmultiescolha.Text = "Numero Estudante";
                labelmultiescolha.Visible = true;
                textBoxMultiEscolha.Visible = true;
                textBoxMultiEscolha.Name = "textBoxAluno";
            }
            else if (checkBoxAluno.Checked == false)
            {
                labelmultiescolha.Visible = false;
                textBoxMultiEscolha.Visible = false;
            }
        }
    }
}
