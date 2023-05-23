using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an Employee object
            Employee employee1 = new Employee();

            // Set the properties of the employee object
            employee1.FirstName = "James";
            employee1.LastName = "Johnson";

            // Call the sayName method on the employee object
            employee1.sayName();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}