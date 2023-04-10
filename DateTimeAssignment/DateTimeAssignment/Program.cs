using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Prints the current date and time to the console.
            Console.WriteLine("The dtae and time now is: {0}", DateTime.Now);
            Console.WriteLine("======");

            //2. Asks the user for a number.
            Console.WriteLine("Choose number of hours: ");
            int numberOfHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("======");

            //3. Prints to the console the exact time it will be in X hours,
            //X being the number the user entered in step 2.

            DateTime currentTime = DateTime.Now;
            Console.WriteLine("The dtae and time now is: {0}", currentTime);
            Console.WriteLine("======");

            // adding the numberOfHours to the current time and date.
            DateTime timeInXhours = currentTime.AddHours(numberOfHours);

            Console.WriteLine("The dtae and time in {0} hours will be: {1}", numberOfHours, timeInXhours);

            Console.ReadLine();
        }
    }
}