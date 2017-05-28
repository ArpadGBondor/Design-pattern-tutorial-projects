using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternTutorial
{
    public class USBAdapter
    {
        Mouse mouse = new Mouse();
        public void ConnectA()
        {
            mouse.ConnectB();
            Console.WriteLine("Converting signal to USB.");
            Console.WriteLine("Sending new converted signals to Computer.");
        }
    }
}
