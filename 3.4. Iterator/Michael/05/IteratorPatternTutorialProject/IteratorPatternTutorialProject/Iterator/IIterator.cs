namespace IteratorPatternTutorialProject.Iterator
{
    public interface IIterator
    {
        void First(); // reset back to first element
        string Next(); // Get next
        bool IsDone(); // End of collection check
        string CurrentItem(); // Get current item
    }
}
