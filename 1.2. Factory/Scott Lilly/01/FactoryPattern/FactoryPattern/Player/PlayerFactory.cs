using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Player
{
    #region Second factory example

    public static class PlayerFactory
    {
        public static Player LoadPlayer()
        {
            return new Player(10, 0, 10);
        }
        #region Third factory example
        public static Player LoadPlayer2()
        {
            if (File.Exists("SaveGameData.xml"))
            {
                // For this demo, pretend that we read 
                // these values from the XML file
                int xmlHitPoints = 20;
                int xmlExperiencePoints = 123;
                int xmlGold = 56;

                return new Player(xmlHitPoints, xmlExperiencePoints, xmlGold);
            }
            else
            {
                return new Player(10, 0, 10);
            }
        }
        #endregion
    }
    #endregion
}
