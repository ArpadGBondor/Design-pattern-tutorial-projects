using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    // If Singleton wouldn't be sealed
    //public class DerivedSingleton : Singleton
    //{
    //    // Because Singleton's constructor is private:
    //    // Error CS0122	'Singleton.Singleton()' is inaccessible due to its protection level 
    //}

    // Sealed restricts the inheritance.
    public sealed class Singleton
    {

        // If Singleton wouldn't be sealed
        // public class NestedDerivedSingleton: Singleton { }
        // We are able to create multiple instances of the class.
        // This violates the principles of Singleton design pattern.

        private static int counter = 0;

        private static Singleton _instance = null;


        // Private constructor ensures that object is not instantiated 
        // other than within the class itself.
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value: " + counter.ToString());
        }

        // Public property id used to return only one instance of the class
        // levering on the private property
        public static Singleton GetInstance
        {
            get
            {
                if (_instance == null) _instance = new Singleton();
                return _instance;
            }
        }

        // Public method which can be invoked through the singleton instance
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
