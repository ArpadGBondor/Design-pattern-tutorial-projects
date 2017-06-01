using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.PatternVersion
{
    public class AverageByMean : IAveragingMethod
    {
        public double AverageFor(List<double> values)
        {
            return values.Sum() / values.Count;
        }
    }
}
