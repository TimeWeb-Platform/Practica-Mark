using Eventos.DTO;
using Eventos.Evento.Interface;
using Eventos.Evento.Repostorie;
using Microsoft.AspNetCore.Mvc;

namespace Eventos.Evento.Service
{
    public class SEvento : IEvento
    {
        private readonly REvento _evento;

        public SEvento(REvento evento)
        {
            _evento = evento;
        }
        public Task<ActionResult<List<DTOEvento>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<DTOEvento>> GetID(int pID)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<int>> Post(DTOEventoC pDTOU)
        {
            throw new NotImplementedException();
        }
    }
}
