using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    // A class with constructor chaining
    class MyClass
    {
        public string MyProperty { get; set; }

        // Constructor with a string parameter
        public MyClass(string value)
            : this(value, "there")
        {
        }

        // Constructor with two string parameters
        public MyClass(string value1, string value2)
        {
            MyProperty = value1 + ", " + value2 + "!";
        }
    }
}