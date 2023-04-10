using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    //Step 3- Chain two constructors together.
    public class Person
    {
        public string Middle;
        public string First;
        public string Last;


        public Person(string lastName, string firstName)
            : this(lastName, firstName, "N/A")
        {
            Console.WriteLine("Constructed");
        }

        public Person(string lastName, string firstName, string middleName)
        {
            Middle = middleName;
            First = firstName;
            Last = lastName;
            Console.WriteLine(firstName + " " + middleName + " " + lastName);
        }
    }
}