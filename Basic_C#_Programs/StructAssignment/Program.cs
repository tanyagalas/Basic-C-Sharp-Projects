using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of type Number and assign an amount to it
            Number number = new Number();
            number.Amount = 10.5m;

            // Print the amount to the console
            Console.WriteLine("Amount: " + number.Amount);

            Console.ReadLine();
        }
    }
}
   