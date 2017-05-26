using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternTutorial.Observer
{

    public class Moderator : ISubscriber
    {
        public void Notify()
        {
            Console.WriteLine("Moderator needs to review new video!");
        }
    }

}
