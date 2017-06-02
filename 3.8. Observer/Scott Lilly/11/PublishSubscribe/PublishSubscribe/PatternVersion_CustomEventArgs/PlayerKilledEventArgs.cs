using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe.PatternVersion_CustomEventArgs
{
    public class PlayerKilledEventArgs : EventArgs
    {
        public int NumberOfDeaths { get; set; }

        public PlayerKilledEventArgs(int numberOfDeath)
        {
            NumberOfDeaths = numberOfDeath;
        }
    }
}
