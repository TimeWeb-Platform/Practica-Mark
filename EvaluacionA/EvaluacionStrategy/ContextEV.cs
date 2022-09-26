using EvaluacionA.Objects;
using Microsoft.AspNetCore.Mvc;

namespace EvaluacionA.EvaluacionStrategy
{
    public class ContextEV
    {
        private IStrategyEvaluacion _strategy;

        public ContextEV()
        {}

        public ContextEV(IStrategyEvaluacion strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategyEvaluacion strategy){
            this._strategy = strategy;
        }

        public int Ejecta(int pRS, List<OEvento> pDatesList)
        {
            var result = this._strategy.DiasAsistidos(pRS,pDatesList);
            return result;
        }

    }
}
