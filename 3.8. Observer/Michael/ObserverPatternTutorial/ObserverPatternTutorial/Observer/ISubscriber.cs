using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternTutorial.Observer
{
    interface ISubscriber
    {
        void Notify();
    }
}
