using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWITCH_CHALLENGE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 5:");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            switch (number)
            {
                case 1:
                    Console.WriteLine("You entered 1");
                    break;
                case 2:
                    Console.WriteLine("You entered 2");
                    break;
                case 3:
                    Console.WriteLine("You entered 3");
                    break;
                case 4:
                    Console.WriteLine("You entered 4");
                    break;
                case 5:
                    Console.WriteLine("You entered 5");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
  