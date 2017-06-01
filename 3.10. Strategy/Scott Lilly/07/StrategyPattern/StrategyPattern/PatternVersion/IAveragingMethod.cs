using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.PatternVersion
{
    public interface IAveragingMethod
    {
        double AverageFor(List<double> values);
    }
}
