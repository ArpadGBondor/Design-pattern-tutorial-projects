using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static int counter = 0;

        private static Singleton _instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (_instance == null) _instance = new Singleton();
                return _instance;
            }
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value: " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
