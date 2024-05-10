using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    internal class Fatura
    {
        public float Total {  get; set; }
        public DateTime DataHora { get; set; }
        
        // Class
        public Cliente Cliente { get; set; }
        public Menu Menu { get; set; }
    }
}
