using Eventos.Context;
using Eventos.Domain;
using Microsoft.EntityFrameworkCore;

namespace Eventos.Evento.Repostorie
{
    public class REvento
    {
        private readonly ContextEvento _context;

        public REvento(ContextEvento context)
        {
            _context = context;
        }
        public async Task<List<OEvento>> GetAll()
        {
            var result = await _context.TEvento.ToListAsync();
            return result;
        }

        public async Task<OEvento> GetID(int pID)
        {
            var result = await _context.TEvento.FirstOrDefaultAsync(x => x.ID == pID);
            return result;
        }
        public async Task<List<OEvento>> GetDates(int pID,DateTime pdateS, DateTime pDateF)
        {
            var result = await _context.TEvento.Where(x => x.UsuarioID == pID && x.FechaAlta >= pdateS && x.FechaAlta <= pDateF). ToListAsync();
            return result;
        }

        public async Task<int> Post(OEvento pEvento)
        {
            _context.Add(pEvento);
            var result = await _context.SaveChangesAsync();
            return result;
        }

        //////////////////////////////////////////////////////////////////////////////
    }
}
