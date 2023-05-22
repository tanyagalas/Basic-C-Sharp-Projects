using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassassign
{
    public class Method
    {
        // Method that takes two integers as parameters and performs a math operation
        public void mathOp(int firstNum, int secondNum)
        {
            firstNum += 10;
            Console.WriteLine("The second input is: " + secondNum);
        }
    }
}