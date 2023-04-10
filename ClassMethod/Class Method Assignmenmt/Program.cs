using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignmenmt
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 16;
            int num2 = 24;
            Method function = new Method();

            function.functionOne(num1, num2);

            function.functionOne(int1: num1, int2: num2);

            Console.ReadLine();
        }
    }
}
