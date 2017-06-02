using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.Inheritance_BEFORE
{
    public class Monster
    {
        public int HitPoints { get; set; }
        public int AttackDamage { get; set; }

        public Monster(int hitPoints, int attackDamage)
        {
            HitPoints = hitPoints;
            AttackDamage = attackDamage;
        }
    }
}
 