using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask applicant what your age is?
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageInt = Convert.ToInt32(age);

            // Ask applicant if they ever had a DUI
            Console.WriteLine("Have you ever had a DUI? (Enter true or false");
            string dui = Console.ReadLine();
            bool duiBool = Convert.ToBoolean(dui);

            // Ask applicant how many speeding tickets do they have
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int ticketsInt = Convert.ToInt32(tickets);

            // Qualified if Age is over 15 and no DUI and 3 or fewer tickets
            bool qualifiedFinal = (ageInt > 15) && !duiBool && (ticketsInt <= 3);

            Console.WriteLine("Are you eligible? " + qualifiedFinal);
            Console.ReadLine();
        }
    }
}