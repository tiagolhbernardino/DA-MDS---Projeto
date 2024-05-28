using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.views
{
    public partial class FormularioPrincipal : Form
    {
        private Form formularioAtivo;
        private Button buttonAtivo;

        public FormularioPrincipal()
        {
            InitializeComponent();
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
            // Elimina o Fromolário caso já estaja outro abreto
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
        

        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            if (ButtonMenu.Checked == false)
            {
                ButtonReserva.FillColor = Color.OrangeRed;
                ButtonReserva.ForeColor = Color.White;
                ButtonClientes.FillColor = Color.OrangeRed;
                ButtonClientes.ForeColor = Color.White;
                ButtonFatuta.FillColor = Color.OrangeRed;
                ButtonFatuta.ForeColor = Color.White;

                ButtonMenu.FillColor = Color.White;
                ButtonMenu.ForeColor = Color.Black;
            }

            trocarFormulario(new Funcionário());
        }
        private void ButtonReserva_Click(object sender, EventArgs e)
        {
            if (ButtonReserva.Checked == false)
            {
                ButtonMenu.FillColor = Color.OrangeRed;
                ButtonMenu.ForeColor = Color.White;
                ButtonClientes.FillColor = Color.OrangeRed;
                ButtonClientes.ForeColor = Color.White;
                ButtonFatuta.FillColor = Color.OrangeRed;
                ButtonFatuta.ForeColor = Color.White;

                ButtonReserva.FillColor = Color.White;
                ButtonReserva.ForeColor = Color.Black;
            }

            trocarFormulario(new GestaoCliente());
        }
        private void ButtonClientes_Click(object sender, EventArgs e)
        {
            if (ButtonClientes.Checked == false)
            {
                ButtonMenu.FillColor = Color.OrangeRed;
                ButtonMenu.ForeColor = Color.White;
                ButtonReserva.FillColor = Color.OrangeRed;
                ButtonReserva.ForeColor = Color.White;
                ButtonFatuta.FillColor = Color.OrangeRed;
                ButtonFatuta.ForeColor = Color.White;

                ButtonClientes.FillColor = Color.White;
                ButtonClientes.ForeColor = Color.Black;
            }

            trocarFormulario(new GestaoCliente());
        }
        private void ButtonFatuta_Click(object sender, EventArgs e)
        {
            if (ButtonFatuta.Checked == false)
            {
                ButtonMenu.FillColor = Color.OrangeRed;
                ButtonMenu.ForeColor = Color.White;
                ButtonReserva.FillColor = Color.OrangeRed;
                ButtonReserva.ForeColor = Color.White;
                ButtonClientes.FillColor = Color.OrangeRed;
                ButtonClientes.ForeColor = Color.White;

                ButtonFatuta.FillColor = Color.White;
                ButtonFatuta.ForeColor = Color.Black;
            }

            trocarFormulario(new Faturas());
        }
    }
}
