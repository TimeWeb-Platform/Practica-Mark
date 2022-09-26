using EvaluacionA.Objects;
using Microsoft.AspNetCore.Mvc;

namespace EvaluacionA.EvaluacionStrategy.Strategy
{
    public class STEvaluacionRS3 : IStrategyEvaluacion
    {
        public int DiasAsistidos(int pRS, List<OEvento> pDatesList)
        {
            var eventoval = pDatesList[0].FechaAlta;
            var ts = +new TimeSpan(9, 0, 0);
            eventoval = eventoval.Date + ts;
            var totalasistencias = 0;

            var eventofinval = eventoval.AddHours(9);

            for (int valor = 0; valor <(pDatesList.Count-1); valor++)
            {

                if (pDatesList[valor].FechaAlta   >= eventoval.AddMinutes(-10)    && pDatesList[valor].FechaAlta   <= eventoval.AddMinutes(10) &&
                    pDatesList[valor+1].FechaAlta >= eventofinval.AddMinutes(-10) && pDatesList[valor+1].FechaAlta <= eventofinval.AddMinutes(10))
                {
                    totalasistencias++;

                    eventoval = eventoval.AddDays(-1);
                    eventofinval = eventofinval.AddDays(-1);
                }

                eventoval = eventoval.AddDays(+1);
                eventofinval = eventofinval.AddDays(+1);

            }
            return totalasistencias;
        }


    }
}
