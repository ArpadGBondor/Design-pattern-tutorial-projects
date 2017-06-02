using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.Inheritance_AFTER
{
    public class Monster
    {
        public int HitPoints { get; set; }

        public Monster(int hitPoints)
        {
            HitPoints = hitPoints;
        }
    }
}
