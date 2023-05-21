using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of strings
        List<string> stringsList = new List<string>()
        {
            "apple",
            "banana",
            "orange",
            "kiwi",
            "grape"
        };

        // Ask the user to input text to search for
        Console.WriteLine("Enter text to search for:");
        string searchText = Console.ReadLine();

        // Initialize a variable to track if a match is found
        bool matchFound = false;

        // Iterate through the list and display the index of matching items
        for (int i = 0; i < stringsList.Count; i++)
        {
            if (stringsList[i].Contains(searchText))
            {
                Console.WriteLine("Match found at index: " + i);
                matchFound = true;
                break; // Stop the loop once a match is found
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