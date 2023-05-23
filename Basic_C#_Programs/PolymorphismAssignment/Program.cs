using PolymorphismAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of type IQuitable using polymorphism
            IQuitable quitable = new Employee();

            // Call the Quit()
            quitable.Quit();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}


