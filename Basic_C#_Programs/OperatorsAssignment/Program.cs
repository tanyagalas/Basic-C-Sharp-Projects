using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Employee employee2 = new Employee();
            employee2.firstName = "Aaron";
            employee2.lastName = "Sampson";
            employee2.employeeID = 3456;

            Employee employee3 = new Employee();
            employee3.firstName = "James";
            employee3.lastName = "Davis";
            employee3.employeeID = 7898;

            bool doesEqual = employee2 == employee3; 

            Console.ReadLine();
        }
    }
}