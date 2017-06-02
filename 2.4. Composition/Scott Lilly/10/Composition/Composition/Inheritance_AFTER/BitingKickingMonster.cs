using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.Inheritance_AFTER
{
    public class BitingKickingMonster : KickingMonster
    {
        public int BiteDamage { get; set; }

        public BitingKickingMonster(
            int hitPoints, 
            int biteDamage, 
            int kickDamage) 
            : base(hitPoints, kickDamage)
        {
            BiteDamage = biteDamage;
        }
    }
}
