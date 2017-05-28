using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternTutorial
{
    public class Mouse
    {
        public void ConnectB()
        {
            Console.WriteLine("Sending signal to USB Adapter.");
        }
    }
}
