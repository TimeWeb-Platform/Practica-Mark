using Microsoft.AspNetCore.Mvc;

namespace EvaluacionA.Evaluacion.Interface
{
    public interface IEvaluacion
    {
        Task<ActionResult<int>> vacio();
        Task<ActionResult<int>> asistencia(int pID, DateTime pDateS);
    }
}
