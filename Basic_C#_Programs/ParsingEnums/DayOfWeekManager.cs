using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    public static class DayOfWeekManager
    {
        public static void Run()
        {
            try
            {
                // Prompt the user to enter the current day of the week
                Console.Write("Enter the current day of the week: ");
                string userInput = Console.ReadLine();

                // Convert the user input into an enum value and store it in a variable
                DayOfWeekEnum currentDay;
                if (Enum.TryParse(userInput, out currentDay))
                {
                 
                 // User input successfully parsed
                    Console.WriteLine("You entered: " + currentDay);
                }
                else
                {
                 // User input could not be parsed
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
            catch (Exception ex)
            {
                    Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}