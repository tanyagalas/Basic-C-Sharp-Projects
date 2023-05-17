using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print to the screen
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            // Print Person 1 and get the hourly rate and hours worked per week
            Console.WriteLine("Person 1");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate?");
            string p1HourlyRate = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string p1HoursWorked = Console.ReadLine();

            // Print Person 2 and get the hourly rate and hours worked per week
            Console.WriteLine("Person 2");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate?");
            string p2HourlyRate = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string p2HoursWorked = Console.ReadLine();

            //Print Annual salary of Person 1 and display 
            int p1WeekRate = Convert.ToInt32(p1HourlyRate);
            int p1WeekHours = Convert.ToInt32(p1HoursWorked);
            int p1Weekly = p1WeekRate * p1WeekHours;
            int p1Annual = p1Weekly * 52;
            Console.WriteLine("Annual salary of Person 1: " + p1Annual);
            Console.ReadLine();

            //Print Annual salary of Person 2 and display 
            int p2WeekRate = Convert.ToInt32(p2HourlyRate);
            int p2WeekHours = Convert.ToInt32(p2HoursWorked);
            int p2Weekly = p2WeekRate * p2WeekHours;
            int p2Annual = p2Weekly * 52;
            Console.WriteLine("Annual salary of Person 2: " + p2Annual);
            Console.ReadLine();

            //Print True or False if Person 1 makes more than Person 2
            bool compAnnual = p1Annual > p2Annual;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(compAnnual);
            Console.ReadLine();
        }
    }
}