﻿using Eventos.DTO;
using Eventos.Evento.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Eventos.Controllers
{
    [ApiController]
    [Route("api/evento")]
    public class EventoController : ControllerBase
    {
        private readonly IEvento _evento;


        public EventoController(IEvento evento)
        {
            this._evento = evento;
        }


        //// GET ////
        #region GET
        [HttpGet]
        public async Task<ActionResult<List<DTOEvento>>> GetAll()
        {
            var result = await _evento.GetAll();
            return result;
        }

        [HttpGet("{id:int}", Name = "GetEvento")]
        public async Task<ActionResult<DTOEvento>> GetID(int id)
        {
            var result = await _evento.GetID(id);
            return result;
        }

        #endregion

        //// POST ////
        #region POST
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DTOEventoC pDTOU)
        {
            var action = await _evento.Post(pDTOU);
            var result = action.Value;

            if (result > 0) { return Ok(); }
            //////////////////////////////////////////
            return BadRequest("no fue posible hacer la accion");
        }
        #endregion

////////////////////////////////////////////////////////////////////////
    }
}