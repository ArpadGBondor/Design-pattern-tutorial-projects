using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.Inheritance_AFTER
{
    public class PunchingMonster : Monster
    {
        public int PunchDamage { get; set; }
        public PunchingMonster(
            int hitPoints, 
            int punchDamage)
            : base(hitPoints)
        {
            PunchDamage = punchDamage;
        }
    }
}
