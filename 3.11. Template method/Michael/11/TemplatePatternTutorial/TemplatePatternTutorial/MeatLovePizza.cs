using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatternTutorial
{
    public class MeatLovePizza : Pizza
    {
        // Template method
        //public void MakePizza()
        //{
        //    MakeDough();
        //    AddTomatoeSauce();
        //    AddCheese();
        //    AddToppings();
        //}

        protected override void AddToppings()
        {
            Console.WriteLine("Adding beacon, chicken, steak...");
        }

        //private void AddCheese()
        //{
        //    Console.WriteLine("Adding cheese");
        //}

        //private void AddTomatoeSauce()
        //{
        //    Console.WriteLine("Adding tomatoe sauce");
        //}

        //private void MakeDough()
        //{
        //    Console.WriteLine("Worked the dough");
        //}
    }
}
