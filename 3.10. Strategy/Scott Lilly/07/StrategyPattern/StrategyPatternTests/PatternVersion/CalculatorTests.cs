using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyPattern.PatternVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.PatternVersion.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private readonly List<double> _values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [TestMethod()]
        public void Test_AverageByMean()
        {
            Calculator calculator = new Calculator();

            var averageByMean = calculator.CalculateAverageFor(_values, new AverageByMean());

            Assert.IsTrue(ResultsAreCloseEnough(8.363636363,averageByMean));
        }

        [TestMethod()]
        public void Test_AverageByMedian()
        {
            Calculator calculator = new Calculator();

            var averageByMean = calculator.CalculateAverageFor(_values, new AverageByMedian());

            Assert.IsTrue(ResultsAreCloseEnough(8, averageByMean));
        }

        // Because we are using doubles (floating point values), the values may not exactly match.
        // If the difference between the expected result and the calculated result is less than 
        // .0000001, consider the two values as "equal".
        private bool ResultsAreCloseEnough(double expectedResult, double calculatedResult)
        {
            var difference = Math.Abs(expectedResult - calculatedResult);
            return difference < .0000001;
        }
    }
}