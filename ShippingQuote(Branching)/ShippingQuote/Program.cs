using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            //application for getting a shipping quote for a package.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            string packageWeightStr = Console.ReadLine();
            int packageWeight = Convert.ToInt32(packageWeightStr);

            //If the weight is greater than 50, display the error message. At this point the program would end.
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                string packageWidthStr = Console.ReadLine();
                int packageWidth = Convert.ToInt32(packageWidthStr);

                Console.WriteLine("Please enter the package height:");
                string packageHeightStr = Console.ReadLine();
                int packageHeight = Convert.ToInt32(packageHeightStr);

                Console.WriteLine("Please enter the package length:");
                string packageLengthStr = Console.ReadLine();
                int packageLength = Convert.ToInt32(packageLengthStr);

                int dimensionsTotal = packageWidth + packageHeight + packageLength;

                //If the dimensions total greater than 50, display the error message, At this point the program would end.
                if (dimensionsTotal > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    // multiply the three dimensions, and the weight. divide the outcome by 100. The result of that calculation is the quote.
                    int quote = packageWidth * packageHeight * packageLength * packageWeight / 100;
                    string quoteStr = quote.ToString(".00");
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quoteStr);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}