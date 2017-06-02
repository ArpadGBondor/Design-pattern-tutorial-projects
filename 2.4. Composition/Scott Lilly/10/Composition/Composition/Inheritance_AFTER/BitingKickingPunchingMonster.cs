using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.Inheritance_AFTER
{
    public class BitingKickingPunchingMonster : PunchingMonster
    {
        public int BiteDamage { get; set; }
        public int KickDamage { get; set; }

        public BitingKickingPunchingMonster(
            int hitPoints, 
            int biteDamage,
            int kickDamage,
            int punchDamage) 
            : base(hitPoints, punchDamage)
        {
            BiteDamage = biteDamage;
            KickDamage = kickDamage;
        }
    }
}
