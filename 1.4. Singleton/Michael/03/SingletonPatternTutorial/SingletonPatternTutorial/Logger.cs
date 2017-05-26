using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternTutorial
{
    class /* sealed */ Logger
    {
        private static Logger _logger;
        private Logger(){ }

        public static Logger GetInstance
        {
            get
            {
                // Yoda expression: (constant is on the left side)
                if (null == _logger) _logger = new Logger();
                return _logger;
            }
        }

        public void WriteToFile(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
