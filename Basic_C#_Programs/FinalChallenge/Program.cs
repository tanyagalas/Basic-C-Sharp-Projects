using System;

namespace FinalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
           
                context.Database.EnsureCreated();

              
                var student = new Student
                {
                    Name = "Tanya G",
                    Age = 33
                };
                context.Students.Add(student);
                context.SaveChanges();
            }

            Console.WriteLine("Student added successfully!");
            Console.ReadLine();
        }
    }
}
