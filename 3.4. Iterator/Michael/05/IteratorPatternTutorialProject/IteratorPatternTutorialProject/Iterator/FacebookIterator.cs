using System.Collections.Generic;
using System.Linq;

namespace IteratorPatternTutorialProject.Iterator
{
    public class FacebookIterator : IIterator
    {
        private LinkedList<string> _users;
        private int _position;

        public FacebookIterator(LinkedList<string> users)
        {
            _users = users;
            _position = 0;
        }

        public string CurrentItem()
        {
            return _users.ElementAt(_position);
        }

        public void First()
        {
            _position = 0;
        }

        public bool IsDone()
        {
            return _position >= _users.Count;
        }

        public string Next()
        {
            return _users.ElementAt(_position++);
        }
    }
}
