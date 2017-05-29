using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternTutorial
{
    public class Employee : EmployeeComponent
    {
        public Employee(string name) : base(name)
        {
        }

        public override void PrintSupervisorOf(int spacing)
        {
            base.PrintSupervisorOf(spacing);
        }
    }
}
