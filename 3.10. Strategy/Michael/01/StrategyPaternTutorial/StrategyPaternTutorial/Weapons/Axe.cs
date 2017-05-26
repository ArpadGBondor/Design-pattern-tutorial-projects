using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPaternTutorial
{
    /// <summary>
    /// Concrete Strategy Axe
    /// </summary>
    public class Axe : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Using Axe");
        }
    }
}
