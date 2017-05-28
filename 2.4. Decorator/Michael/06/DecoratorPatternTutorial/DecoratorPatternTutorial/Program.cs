using DecoratorPatternTutorial.Component;
using DecoratorPatternTutorial.ConcreteComponent;
using DecoratorPatternTutorial.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            IceCream iceCream = new Chocolate();

            iceCream = new Sprinkle(iceCream);
            iceCream = new Frudge(iceCream);

            Console.WriteLine(iceCream.Cost());

            Console.ReadLine();


        }
    }
}
