using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Class1
    {
       public int DivideByTwo(int data)
        {
            return data / 2;
        }

        // Method with output parameters
        public void MethodWithOutputParams(out int param1, out int param2)
        {
            param1 = 10;
            param2 = 20;
        }

        public int MethodOverload(int data)
        {
            return data * 2;
        }
    }
}