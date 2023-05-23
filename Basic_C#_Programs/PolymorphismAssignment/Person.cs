using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public abstract class Person
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method to say the persons name
        public abstract void SayName();
    }
}
