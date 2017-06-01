using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.PatternVersion
{
    public class Calculator
    {
        public double CalculateAverageFor(List<double> values, IAveragingMethod averagingMethod)
        {
            return averagingMethod.AverageFor(values);
        }

    }
}
