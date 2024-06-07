using iCantina.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
        public DbSet<Prato> pratos { get; set; }
        public DbSet<Extra> extras { get; set; }


        public DbSet<Fatura> faturas { get; set; }
        public DbSet<ItemFatura> itemFaturas { get; set; }
    }
}
