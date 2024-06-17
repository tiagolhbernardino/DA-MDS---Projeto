using iCantina.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace iCantina
{
    internal class iCantinaContext : DbContext
    {
        public DbSet<Utilizador> utilizadors { get; set; }


        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Multa> Multas { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Prato> Pratos { get; set; }
        public DbSet<Extra> Extras { get; set; }


        public DbSet<Fatura> Faturas { get; set; }
        public DbSet<ItemFatura> ItemFaturas { get; set; }

        
    }
}
