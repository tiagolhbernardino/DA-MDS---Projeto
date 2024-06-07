using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    internal class Reserva
    {
        // Class
        public Cliente Cliente {  get; set; }
        public Multa Multa { get; set; }
        public Prato Prato { get; set; }
        public Menu Menu { get; set; }
        public Extra Extra { get; set; }

        public Reserva()
        {
        }
    }
}
