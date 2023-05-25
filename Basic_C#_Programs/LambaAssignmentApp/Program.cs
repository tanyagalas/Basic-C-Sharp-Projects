using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambaAssignmentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees
            List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
            new Employee { Id = 2, FirstName = "John", LastName = "Doe" },
            new Employee { Id = 3, FirstName = "Jane", LastName = "Johnson" },
            new Employee { Id = 4, FirstName = "Joe", LastName = "Williams" },
            new Employee { Id = 5, FirstName = "David", LastName = "Brown" },
            new Employee { Id = 6, FirstName = "Sarah", LastName = "Davis" },
            new Employee { Id = 7, FirstName = "Robert", LastName = "Jones" },
            new Employee { Id = 8, FirstName = "Michael", LastName = "Taylor" },
            new Employee { Id = 9, FirstName = "Joe", LastName = "Anderson" },
            new Employee { Id = 10, FirstName = "Emily", LastName = "Clark" }
        };

            Console.WriteLine("Using foreach loop:");
            List<Employee> joesList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joesList.Add(employee);
                }
            }
            foreach (Employee joe in joesList)
            {
                Console.WriteLine("Id: " + joe.Id + ", Name: " + joe.FirstName + " " + joe.LastName);
            }

            Console.WriteLine("\nUsing lambda expression:");
            List<Employee> joesListLambda = employees.FindAll(employee => employee.FirstName == "Joe");
            foreach (Employee joe in joesListLambda)
            {
                Console.WriteLine("Id: " + joe.Id + ", Name: " + joe.FirstName + " " + joe.LastName);
            }

            Console.WriteLine("\nUsing lambda expression to filter by Id:");
            List<Employee> idGreaterThan5List = employees.FindAll(employee => employee.Id > 5);
            foreach (Employee employee in idGreaterThan5List)
            {
                Console.WriteLine("Id: " + employee.Id + ", Name: " + employee.FirstName + " " + employee.LastName);
            }

            // Wait for the user to press a key before closing the console window
            Console.ReadKey();
        }
    }
}

