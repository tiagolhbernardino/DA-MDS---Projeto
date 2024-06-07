using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    internal class Cliente
    {
        public float saldo {  get; set; }

        // Class
        public Estudante Estudante { get; set; }
        public Professor Professor { get; set; }

        public Cliente(float saldo, Estudante estudante, Professor professor)
        {
            
        }
    }
}
