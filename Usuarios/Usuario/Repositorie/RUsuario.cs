using Microsoft.EntityFrameworkCore;
using Usuarios.Context;
using Usuarios.Domain;
using Usuarios.DTO;

namespace Usuarios.Usuario.Repositorie
{
    public class RUsuario
    {
        private readonly ContextUsuario context;

        public RUsuario(ContextUsuario _context)
        {
            context = _context;
        }


        public async Task<List<OUsuario>> GetAll()
        {
            var result = await context.TUsuario.ToListAsync();
            return result;
        }

        public async Task<OUsuario> GetID(int pID)
        {
            var result = await context.TUsuario.FirstOrDefaultAsync(x => x.ID == pID);
            return result;
        }

        public async Task<int> Post(OUsuario pUsuario)
        {
            context.Add(pUsuario);
            var result = await context.SaveChangesAsync();
            return result;
        }

        public async Task<int> Put(OUsuario pUsuario)
        {
            context.Update(pUsuario);
            var result = await context.SaveChangesAsync();
            return result;
        }

        public async Task<int> Delete(OUsuario pUsuario)
        {
            context.Remove(pUsuario);
            var result = await context.SaveChangesAsync();
            return result;
        }
//////////////////////////////////////////////////////////////////////////////
    }
}
