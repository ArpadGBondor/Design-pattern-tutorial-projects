using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.Inheritance_AFTER
{
    public class MonsterFactory
    {
        public enum MonsterType
        {
            Horse,      // BitingKickingMonster
            Orc,        // BitingKickingPunchingMonster
            Crocodile,  // BitingMonster
            MikeTyson,  // BitingPunchingMonster
            Camel,      // KickingMonster
            Kangaroo,   // KickingPunchingMonster
            MantisShrip // PunchingMonster 
        }

        public static Monster CreateMonster(MonsterType monsterType)
        {
            switch(monsterType)
            {
                case MonsterType.Horse:
                    return new BitingKickingMonster(10, 5, 5);
                case MonsterType.Orc:
                    return new BitingKickingPunchingMonster(10, 5, 5, 5);
                case MonsterType.Crocodile:
                    return new BitingMonster(10, 5);
                case MonsterType.MikeTyson:
                    return new BitingPunchingMonster(10, 5, 5);
                case MonsterType.Camel:
                    return new KickingMonster(10, 5);
                case MonsterType.Kangaroo:
                    return new KickingPunchingMonster(10, 5, 5);
                case MonsterType.MantisShrip:
                    return new PunchingMonster(10, 5);
                default:
                    throw new ArgumentException();
            }
        }

    }
}
