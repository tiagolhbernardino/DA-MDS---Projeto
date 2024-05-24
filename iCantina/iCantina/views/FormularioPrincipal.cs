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
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }
        private void Closed_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Faturas faturas=new Faturas();

            Hide();
            faturas.FormClosed += Closed_FormClosed;
            faturas.Show();
        }
    }
}
