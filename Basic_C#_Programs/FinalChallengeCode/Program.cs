using FinalChallangeAssignment;
using System;
using FinalChallengeAssignment;

namespace FinalChallengeAssignment
{
    class Program
    {
    

        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student() { StudentName = "Josh" };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
            Console.WriteLine("Demo completed.");
            Console.ReadLine();
        }
    }
}