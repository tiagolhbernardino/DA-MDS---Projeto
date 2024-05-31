using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.views
{
    public partial class Menu : Form

    {


       
        public Menu()
        {
            InitializeComponent();

        }

        private void buttonPratos_Click(object sender, EventArgs e)
        {
           


            // Cria uma nova instância do formulário ListaPratos
            ListaPratos pratos = new ListaPratos();

            // Oculta o formulário atual (Menu)
            this.Hide();

            // Exibe o novo formulário ListaPratos
            pratos.Show();

          
        }

        
    }
}
