namespace IteratorPatternTutorialProject.Iterator
{
    public class TwitterIterator : IIterator
    {
        private string[] _users;
        private int _position;

        public TwitterIterator(string[] users)
        {
            _users = users;
            _position = 0;
        }

        public string CurrentItem()
        {
            return _users[_position];
        }

        public void First()
        {
            _position = 0;
        }

        public bool IsDone()
        {
            return _position >= _users.Length;
        }

        public string Next()
        {
            return _users[_position++];
        }
    }
}
