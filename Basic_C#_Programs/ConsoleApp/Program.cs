using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boolean comparison using a while statement
            Console.WriteLine("Boolean comparison using a while statement:");
            int whileCount = 0; 

            while (whileCount < 5) // Execute the following block as long as whileCount is less than 5
            {
                Console.WriteLine("While count: " + whileCount); // Print the current value of whileCount
                whileCount++; 
            }

            Console.WriteLine();

            // Boolean comparison using a dowhile statement
            Console.WriteLine("Boolean comparison using a do-while statement:");
            int doWhileCount = 0;

            do
            {
                Console.WriteLine("Do-While count: " + doWhileCount); // Print the current value of doWhileCount
                doWhileCount++; 
            }
            while (doWhileCount < 5); // Execute the following block as long as doWhileCount is less than 5

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}