using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternTutorial
{
    public class Halo : XBoxGame
    {
        public Halo(string title) : base(title)
        {
        }

        public override XBoxGame Clone()
        {
            Console.WriteLine("Game prototype cloned.");
            return (Halo)this.MemberwiseClone();
        }
    }
}
