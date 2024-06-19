using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    public class Multa
    {
        // Parametros da Class
        [Key]
        public int Id { get; set; }
        public float Valor {  get; set; }
        public DateTime NumeroHoras { get; set; }

        // Constructor
        public Multa()
        {
        }
    }
}
