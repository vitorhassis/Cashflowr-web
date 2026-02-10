using Cashflow.Models;
using Microsoft.EntityFrameworkCore;

namespace CashFlowr.Data
{
    public class MyCashContext : DbContext
    {
        public MyCashContext(DbContextOptions<MyCashContext> opts) : base(opts)
        {

        }
        public DbSet<Contas> Contas { get; set; }
        public DbSet<Entradas> Entradas { get; set; }
        public DbSet<Meta> Metas { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Saida> Saidas { get; set; }
    }
}

