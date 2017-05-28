using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatternTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza alp = new MeatLovePizza();
            Pizza vp = new VeggiePizza();

            alp.MakePizza();
            vp.MakePizza();

            Console.ReadLine();

        }
    }
}
