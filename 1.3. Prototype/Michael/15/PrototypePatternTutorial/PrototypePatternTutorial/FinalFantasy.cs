using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternTutorial
{
    class FinalFantasy : XBoxGame
    {
        public FinalFantasy(string title) : base(title)
        {
        }

        public override XBoxGame Clone()
        {
            Console.WriteLine("Game prototype cloned.");
            return (FinalFantasy)this.MemberwiseClone();
        }
    }
}
