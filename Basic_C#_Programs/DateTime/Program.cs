using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeassign
{
    class Program
    {

        static void Main(string[] args)

        {
            // Determine current time
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);

            // Ask the user for a number
            Console.WriteLine("Please enter a number: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            // Add the number of hours entered by the user to the current date and time,
            // and then display the result future date and time 
            Console.WriteLine("The time " + userNum + " hours from now is: " + dateTime.AddHours(userNum));

            Console.ReadLine();
        }
    }
}