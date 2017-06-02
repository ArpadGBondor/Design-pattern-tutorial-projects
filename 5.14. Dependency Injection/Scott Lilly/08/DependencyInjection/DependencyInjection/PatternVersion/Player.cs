using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.PatternVersion
{
    public class Player
    {
        public string Name { get; private set; }
        public int ExperiencePoints { get; private set; }
        public int Gold { get; private set; }

        public Player(string name, int experiencePoints, int gold)
        {
            Name = name;
            ExperiencePoints = experiencePoints;
            Gold = gold;
        }

        public static Player CreateNewPlayer(string name, IPlayerDataMapper playerDataMapper = null)
        {
            // If a PlayerDataMapper was not passed in, use a real one.
            // This allows us to pass in a "mock" PlayerDataMapper (for testing),
            // but use a real PlayerDataMapper, when running the program.
            if (null == playerDataMapper)
            {
                playerDataMapper = new PlayerDataMapper();
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Player name cannot be empty");
            }

            // Throw an exception if there is already a player with this name in the database.
            if (playerDataMapper.PlayerNameExistInDatabase(name))
            {
                throw new ArgumentException("Player name already exists.");
            }

            // Add the player to the database.
            playerDataMapper.InsertNewPlayerIntoDatabase(name);

            return new Player(name, 0, 10);
        }
    }
}
