using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  AbstractClass
{
    // Employee class inheriting from Person
    public class Employee : Person
    {
        // Implementation of the sayName method
        public override void sayName()
        {
            Console.WriteLine("Employee name is: " + FirstName + " " + LastName);
        }
    }
}