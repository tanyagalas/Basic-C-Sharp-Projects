using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodassign
{
    class Program
    {
        static void Main(string[] args)
        {
        
            MathMethods myOp = new MathMethods();

            //Example usage with integer
            Console.WriteLine("Please input an integer to operate on: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your integer plus 7 is: " + myOp.Mathop(userNum));


            MathMethods myOp2 = new MathMethods();//new MathOp object

            //Example usage with decimal
            Console.WriteLine("Please input a decimal to operate on: ");
            decimal userNumFloat = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Your decimal multiplied by 20 is: " + myOp2.Mathop(userNumFloat));


            //Usage with a string
            MathMethods myOp3 = new MathMethods(); 
            Console.WriteLine("Please input a integer to operate on: ");

            Console.WriteLine("Your integer divided by 3 is: " + myOp3.Mathop(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}



