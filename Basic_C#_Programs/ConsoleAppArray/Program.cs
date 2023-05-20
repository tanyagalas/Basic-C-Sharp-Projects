using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of strings 
            string[] drinks = { "Coca-Cola", "Pepsi", "Sprite", "Mountain Dew" };
            Console.WriteLine("Enter an index number to choose your drink: ");
            int input = Convert.ToInt32(Console.ReadLine());

            // if statement if the index is out of range
            if (input < 0 || input >= drinks.Length)
            {
                Console.WriteLine("Please choose a number inside the valid range (0 - " + (drinks.Length - 1) + ").");
            }
            else
            {
                Console.WriteLine("The drink at index number " + input + " is " + drinks[input]);
            }
            Console.ReadLine();

            // Array of integers
            int[] intArray = { 30, 21, 24, 14 };
            Console.WriteLine("Pick an index number to get your number.");
            int input2 = Convert.ToInt32(Console.ReadLine());

            if (input2 < 0 || input2 >= intArray.Length)
            {
                Console.WriteLine("You have chosen an index number out of range. Choose a number between 0 and " + (intArray.Length - 1) + ".");
            }
            else
            {
                Console.WriteLine("The integer at index number " + input2 + " is " + intArray[input2]);
            }
            Console.ReadLine();

            // Create list of strings
            List<string> stringList = new List<string>() { "Oregon", "Washington", "Idaho" };
            Console.WriteLine("Enter an index number to get a state.");
            int input3 = Convert.ToInt32(Console.ReadLine());

            //if statement if the index is out of range
            if (input3 < 0 || input3 >= stringList.Count)
            {
                Console.WriteLine("You have picked a number that is out of range. Pick a number between 0 and " + (stringList.Count - 1) + ".");
            }
            else
            {
                Console.WriteLine("The state at index number " + input3 + " is " + stringList[input3]);
            }
            Console.ReadLine();
        }
    }
}