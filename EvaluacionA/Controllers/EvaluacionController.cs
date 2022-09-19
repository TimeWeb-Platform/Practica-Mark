using EvaluacionA.Evaluacion.Service;
using Microsoft.AspNetCore.Mvc;

namespace EvaluacionA.Controllers
{
    [ApiController]
    [Route("api/evaluacion")]
    public class EvaluacionController : ControllerBase
    {
        private readonly SEvaluacion evaluacion;

        public EvaluacionController(SEvaluacion evaluacion)
        {
            this.evaluacion = evaluacion;
        }

        [HttpGet]
        public async Task<ActionResult<int>> a(){
            var result = await evaluacion.vacio();
            return result;
        }

    }
}

