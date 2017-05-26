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

            Console.ReadLine();
        }
    }
}
