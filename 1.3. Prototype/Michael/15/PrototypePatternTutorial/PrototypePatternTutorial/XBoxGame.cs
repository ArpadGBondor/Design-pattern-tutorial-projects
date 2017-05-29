using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PrototypePatternTutorial
{
    public abstract class XBoxGame
    {
        public string Title { get; set; }
        public string ProductKey { get; set; }
        public abstract XBoxGame Clone();
        public XBoxGame()
        {
            Thread.Sleep(2000); // The cost of the construction
        }

        public XBoxGame(string title)  
            : this()
        {
            Title = title;
            Console.WriteLine("New XBox game is created. Title: " + Title);
        }

        /// <summary>
        /// Returns a product key
        /// </summary>
        /// <returns></returns>
        public static string ProductKeyGeneration()
        {
            Random r = new Random();
            string productKey = "";
            for (int i = 0; i < 20; i++)
            {
                if (i % 5 == 0 && i != 0)
                {
                    productKey += "-";
                }
                productKey += (char)(r.Next(26) + 65);
            }
            return productKey;
        }
    }
}
