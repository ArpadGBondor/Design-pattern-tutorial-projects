﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.NonPatternVersion
{
    public class Monster
    {
        public string Name { get; private set; }
        public int HitPoints { get; private set; }

        public Monster (string name, int hitPoints)
        {
            Name = name;
            HitPoints = hitPoints;
        }

        public void ApplyDamage(int amountOfDamage)
        {
            HitPoints -= amountOfDamage;
        }
    }
}
