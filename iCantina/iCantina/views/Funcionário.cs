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
    public partial class Funcionário : Form
    {
        public Funcionário()
        {
            InitializeComponent();
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            string name = textBoxname.Text;
            string nif = textBoxNif.Text;
            string username = textBoxUsername.Text;


        }
    }
}
