using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FacadePatternTutorial.Concrete
{
    public class Oven
    {
        private int _time;

        internal void SetTemperature(int v)
        {
        }

        internal void SetTimer(int time)
        {
            _time = time;
        }

        internal void Cook(Dough dough)
        {
            // Make pizza
            Console.WriteLine("Cooking pizza.");
            Thread.Sleep(_time * 100);
            Console.WriteLine("================");
            Console.WriteLine("Pizza is ready!");
            Console.WriteLine("Dough: " + dough.Name);
            Console.WriteLine("Sauce: " + dough.Sauce.Name);
            Console.WriteLine("Topping: " + dough.Topping.Name);
            Console.WriteLine("Cheese: " + dough.Cheese.Name);
            Console.WriteLine("================");
            Console.WriteLine("");
        }
    }
}
