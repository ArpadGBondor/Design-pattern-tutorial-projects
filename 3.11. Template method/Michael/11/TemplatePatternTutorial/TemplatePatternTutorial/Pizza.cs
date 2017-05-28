using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatternTutorial
{
    public abstract class Pizza
    {
        // Template method
        public void MakePizza()
        {
            MakeDough();
            AddTomatoeSauce();
            AddCheese();
            AddToppings();
        }

        protected abstract void AddToppings();

        private void AddCheese()
        {
            Console.WriteLine("Adding cheese");
        }

        private void AddTomatoeSauce()
        {
            Console.WriteLine("Adding tomatoe sauce");
        }

        private void MakeDough()
        {
            Console.WriteLine("Worked the dough");
        }

    }
}
