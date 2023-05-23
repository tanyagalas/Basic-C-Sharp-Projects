using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  PolymorphismAssignment
{
    class Employee : Person, IQuitable
    {
        // Implementation of the SayName() method
        public override void SayName()
        {
            Console.WriteLine("Employee name is: {0} {1}", FirstName, LastName);
        }

        // Implementation of the Quit() 
        public void Quit()
        {
            Console.WriteLine("This employee has quit");
            FirstName = "";
            LastName = "";
        }
    }
}
