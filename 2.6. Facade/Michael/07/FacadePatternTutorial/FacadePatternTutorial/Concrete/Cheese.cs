using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternTutorial.Concrete
{
    public class Cheese
    {
        private string _name;
        public string Name { get { return _name; } }

        public Cheese(string name)
        {
            this._name = name;
            Console.WriteLine("Cheese: " + _name);
        }
    }
}
