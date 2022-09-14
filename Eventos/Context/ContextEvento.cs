using Eventos.Domain;
using Microsoft.EntityFrameworkCore;

namespace Eventos.Context
{
    public class ContextEvento : DbContext
    {
        public ContextEvento(DbContextOptions options) : base(options)
        {}
        public DbSet<OEvento> TEvento { get; set; }

    }
}
