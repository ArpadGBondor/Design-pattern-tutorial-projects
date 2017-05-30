using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternTutorial
{
    public sealed class Logger2
    {
        // This is called the static initializer method in C#
        private static readonly Logger2 _logger = new Logger2();
        private Logger2() { }

        public static Logger2 GetLogger()
        {
            return _logger;
        }

        // Pretend we're writing the message to a file here
        public void WriteMessage(string message)
        { }
    }
}
