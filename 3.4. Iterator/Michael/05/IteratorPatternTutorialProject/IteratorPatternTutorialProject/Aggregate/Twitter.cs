using IteratorPatternTutorialProject.Iterator;

namespace IteratorPatternTutorialProject.Aggregate
{
    class Twitter : ISocialNetworking
    {
        private string[] _users;

        public Twitter()
        {
            _users = new[] { "Kathy", "Lori", "Kristen", "Jamie" };
        }

        public IIterator CreateIterator()
        {
            return new TwitterIterator(_users);
        }
    }
}
