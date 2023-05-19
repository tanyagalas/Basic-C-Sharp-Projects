using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenates three strings
            string string1 = "I";
            string string2 = "like";
            string string3 = "programming.";

            string concatenatedString = string1 + " " + string2 + " " + string3;
            Console.WriteLine("Concatenated string: " + concatenatedString);
            Console.WriteLine();

            // Converts a string to uppercase
            string lowercaseString = "convert me to uppercase";
            string uppercaseString = lowercaseString.ToUpper();
            Console.WriteLine("Uppercase string: " + uppercaseString);
            Console.WriteLine();

            // Creates a StringBuilder and builds a paragraph of text, one sentence at a time
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Programming is an essential skill. ");
            stringBuilder.Append("It allows us to solve problems and create amazing things. ");
            stringBuilder.Append("Learning programming opens up a world of possibilities.");

            string paragraph = stringBuilder.ToString();
            Console.WriteLine("Paragraph: " + paragraph);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}




