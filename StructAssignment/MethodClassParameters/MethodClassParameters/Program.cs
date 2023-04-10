using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method of the console app, instantiate the class.
            two_parameters math = new two_parameters();


            //3. Ask the user to input two numbers, one at a time.
            Console.WriteLine("Select first and second number to perform the calculation:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            //4. Call the method in the class, passing in the one or two numbers entered.
            Console.WriteLine(math.Add(num1, num2));
            Console.WriteLine("Passing just the first number: ");
            Console.WriteLine(math.Add(num1));

            //5. Try various combinations of numbers on the code, including having no second number. 
            //Let them know they need not enter anything for the second number.
            Console.WriteLine("Select first number to perform the calculation, no need for second number :");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(math.Add(num3));


            Console.ReadLine();
        }
    }
}