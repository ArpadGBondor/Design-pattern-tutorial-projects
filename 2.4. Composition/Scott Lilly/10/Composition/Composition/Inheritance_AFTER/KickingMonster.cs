using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.Inheritance_AFTER
{
    public class KickingMonster : Monster
    {
        public int KickDamage { get; set; }
        public KickingMonster(
            int hitPoints,
            int kickDamage)
            : base(hitPoints)
        {
            KickDamage = kickDamage;
        }
    }
}
