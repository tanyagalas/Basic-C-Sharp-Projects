using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPart5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of strings with at least two identical strings
            List<string> stringsList = new List<string>()
        {
            "apple",
            "banana",
            "orange",
            "kiwi",
            "banana",
            "grape"
        };

            // Ask the user to select text to search for
            Console.WriteLine("Enter text to search for:");
            string searchText = Console.ReadLine();

            // Initialize a variable to track if any matches are found
            bool matchFound = false;

            // Iterate through the list and display the indices of matching items
            Console.WriteLine("Indices of matching items:");
            for (int i = 0; i < stringsList.Count; i++)
            {
                if (stringsList[i] == searchText)
                {
                    Console.WriteLine(i);
                    matchFound = true;
                }
            }

            // Check if the user's input is not on the list
            if (!matchFound)
            {
                Console.WriteLine("Your input is not on the list.");
            }

            // Add an infinite loop
            while (true)
            {
                // Perform actions within the loop

                // Break the loop conditionally
                Console.WriteLine("Do you want to continue? (yes/no)");
                string input = Console.ReadLine();

                if (input.ToLower() != "yes")
                {
                    break;
                }
            }

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}

