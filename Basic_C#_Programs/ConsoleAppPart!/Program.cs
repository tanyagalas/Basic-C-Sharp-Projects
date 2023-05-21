using System;

class Program
{
    static void Main()
    {
        // Create the array of strings
        string[] stringsArray = new string[5];

        // Ask the user to input some text
        Console.WriteLine("Enter some text:");
        string userInput = Console.ReadLine();

        // Iterate through the array and append the user's text to each string
        for (int i = 0; i < stringsArray.Length; i++)
        {
            stringsArray[i] += userInput;
        }

        // Print each string in the array
        Console.WriteLine("Updated array elements:");
        for (int i = 0; i < stringsArray.Length; i++)
        {
            Console.WriteLine(stringsArray[i]);
        }

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}