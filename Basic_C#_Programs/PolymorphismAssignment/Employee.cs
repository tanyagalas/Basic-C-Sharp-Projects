using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphismassign
{
    class Employee : Person, IQuitable
    {
        public override void SayName()
        {
            Console.WriteLine("Employee name is: {0} {1}", FirstName, LastName);
        }

        public void Quit()
        {
            Console.WriteLine("This employee has quit");
            FirstName = "";
            LastName = "";
        }
    }
}
