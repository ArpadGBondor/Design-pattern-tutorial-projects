using DecoratorPatternTutorial.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternTutorial.ConcreteComponent
{
    /// <summary>
    /// Concrete component
    /// </summary>
    public class Chocolate : IceCream
    {
        public override double Cost()
        {
            return 1.50;
        }
    }
}
