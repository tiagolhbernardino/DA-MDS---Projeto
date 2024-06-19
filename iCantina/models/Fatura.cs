using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    public class Fatura
    {
        // Parametros da Class
        [Key]
        public int Id { get; set; }
        public float Total {  get; set;  }
        public DateTime DataHora { get; set; }

        // Lista dos Itens da Fatura
        public List<ItemFatura> faturas { get; set; }

        // Class
        public Cliente Cliente { get; set; }
        public Menu Menu { get; set; }
        public ICollection<object> ItemFaturas { get; internal set; }

        // Constructor
        public Fatura()
        {
            faturas = new List<ItemFatura>();
        }
    }
}
