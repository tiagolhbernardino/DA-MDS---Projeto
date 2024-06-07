using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    public class Utilizador
    {
        // Parametros da Class
        [Key]
        public int Id { get; set; }
        public string Name {  get; set; }
        public string Nif {  get; set; }

        // Construtor
        public Utilizador() 
        { 
        }
    }
}
