using DecoratorPatternTutorial.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPatternTutorial.Component;

namespace DecoratorPatternTutorial.ConcreteDecorator
{
    /// <summary>
    /// Concrete decorator
    /// </summary>
    public class Sprinkle : Topping
    {
        public Sprinkle(IceCream s) : base(s)
        {
        }

        public override double Cost()
        {
            return 0.50 + IceCream.Cost();
        }
    }
}
