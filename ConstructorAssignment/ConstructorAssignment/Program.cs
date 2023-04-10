using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Step 1- Create a const variable.
            const string name = "Richelle";
            Console.WriteLine("Hello {0}", name);
            Console.ReadLine();

            //Step 2- Create a variable using the keyword “var.”
            var x = 25;

            Console.WriteLine("The number is {0}", x);

            var person1 = new Person("Richelle", "Tac");
            var person2 = new Person("Richelle", "Tac", "Tinam");

            Console.ReadLine();

        }
    }
}