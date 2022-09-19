using Microsoft.AspNetCore.Mvc;

namespace Evaluacion.Evaluacion.Interface
{
    public interface IEvaluacion
    {
        Task<ActionResult<string>> EvaluarAsistencia(int pID,DateTime pDate);
     }
}
