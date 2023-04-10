using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a one-dimensional Array of strings.
            //Ask the user to select an index of the Array
            //and then display the string at that index on the screen.
            string[] colorArray = new string[] { "blue", "green", "red", "yellow", "purple" };
            Console.WriteLine("select an index for color");
            int indexS = Convert.ToInt32(Console.ReadLine());

            //Add in a message that displays when the user selects an index that doesn’t exist.
            if (indexS < 0 || indexS > 4)
            {
                Console.WriteLine("That index doesn’t exist.");
            }
            else
            {
                Console.WriteLine(colorArray[indexS]);
            }

            //Create a one-dimensional Array of integers.
            //Ask the user to select an index of the Array
            //and then display the integer at that index on the screen.
            int[] numArray = new int[] { 5, 10, 15, 20, 25 };
            Console.WriteLine("select an index for number");
            int indexI = Convert.ToInt32(Console.ReadLine());

            //Add in a message that displays when the user selects an index that doesn’t exist.
            if (indexI < 0 || indexI > 4)
            {
                Console.WriteLine("That index doesn’t exist.");
            }
            else
            {
                Console.WriteLine(numArray[indexI]);
            }

            //Create a list of strings.
            //Ask the user to select an index of the list
            //and then display the content at that index on the screen.
            List<string> countryList = new List<string>() { "Philippines", "Maldives", "Vietnam", "USA", "Canada" };
            Console.WriteLine("select an index for country");
            int indexC = Convert.ToInt32(Console.ReadLine());

            //Add in a message that displays when the user selects an index that doesn’t exist.
            if (indexC < 0 || indexC > 4)
            {
                Console.WriteLine("That index doesn’t exist.");
            }
            else
            {
                Console.WriteLine(countryList[indexC]);
            }

            Console.ReadLine();
        }
    }
}