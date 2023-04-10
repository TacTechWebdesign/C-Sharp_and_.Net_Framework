using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //3. Create another class called Employee
    //and have it inherit from the Person class.
    //4. Implement the SayName() method inside of the Employee class.

    class Employee : Person
    {
        public Employee(string First, string Last)
        {
            firstName = First;
            lastName = Last;
        }

    }
}