using EvaluacionA.Objects;
using Microsoft.AspNetCore.Mvc;

namespace EvaluacionA.EvaluacionStrategy
{
    public interface IStrategyEvaluacion
    {
        int DiasAsistidos(int pRS, List<OEvento> pDatesList);
    }
}
