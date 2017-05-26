﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger log = Logger.GetInstance;

            log.WriteToFile("Everything is awsome!");

            Console.ReadKey();
        }
    }
}
