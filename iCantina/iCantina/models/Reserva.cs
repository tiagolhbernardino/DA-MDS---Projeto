using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    public class Reserva
    {
        [Key]
        public int Id{  get; set; }


        // Lista das class
        public List<Multa> Multas { get; set; }
        public List<Prato> pratos { get; set; }
        public List<Menu> menus { get; set; }
        public List<Extra> extras { get; set; }


        // Class
        public Cliente cliente { get; set; }


        // Constructor
        public Reserva()
        {
        }
    }
}
