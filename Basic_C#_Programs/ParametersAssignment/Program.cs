using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string> { "Apple", "Banana", "Orange" };

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int> { 10, 20, 30, 40, 50 };

            Console.WriteLine("Employee 1 Things:");
            foreach (string item in employee1.Things)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Employee 2 Things:");
            foreach (int item in employee2.Things)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
  