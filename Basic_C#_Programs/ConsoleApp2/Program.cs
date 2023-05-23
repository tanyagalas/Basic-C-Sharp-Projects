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
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            Class1 myClass = new Class1();

            // Call the method that divides
            int result = myClass.DivideByTwo(number);
            Console.WriteLine("Result of division: " + result);

            // Call the method with output parameters
            int outputParam1, outputParam2;
            myClass.MethodWithOutputParams(out outputParam1, out outputParam2);
            Console.WriteLine("Output parameter 1: " + outputParam1);
            Console.WriteLine("Output parameter 2: " + outputParam2);

            // Call the overloaded method
            int overloadResult = myClass.MethodOverload(number);
            Console.WriteLine("Overloaded method result: " + overloadResult);

            Console.ReadLine();
        }
    }
}