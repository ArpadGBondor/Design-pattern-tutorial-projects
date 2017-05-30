using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Player
{
    public class Player
    {
        #region Original code
        public int HitPoints { get; private set; }
        public int ExperiencePoints { get; private set; }
        public int Gold { get; private set; }

        //public Player(int hitPoints, int experiencePoints, int gold)
        //{
        //    HitPoints = hitPoints;
        //    ExperiencePoints = experiencePoints;
        //    Gold = gold;
        //}
        #endregion

        #region First factory example
        // Change the Constructor to private, so the Player class can only be 
        // instantiated through the CreateNewPlayer function
        //private Player(int hitPoints, int experiencePoints, int gold)
        //{
        //    HitPoints = hitPoints;
        //    ExperiencePoints = experiencePoints;
        //    Gold = gold;
        //}
        //public static Player CreateNewPlayer(int hitPoints, int experiencePoints, int gold)
        //{
        //    return new Player(hitPoints, experiencePoints, gold);
        //}
        #endregion
        #region Second factory example

        internal Player(int hitPoints, int experiencePoints, int gold)
        {
            HitPoints = hitPoints;
            ExperiencePoints = experiencePoints;
            Gold = gold;
        }

        // Add PlayerFactory class

        #endregion
    }


}
