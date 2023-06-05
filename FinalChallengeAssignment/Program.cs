using FinalChallangeAssignment;
using System;

namespace FinalChallengeAssignment
{
    class Program
    {
        private static Student students;

        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student() { StudentName = "Josh" };

                Student student1 = ctx.Students.Add(students);
                int v = ctx.SaveChanges();
            }
            Console.WriteLine("Demo completed.");
            Console.ReadLine();
        }
    }
}