using ObserverPatternTutorial.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternTutorial.Subject
{
    class YouTubeChannel
    {
        private IList<ISubscriber> _subscribers = new List<ISubscriber>();
        public void Subscribe(ISubscriber s)
        {
            _subscribers.Add(s);
        }

        public void Unsubscribe(ISubscriber s)
        {
            _subscribers.Remove(s);
        }

        public void NotifySubscribers()
        {
            foreach( var s in _subscribers)
            {
                s.Notify();
            }
        }
    }
}
