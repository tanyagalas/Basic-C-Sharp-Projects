using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Employee class
            Employee employee = new Employee(12345)
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Use the SayName() method of the Person superclass to display the employee's name
            employee.SayName();

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}