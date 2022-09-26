using EvaluacionA.Evaluacion.Interface;
using EvaluacionA.Evaluacion.Service;
using EvaluacionA.Objects;
using Microsoft.AspNetCore.Mvc;

namespace EvaluacionA.Controllers
{
    [ApiController]
    [Route("api/evaluacion")]
    public class EvaluacionController : ControllerBase
    {
        private readonly IEvaluacion evaluacion;

        public EvaluacionController(IEvaluacion evaluacion)
        {
            this.evaluacion = evaluacion;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<string>> evaluardias(DateTime date, int id){
            var result = await evaluacion.asistencia(id,date);
            if (result.Value < 0){
                return Unauthorized("Accion no implementada");
            }

            var text = "dias de asistencia : " + result.Value.ToString();
            return text;

        }

    }
}

