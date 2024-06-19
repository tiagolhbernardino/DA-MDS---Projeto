using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.IO.Ports;
using System.Web.UI.Design;

namespace iCantina.views
{
    public partial class LatPaymentfines : Form
    {
        private DateTime contadorTempo;

        private decimal multa = 1.00m;

        public LatPaymentfines()
        {
            InitializeComponent();
            timer1.Interval = 60*60*1000;// define o tempo para 1 hora
        }   

        private void Timer1_Tick(object sender, EventArgs e)
        {
            multa += 0.25m; // Aumenta 50 centavos a cada hora
            labelValor.Text = $"{multa:F2}";

            contadorTempo = DateTime.Now;
            textBoxHoras.Text = DateTime.Now.ToLongDateString();
            contadorTempo = contadorTempo.Add(new TimeSpan(0, 0, 0));
            textBoxHoras.Text = contadorTempo.ToString("HH:mm:ss");
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            timer1.Start();
            
        }

        private void buttonParar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
