using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FactoryPattern.Monster
{
    public static class MonsterFactory
    {
        private static Random r = new Random();
        public static Monster GetRandomMonster()
        {
            int randomNumber = r.Next(3);
            switch(randomNumber)
            {
                case 0:
                    return new FlyingMonster();
                case 1:
                    return new LandMonster();
                default:
                    return new SeaMonster();

                    // If we ever want to create a SpaceMonster, we just have to create 
                    // the class, inherit from Monster, and extend the Factory method to use it.
            }
        }
    }
}
