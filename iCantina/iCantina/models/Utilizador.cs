using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    internal class Utilizador
    {
        public string Name {  get; set; }
        public int Id {  get; set; }
        public string Nif {  get; set; }

        // Class
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }

        public Utilizador(string name, string nif)
        {
            Name = name;
            Nif = nif;
        }
    }
}
