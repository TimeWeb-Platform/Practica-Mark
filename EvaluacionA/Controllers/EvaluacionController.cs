using EvaluacionA.Evaluacion.Interface;
using EvaluacionA.Evaluacion.Service;
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

        [HttpGet]
        public async Task<ActionResult<string>> a(){
            var result = await evaluacion.asistencia(1,default(DateTime));
            if (result.Value < 0){
                return Unauthorized();
            }
            var text = "dias de asistencia : " + result.Value.ToString();
            return text;

        }

    }
}

