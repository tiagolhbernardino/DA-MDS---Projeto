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
    public partial class Extras : Form
    {
        public Extras()
        {
            InitializeComponent();
        }

        private void bt_criarExtras_Click(object sender, EventArgs e)
        {
            string extra = textBoxExtras.Text;

            listBoxExtras.Items.Add(extra);
        }
    }
}
