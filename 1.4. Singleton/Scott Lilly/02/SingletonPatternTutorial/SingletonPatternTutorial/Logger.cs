using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternTutorial
{
    public sealed class Logger
    {
        // "volatile": The .NET ensures each thread gets the most recent
        //             updated version of this logger variable 
        // "Volatile" is not needed with .Net 2.0, or newer

        private static volatile Logger _logger;
        private static readonly object _syncLock = new object();

        // Make the constructor private, 
        // to force instantiation through the factory pattern
        private Logger()
        { }


        // *** DO NOT USE! ***
        // ** THIS EXAMPLE IS NOT THREAD-SAFE ***
        // *** ONLY SHOWN AS AN EXAMPLE OF WHAT NOT TO DO ***
        //public static Logger GetLogger()
        //{
        //    if (_logger == null)
        //        _logger = new Logger();
        //    return _logger;
        //}

        // THREAD-SAFE version
        public static Logger GetLogger()
        {
            if (_logger == null)
                lock(_syncLock)
                {
                    if (_logger == null)
                        _logger = new Logger();
                }
            return _logger;
        }

        // Pretend we're writing the message to a file here
        public void WriteMessage(string message)
        { }
    }
}
