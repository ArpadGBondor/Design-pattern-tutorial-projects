using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe.PatternVersion
{
    public class Player
    {
        private int _hitPoints;

        public EventHandler PlayerKilled;

        public int HitPoints
        {
            get { return _hitPoints; }
            set
            {
                _hitPoints = value;

                if (_hitPoints <= 0) 
                {
                    // When the player's HitPoint property is zero, or lower,
                    // the player object will raise a PlayerKilled notification 
                    // to all subscribed object

                    OnPlayerKilled();

                }
            }
        }

        private void OnPlayerKilled()
        {
            PlayerKilled?.Invoke(this, EventArgs.Empty);
        }
    }
}
