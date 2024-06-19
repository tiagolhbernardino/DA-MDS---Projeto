using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    public class Cliente : Utilizador
    {
        // Parametros da Class
        public float Saldo {  get; set; }

        // Constructor
        public Cliente()
        {
        }
    }
}
