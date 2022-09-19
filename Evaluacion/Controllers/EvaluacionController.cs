using Evaluacion.Evaluacion.Service;
using Microsoft.AspNetCore.Mvc;

namespace Evaluacion.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class EvaluacionController : ControllerBase
    {
        private readonly SEvaluacion _evaluacion;

        public EvaluacionController(SEvaluacion evaluacion)
        {
            _evaluacion = evaluacion;
        }

        //// GET ////
        #region GET
        [HttpGet("{id:int}")]
        public async Task<ActionResult<string>> Asistencia(int id, [FromBody] DateTime date)
        {
            var result = await _evaluacion.EvaluarAsistencia(id, date);
            return Ok(result);
        }
        #endregion
    }
}
