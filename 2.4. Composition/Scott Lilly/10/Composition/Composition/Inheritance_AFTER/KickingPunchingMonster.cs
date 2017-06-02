using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.Inheritance_AFTER
{
    public class KickingPunchingMonster : PunchingMonster
    {
        public int KickDamage { get; set; }
        public KickingPunchingMonster(
            int hitPoints,
            int kickDamage,
            int punchDamage)
            : base(hitPoints, punchDamage)
        {
            KickDamage = kickDamage;
        }
    }
}
