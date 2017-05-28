using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternTutorial.Concrete
{
    public class Dough
    {
        private string _name;
        private Sauce _sauce;
        private Cheese _cheese;
        private Topping _topping;

        public string Name { get { return _name; } }
        public Sauce Sauce { get { return _sauce; } }
        public Cheese Cheese { get { return _cheese; } }
        public Topping Topping { get { return _topping; } }

        public Dough(string name)
        {
            _name = name;
            Console.WriteLine("Dough: " + _name);
        }

        internal void AddSauce(Sauce sauce)
        {
            _sauce = sauce;
        }

        internal void AddCheese(Cheese cheese)
        {
            _cheese = cheese;
        }

        internal void AddTopping(Topping topping)
        {
            _topping = topping;
        }
    }
}
