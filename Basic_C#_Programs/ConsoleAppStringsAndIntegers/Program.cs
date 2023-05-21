using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  ConsoleAppStringsandIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // List of integers
                List<int> numbersList = new List<int> { 10, 20, 30, 40, 50 };

                // Ask for a number to divide each number in the list
                Console.WriteLine("Enter a number to divide each number in the list:");

                // Read the user's input and convert it to an integer
                int divider = Convert.ToInt32(Console.ReadLine());

                // Loop through each number 
                for (int i = 0; i < numbersList.Count; i++)
                {
                    int result = numbersList[i] / divider;
                    Console.WriteLine(numbersList[i] + " divided by " + divider + " equals " + result);
                }
            }
            catch (DivideByZeroException)
            {
             
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (FormatException)
            {
             
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            finally
            {
             
                Console.WriteLine("Program execution continued after the try/catch block.");
            }

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}