using Eventos.DTO;
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
        [HttpGet("dates/{id:int}")]
        public async Task<ActionResult<List<DTOEvento>>> todos(int id, [FromBody] DateTime date)
        {
            var result = await _evento.GETDates(id,date);
            return result;
        }
         
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

            switch(result){
                case 1:
                    return Ok();
                case 0:     
                    return BadRequest("no fue posible registrar el evento");
                default:    
                    return BadRequest("no fue posible hacer la accion");
            }
        }
        #endregion


////////////////////////////////////////////////////////////////////////
    }
}
