using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a const variable
            const int myConstVariable = 10;
            Console.WriteLine("Const variable value: " + myConstVariable);

            // Create a variable using the keyword "var"
            var myVarVariable = "Welcome to the program!";
            Console.WriteLine("Var variable value: " + myVarVariable);

            // Chain two constructors together
            MyClass myObject = new MyClass("Hello");
            Console.WriteLine("MyObject property value: " + myObject.MyProperty);

            Console.ReadLine();
        }
    }
}
