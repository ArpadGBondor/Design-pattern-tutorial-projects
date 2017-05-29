using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeComposit mark = new EmployeeComposit("Mark");
            Employee catherine = new Employee("Catherine");
            Employee david = new Employee("David");

            EmployeeComposit kathy = new EmployeeComposit("Kathy");
            EmployeeComposit mike = new EmployeeComposit("Mike");
            Employee gage = new Employee("Gage");
            Employee reg = new Employee("Reggie");

            EmployeeComposit lori = new EmployeeComposit("Lori");
            lori.AddEmployee(mark);
            lori.AddEmployee(kathy);

            mark.AddEmployee(catherine);
            mark.AddEmployee(david);

            kathy.AddEmployee(mike);

            mike.AddEmployee(gage);
            mike.AddEmployee(reg);

            lori.PrintSupervisorOf(0);
            Console.WriteLine("----------");

            kathy.PrintSupervisorOf(0);
            Console.WriteLine("----------");

            mark.PrintSupervisorOf(0);
            Console.WriteLine("----------");

            Console.ReadLine();
        }
    }
}
