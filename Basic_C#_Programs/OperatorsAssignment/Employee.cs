using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Employee : Person, IQuittable
    {
        public int employeeID { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Hello, my name is {0} {1}", firstName, lastName);
        }

        public void Quit()
        {
            Console.WriteLine("This employee has quit");
            firstName = "";
            lastName = "";
        }

        public static bool operator ==(Employee one, Employee two)
        {
            if (one.employeeID == two.employeeID)
            {
                Console.WriteLine("The ID's are equal");
                return true;
            }
            else
            {
                Console.WriteLine("The ID's are not equal.");
                return false;
            }

        }

        public static bool operator !=(Employee one, Employee two)
        {
            if (one.employeeID == two.employeeID)
            {
                Console.WriteLine("The ID's are equal");
                return false;
            }
            else
            {
                Console.WriteLine("The ID's are not equal.");
                return true;
            }
        }
    }
}