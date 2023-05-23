using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects 
{
    class Person
    {
        public Person(string fn = "", string ln = "")
        {
            FirstName = fn;
            LastName = ln;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            //Write person's full name on the console
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}