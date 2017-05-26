using System.Collections.Generic;
using IteratorPatternTutorialProject.Iterator;

namespace IteratorPatternTutorialProject.Aggregate
{
    public class Facebook : ISocialNetworking
    {
        private LinkedList<string> _users;

        public Facebook()
        {
            // Sign up for a facebook account
            _users = new LinkedList<string>();
            _users.AddLast("Mike");
            _users.AddLast("Jason");
            _users.AddLast("Asad");
            _users.AddLast("Sen");
            _users.AddLast("Vish");
            _users.AddLast("Senthu");
        }

        public IIterator CreateIterator()
        {
            return new FacebookIterator(_users);
        }
    }
}
