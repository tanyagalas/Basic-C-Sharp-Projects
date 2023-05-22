using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  MethodClassassign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

            // Instantiate the Method class
            Method myOp = new Method();

            //Call the methOp in the class
            myOp.mathOp(num1, num2);

            //Call the methOp in the class
            myOp.mathOp(secondNum: num2, firstNum: num1);
            Console.ReadLine();
        }
    }
}




