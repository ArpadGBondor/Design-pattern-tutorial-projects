using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternTutorial.Observer
{
    public class User : ISubscriber
    {
        public void Notify()
        {
            Console.WriteLine("User has uploaded a new video!");
        }
    }
}
