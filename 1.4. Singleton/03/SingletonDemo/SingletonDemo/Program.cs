using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("This is the first message");

            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("This is the second message");

            Console.WriteLine("----------------------------------------------");

            // If Singleton wouldn't be sealed
            //Singleton.NestedDerivedSingleton derivedObj = new Singleton.NestedDerivedSingleton();
            //derivedObj.PrintDetails("From nested derived class");

            //Output:
            //    Counter value: 1
            //    This is the first message
            //    This is the second message
            //    ----------------------------------------------
            //    Counter value: 2
            //    From nested derived class

            Console.ReadLine();
        }
    }
}
