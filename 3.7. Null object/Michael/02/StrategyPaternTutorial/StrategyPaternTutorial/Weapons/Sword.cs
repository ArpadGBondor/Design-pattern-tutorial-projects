using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPaternTutorial
{
    /// <summary>
    /// Concrete Strategy Sword
    /// </summary>
    public class Sword : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Using Sword");
        }
    }
}
