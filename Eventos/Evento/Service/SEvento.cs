using AutoMapper;
using Eventos.Domain;
using Eventos.DTO;
using Eventos.Evento.Interface;
using Eventos.Evento.Repostorie;
using Microsoft.AspNetCore.Mvc;

namespace Eventos.Evento.Service
{
    public class SEvento : IEvento
    {
        private readonly REvento _evento;
        private readonly IMapper _mapper;

        public SEvento(REvento evento, IMapper mapper)
        {
            _evento = evento;
            _mapper = mapper;
        }
        #region GET
        public async Task<ActionResult<List<DTOEvento>>> GetAll()
        {
            var eventos = await _evento.GetAll();
            var result = _mapper.Map<List<DTOEvento>>(eventos);
            return result;
        }

        public async Task<ActionResult<List<DTOEvento>>> GETDates(int pID, DateTime pDateS, DateTime pDateF)
        {
            var eventos = await _evento.GetDates(pID, pDateS, pDateF);
            var result  = _mapper.Map<List<DTOEvento>>(eventos);
            return result;
        }

        public async Task<ActionResult<DTOEvento>> GetID(int pID)
        {
            var eventos = await _evento.GetID(pID);
            var result = _mapper.Map<DTOEvento>(eventos);
            return result;

        }
        #endregion
        
        #region POST
        public async Task<ActionResult<int>> Post(DTOEventoC pDTOE)
        {
            var eventos = _mapper.Map<OEvento>(pDTOE);
            var action = _evento.Post(eventos);
            var result = await action;

            if (result > 0) { return 1; }
            ////////////////////////////
            return 0;
        }
        #endregion

//////////////////////////////////////////
    }
}
