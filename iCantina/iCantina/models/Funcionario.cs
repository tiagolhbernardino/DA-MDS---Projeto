using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    public class Funcionario : Utilizador
    {
        // Parametros da Class
        public string Username { get; set; }
        public string Password { get; set; }



        // Construtor padrão
        public Funcionario() 
        {
        }
    }
}
