using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputAssign
{
    class NumberInput
    {
        public static string GetNumberFromUser()
        {
            Console.Write("Enter a number: ");
            return Console.ReadLine();
        }
    }
}
