using DecoratorPatternTutorial.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternTutorial.Decorator
{
    /// <summary>
    /// Decorator
    /// </summary>
    public abstract class Topping : IceCream
    {
        protected IceCream IceCream {get; set; }

        public Topping(IceCream s)
        {
            IceCream = s;
        }

        // public abstract override double Cost();
    }
}
