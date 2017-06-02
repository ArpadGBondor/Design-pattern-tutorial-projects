﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe.PatternVersion_CustomEventArgs
{
    public class GameSession
    {
        public List<string> Messages { get; set; }
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        public GameSession()
        {
            Messages = new List<string>();

            CurrentPlayer = new Player { HitPoints = 10 };
            CurrentLocation = new Location { Atmosphere = Location.AtmosphereType.Normal };

            // "Subscribe" to the PlayerKilled event.

            // When the GameSession object recieves this notification
            // it will run the HandlePlayerKilled function.
            CurrentPlayer.PlayerKilled += HandlePlayerKilled;
        }

        public void MonsterAttackPlayer(int amountOfDamage)
        {
            CurrentPlayer.HitPoints -= amountOfDamage;
        }

        public void MoveToLocation(Location location)
        {
            CurrentLocation = location;

            if (CurrentLocation.Atmosphere == Location.AtmosphereType.Poisonous)
            {
                CurrentPlayer.HitPoints -= 1;
            }
        }

        private void HandlePlayerKilled(object sender, PlayerKilledEventArgs eventArgs)
        {
            Messages.Add("You were killed");
            Messages.Add($"This was death number: {eventArgs.NumberOfDeaths}");
        }
    }
}
