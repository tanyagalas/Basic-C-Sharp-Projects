using NumberLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\tanya\Desktop\Basic-C-Sharp-Projects\Basic_C#_Programs";

            // Ask the user for a number
            string number = NumberInput.GetNumberFromUser();

            // Log the number to a text file
            NumberLogger.FileLogger logger = new FileLogger(filePath);
            logger.LogNumber(number);

            // Read and print the contents of the text file
            string fileContent = logger.ReadLogFile();
            Console.WriteLine("Contents of the log file:");
            Console.WriteLine(fileContent);

            // Wait for the user to press a key before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
