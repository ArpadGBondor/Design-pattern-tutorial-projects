using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternTutorial
{
    public abstract class EmployeeComponent
    {
        public string Name { private set; get; }

        public EmployeeComponent(string name)
        {
            Name = name;
        }

        public virtual void PrintSupervisorOf(int spacing)
        {
            for (int counter = 0; counter < spacing; counter++)
                Console.Write(" ");
            Console.WriteLine(Name);
        }
    }
}
