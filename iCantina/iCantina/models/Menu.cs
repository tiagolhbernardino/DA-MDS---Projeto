using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    internal class Menu
    {
        public DateTime DataHora { get; set; }
        public int QdDesponivel {  get; set; }
        public float PrecoEstudante { get; set; }
        public float PrecoProfessor { get; set; }

        // Class
        public Prato Prato { get; set; }
        public Extra Extra { get; set; }

        public Menu()
        {
        }
    }
}
