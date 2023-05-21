using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPart6
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

            // Create a HashSet 
            HashSet<string> uniqueStrings = new HashSet<string>();

            // Iterate through the list using foreach loop
            foreach (string item in stringsList)
            {
                // Check if the item is already present in the  set
                if (uniqueStrings.Contains(item))
                {
                    // Display a message 
                    Console.WriteLine($"String '{item}' has already appeared in the list.");
                }
                else
                {
                    // Add the string 
                    uniqueStrings.Add(item);

                    // Display a message indicating that the string is new to the list
                    Console.WriteLine($"New string found: '{item}'.");
                }
            }

            // Add an infinite loop
            while (true)
            {
                
                Console.WriteLine("Do you want to continue? (yes/no)");
                string input = Console.ReadLine();

                if (input.ToLower() != "yes")
                {
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
