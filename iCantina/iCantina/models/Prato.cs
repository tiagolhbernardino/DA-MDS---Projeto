using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    public class Prato
    {
        // Parametros da Class
        [Key]
        public int Id { get; set; }
        public string Descricao {  get; set; }
        public string Tipo { get; set; }
        public string Ativo { get; set;}

        // Constructor
        public Prato()
        {
        }
    }
}
