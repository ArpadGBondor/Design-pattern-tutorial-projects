using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PrototypePatternTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Without Prototype Pattern:");            
            //XBoxGame haloPrototype = new Halo("Halo 4") { ProductKey = "00000-0000-0000-0000" }; // ORIGINAL COPY OF HALO
            XBoxGame gameCopy;

            for (int x = 0; x < 10; x++)
            {
                Thread.Sleep(200);
                //gameCopy = haloPrototype.Clone();
                gameCopy = new Halo("Halo 4");
                gameCopy.ProductKey = XBoxGame.ProductKeyGeneration();
                Console.WriteLine("Game Title: {0} Product Key: {1}", gameCopy.Title, gameCopy.ProductKey);
            }

            Console.WriteLine("With Prototype Pattern:");            
            XBoxGame ffPrototype = new FinalFantasy("Final Fantasy X") { ProductKey = "00000-0000-0000-0000" }; // ORIGINAL COPY OF HALO

            for (int x = 0; x < 10; x++)
            {
                Thread.Sleep(200);
                gameCopy = ffPrototype.Clone();
                //gameCopy = new FinalFantasy("Final Fantasy X");
                gameCopy.ProductKey = XBoxGame.ProductKeyGeneration();
                Console.WriteLine("Game Title: {0} Product Key: {1}", gameCopy.Title, gameCopy.ProductKey);
            }

            Console.ReadKey();
        }
    }
}
