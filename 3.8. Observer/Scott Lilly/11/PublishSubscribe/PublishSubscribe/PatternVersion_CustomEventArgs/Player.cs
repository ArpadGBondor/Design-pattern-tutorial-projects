using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe.PatternVersion_CustomEventArgs
{
    public class Player
    {
        private int _hitPoints;
        private int _numberOfDeaths;

        public EventHandler<PlayerKilledEventArgs> PlayerKilled;

        public int HitPoints
        {
            get { return _hitPoints; }
            set
            {
                _hitPoints = value;

                if (_hitPoints <= 0)
                {
                    // Increase the "number of deaths" counter.
                    _numberOfDeaths++;

                    // When the player's HitPoint property is zero, or lower,
                    // the player object will raise a PlayerKilled notification 
                    // to all subscribed object

                    OnPlayerKilled();
                }
            }
        }

        private void OnPlayerKilled()
        {
            PlayerKilled?.Invoke(this, new PlayerKilledEventArgs(_numberOfDeaths));
        }
    }
}
