using Microsoft.EntityFrameworkCore;
using Usuarios.Domain;

namespace Usuarios.Context
{
    public class ContextUsuario : DbContext
    {
        public ContextUsuario(DbContextOptions options) : base(options)
        {
        }
        public DbSet<OUsuario> TUsuario { get; set; }

    }

}
