using System;
using IteratorPatternTutorialProject.Aggregate;
using IteratorPatternTutorialProject.Iterator;

namespace IteratorPatternTutorialProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ISocialNetworking fb = new Facebook();
            ISocialNetworking tw = new Twitter();

            IIterator fbIterator = fb.CreateIterator();
            IIterator twIterator = tw.CreateIterator();

            Console.WriteLine(" --- Facebook --- ");
            PrintUsers(fbIterator);
            Console.WriteLine(" --- Twitter --- ");
            PrintUsers(twIterator);

            Console.ReadLine();
        }
        public static void PrintUsers(IIterator iterate)
        {
            iterate.First();
            while (!iterate.IsDone())
            {
                Console.WriteLine(iterate.Next());
            }
        }
    }
}
