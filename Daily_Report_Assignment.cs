using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display the Titles
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            // Ask for a name and display
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);

            // Ask what course they taking and display
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Your course is: " + yourCourse);

            // Ask for  page number and display
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your page number is: " + pageNumber);

            // Ask if they need help and display true or false
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            var seekHelp = Console.ReadLine();
            bool needHelp = seekHelp == "true";
            bool noHelping = seekHelp == "false";

            //Ask about positive experiences and display back
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("You answered: " + positiveExperiences);

            // Ask about feedback and display 
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("You answered: " + otherFeedback);

            //Ask how many hours were studied and display
            Console.WriteLine("How many hours did you study today?");
            int courseTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You studied this many hours: " + courseTime);

            //End of program
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.Have a great day!");

            Console.ReadLine();

        }
    }
}



