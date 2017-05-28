using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternTutorial
{
    class Program
    {
        // This is the Computer
        static void Main(string[] args)
        {
            USBAdapter usb = new USBAdapter();
            usb.ConnectA();
            Console.WriteLine("Got the signal.");

            Console.ReadKey();
        }
    }
}
