using EvaluacionA.Objects;
using Microsoft.AspNetCore.Mvc;

namespace EvaluacionA.EvaluacionStrategy.Strategy
{
    public class STEvaluacionRS1 : IStrategyEvaluacion
    {
        public int DiasAsistidos(int pRS, List<OEvento> pDatesList)
        {

            var eventoval = pDatesList[0].FechaAlta;
            var totalasistencias = 0;
            eventoval = eventoval.Date;
        
            foreach (OEvento even in pDatesList)
            {
                if (even.FechaAlta.Date == eventoval){
                    totalasistencias++;
                    eventoval = eventoval.AddDays(+1);
                }
            }
        
            return totalasistencias;
        }


    }
}
