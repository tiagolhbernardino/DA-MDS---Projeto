using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    internal class Funcionario
    {
        public string Username { get; set; }

        public Funcionario(string username)
        {
            Username = username;
        }
    }
}
