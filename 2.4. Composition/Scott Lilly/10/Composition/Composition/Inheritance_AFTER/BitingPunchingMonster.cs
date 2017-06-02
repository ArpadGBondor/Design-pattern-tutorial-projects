using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.Inheritance_AFTER
{
    public class BitingPunchingMonster : PunchingMonster
    {
        public int BiteDamage { get; set; }

        public BitingPunchingMonster(
            int hitPoints, 
            int biteDamage, 
            int punchDamage) 
            : base(hitPoints, punchDamage)
        {
            BiteDamage = biteDamage;
        }
    }
}
