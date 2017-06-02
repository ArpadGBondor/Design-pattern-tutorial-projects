using FacadePatternTutorial.Concrete;
using FacadePatternTutorial.Fascade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternTutorial
{
    class Program
    {
        // Client
        static void Main(string[] args)
        {
            //Dough dough = new Dough();
            //Sauce sauce = new Sauce("Tomatoe");
            //Topping mushroom = new Topping("Mushrooms");
            //Cheese mozzarella = new Cheese("Mozzarella");
            //Oven oven = new Oven();

            //dough.AddSauce(sauce);
            //dough.AddCheese(mozzarella);
            //dough.AddTopping(mushroom);
            //oven.SetTemperature(425);
            //oven.SetTimer(20);
            //oven.Cook(dough);

            Client1();

            Client2();

            Console.ReadLine();
        }

        public static void Client1()
        {
            Console.WriteLine(" --- Client1's Pizza --- ");
            PizzaFacade pf = 
                new PizzaFacade(
                    "Normal dough",
                    "Tomatoe sauce",
                    "Mushrooms",
                    "Mozzarella");
            pf.MakePizza();
        }

        public static void Client2()
        {
            Console.WriteLine(" --- Client2's Pizza --- ");
            PizzaFacade pf =
                new PizzaFacade(
                    "Normal dough",
                    "Tomatoe sauce",
                    "Green peppers",
                    "Mozzarella");
            pf.MakePizza();
        }
    }
}
