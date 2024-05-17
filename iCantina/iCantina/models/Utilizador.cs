using iCantina.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    internal class Utilizador
    {
        public string Nome {  get; set; }
        public int Id {  get; set; }
        public int Nif {  get; set; }

        // Class
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
    }
}
