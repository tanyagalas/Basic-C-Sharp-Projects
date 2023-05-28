using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age:");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age <= 0)
                {
                    throw new ArgumentException("Age must be a positive number.");
                }

                int currentYear = DateTime.Now.Year;
                int birthYear = currentYear - age;
                Console.WriteLine("You were born in " + birthYear);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number for age.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Please try again.");
            }

            Console.ReadLine();
        }
    }
}
  