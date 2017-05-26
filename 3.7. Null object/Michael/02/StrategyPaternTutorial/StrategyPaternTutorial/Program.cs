using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPaternTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeapon weapon = null;
            Character Red = new Character();

            while (true)
            {
                Console.WriteLine("Choose a weapon for Red! (1 = Sword, 2 = Axe, 3 = Club)");
                String input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        weapon = new Sword();
                        break;
                    case "2":
                        weapon = new Axe();
                        break;
                    case "3":
                        weapon = new Club();
                        break;
                    default: 
                        // Without the Null object, NullException occurs
                        weapon = new Null();
                        break;
                }
                Red.SetWeapon(weapon);
                Red.Attack();
            }
        }
    }
}
