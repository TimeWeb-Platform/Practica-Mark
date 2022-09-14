using Microsoft.EntityFrameworkCore;
using Usuarios.Domain;

namespace Usuarios.Context
{
    public class ContextUsuario :DbContext
    {
        public ContextUsuario(DbContextOptions options) : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder modelB){

            modelB.Entity<OUsuario>().HasKey(x => x.UsuarioID);

            base.OnModelCreating(modelB);
        }

        public DbSet<OUsuario> Tusuario { get; set; }
    }
}
