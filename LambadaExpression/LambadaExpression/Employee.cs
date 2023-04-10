using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambadaExpression
{

    //1. Create an Employee class with the following properties:
    //a.Id
    //b.First Name
    //c. Last Name

    class Employee
    {
        public int Id;
        public string FirstName;
        public string LastName;

        public Employee(int id, string First, string Last)
        {
            Id = id;
            FirstName = First;
            LastName = Last;
        }

    }


}