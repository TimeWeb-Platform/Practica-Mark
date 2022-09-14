using Microsoft.EntityFrameworkCore;
using Usuarios.Domain;

namespace Usuarios.Context
{
    public class ContextUsuario :DbContext
    {
        public DbSet<Usuario> Tusuario { get; set; }
    }
}
