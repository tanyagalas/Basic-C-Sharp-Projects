using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodsubmissionassign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompts the user to input an integer
            Console.WriteLine("Please input an integer: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            // Prompts the user to input a second integer
            Console.WriteLine("Please input a second integer (optional): ");
            bool userNum2IsValid = int.TryParse(Console.ReadLine(), out int userNum2);

            Math myNum = new Math();

            int result = 0;
            if (userNum2IsValid)
            {
                result = myNum.AddInts(userNum, userNum2);
            }
            else
            {
                result = myNum.AddInts(userNum);
            }

            // Prints the result to the console
            Console.WriteLine("Your result is: " + result);
            Console.ReadLine();
        }
    }
}