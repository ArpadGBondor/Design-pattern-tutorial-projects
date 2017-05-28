using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternTutorial.Concrete
{
    public class Sauce
    {
        private string _name;
        public string Name { get { return _name; } }

        public Sauce(string name)
        {
            this._name = name;
            Console.WriteLine("Sauce: " + _name);
        }
    }
}
