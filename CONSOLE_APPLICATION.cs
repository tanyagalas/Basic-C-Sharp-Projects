using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Takes an input from the user, multiplies it by 50, then prints the result to the console.
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            int multipliedResult = number * 50;
            Console.WriteLine("Result after multiplying by 50: " + multipliedResult);

            // Takes an input from the user, adds 25 to it, then prints the result to the console.
            Console.WriteLine("Enter a number:");
            input = Console.ReadLine();
            number = Convert.ToInt32(input);
            int addedResult = number + 25;
            Console.WriteLine("Result after adding 25: " + addedResult);

            // Takes an input from the user, divides it by 12.5, then prints the result to the console.
            Console.WriteLine("Enter a number:");
            input = Console.ReadLine();
            double doubleNumber = Convert.ToDouble(input);
            double dividedResult = doubleNumber / 12.5;
            Console.WriteLine("Result after dividing by 12.5: " + dividedResult);

            // Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console.
            Console.WriteLine("Enter a number:");
            input = Console.ReadLine();
            number = Convert.ToInt32(input);
            bool isGreaterThan50 = number > 50;
            Console.WriteLine("Is the number greater than 50? " + isGreaterThan50);

            // Takes an input from the user, divides it by 7, then prints the remainder to the console.
            Console.WriteLine("Enter a number:");
            input = Console.ReadLine();
            number = Convert.ToInt32(input);
            int remainder = number % 7;
            Console.WriteLine("Remainder after dividing by 7: " + remainder);
        }
    }
}