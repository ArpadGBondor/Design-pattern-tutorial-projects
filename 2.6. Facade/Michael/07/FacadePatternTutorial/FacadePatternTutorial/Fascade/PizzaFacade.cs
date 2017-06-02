using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePatternTutorial.Concrete;

namespace FacadePatternTutorial.Fascade
{
    public class PizzaFacade
    {
        private Dough _dough;
        private Sauce _sauce;
        private Topping _topping;
        private Cheese _cheese;
        private Oven _oven;

        public PizzaFacade(
            string doughName,
            string sauceName,
            string toppingName,
            string cheeseName)
        {
            Console.WriteLine("Preparing ingredients.");
            _dough = new Dough(doughName);
            _sauce = new Sauce(sauceName);
            _topping = new Topping(toppingName);
            _cheese = new Cheese(cheeseName);
            _oven = new Oven();
            Console.WriteLine("");
        }
        public void MakePizza()
        {
            Console.WriteLine("Making pizza.");
            _dough.AddSauce(_sauce);
            _dough.AddCheese(_cheese);
            _dough.AddTopping(_topping);
            Console.WriteLine("");
            _oven.SetTemperature(425);
            _oven.SetTimer(20);
            _oven.Cook(_dough);
        }
    }
}
