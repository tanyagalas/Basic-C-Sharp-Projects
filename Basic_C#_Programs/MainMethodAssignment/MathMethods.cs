using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodassign
{
    class MathMethods
    { 

        //Method to add 10 to an integer and return an integer
        public int Mathop(int number) 
        {
            return number + 7;
        }

        public int Mathop(decimal number)
        {
            int newNum = Convert.ToInt32(number);
            return newNum * 20;
        }
        
        //Method  to convert a string to an integer
        public int Mathop(string number)
        {
            int newNum = Convert.ToInt32(number);
            return newNum / 3;
        }
    }
}