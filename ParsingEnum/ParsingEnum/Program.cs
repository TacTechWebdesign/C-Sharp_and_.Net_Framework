using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Wrap the above statement in a try/catch block and have it print
            //"Please enter an actual day of the week.” to the console if an error occurs.

            try
            {
                Dictionary<string, int> days = new Dictionary<string, int>()
                {
                    {"Sunday", 1 },
                    {"Monday", 2 },
                    {"Tuesday", 3 },
                    {"Wednesday", 4 },
                    {"Thursday", 5 },
                    {"Friday", 6 },
                    {"Saturday", 7 }

                };

                int dayNum;
                void switchWeekDays()
                {
                    switch (dayNum)
                    {
                        case (int)DaysOfTheweek.Sunday:
                            Console.WriteLine("You choose Sunday");
                            break;
                        case (int)DaysOfTheweek.Monday:
                            Console.WriteLine("You choose Monday");
                            break;
                        case (int)DaysOfTheweek.Tuesday:
                            Console.WriteLine("You choose Tuesday");
                            break;
                        case (int)DaysOfTheweek.Wednesday:
                            Console.WriteLine("You choose Wednesday");
                            break;
                        case (int)DaysOfTheweek.Thursday:
                            Console.WriteLine("You choose Thursday");
                            break;
                        case (int)DaysOfTheweek.Friday:
                            Console.WriteLine("You choose Friday");
                            break;
                        case (int)DaysOfTheweek.Saturday:
                            Console.WriteLine("You choose Saturday");
                            break;

                    }
                }

                //2. Prompt the user to enter the current day of the week.
                Console.WriteLine("Enter the day of the week");
                string day = Console.ReadLine();
                dayNum = days[day];

                switchWeekDays();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");

            }



            Console.ReadLine();
        }


        //1. Create an enum for the days of the week.
        //3. Assign the value to a variable of that enum data type you just created.
        public enum DaysOfTheweek
        {
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6,
            Saturday = 7

        }


    }
}