﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_6Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //ASSIGNMENT PART ONE 
            //Step 1- Add a one dimensional array of strings
            string[] stringArray = { "Gen", "Leah", "Hannah", "Mery", "Kelly", "Matty" };
            //Step 2- Asks the user to input text
            Console.WriteLine("Enter your last name: ");
            //Saves user input into variable
            string userInput = Console.ReadLine();
            //Step 3- A loop that iterates through each string in the array and adds the user's text input 
            // to the end of each string 
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + " " + userInput;
            }
            //Step 4- Create a second loop that prints off each string in the array one at a time
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }


            //ASSIGNMENT PART TWO
            //Step 1- Add an infinite loop
            while (true)
            {
                Console.WriteLine("Hello, World");
                Console.ReadLine();
                //Step 3- fix the infinite loop so it stops printing after 1
                break;
            }

            //ASSIGNMENT PART THREE
            //Step 1- A loop where the comparison that's being used to determine
            //whether to continue iterating the loop is a < operator
            int[] intArray = { 12, 25, 55, 5, 75, 98 };
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);

            }
            //Step 2- another loop where the comparison that’s used to determine whether
            //to continue iterating the loop is a “<=” operator
            int[] intArray1 = { 2, 5, 6, 1, 8, 9 };
            int counter = 0;
            while (counter <= 5)
            {
                Console.WriteLine(intArray1[counter]);


                counter++;

            }
            Console.ReadLine();

            //ASSIGNMENT PART FOUR
            //Step 1- add a list of strings where each item in the list is unique
            List<string> stringList = new List<string>();
            stringList.Add("Mike");
            stringList.Add("Cathy");
            stringList.Add("Aaron");
            stringList.Add("Helda");
            stringList.Add("Eric");
            //Step 2- asks the user to input text to search for in the list
            Console.WriteLine("Enter a name to search in the list: ");
            string userNameInput = Console.ReadLine();
            //Step 3- a loop that iterates through the list and then displays the index
            //of the list item that contains matching text on the screen.
            bool found = false;
            for (int k = 0; k < stringList.Count; k++)
            {
                if (userNameInput == stringList[k])
                {
                    Console.WriteLine(k);
                    Console.ReadLine();
                    found = true;
                    //Step 5- Add code that stops the loop from executing once a match has been found.
                    break;
                }
            }
            //Step 4- Add code to check if the user put in text that isn't on the list
            //and, if they did, tell the user their input is not on the list. 
            if (!found)
            {
                Console.WriteLine("Your input is not on the list");
                Console.ReadLine();
            }
            //ASSIGNMENT PART 5
            //Step 1- Add a list of strings that has at least two identical
            //strings in the list. Ask the user to select text to search for in the list.
            List<string> stringList1 = new List<string>();
            stringList1.Add("Lil");
            stringList1.Add("Kell");
            stringList1.Add("Robert");
            stringList1.Add("Rich");
            stringList1.Add("Macky");
            stringList1.Add("Del");
            Console.WriteLine("Search for a name on the list: ");
            string userNameInput1 = Console.ReadLine();

            //Step 2- Create a loop that iterates through the list and then displays
            //the indices of the items matching the user-selected text.

            bool found1 = false;
            for (int k = 0; k < stringList1.Count; k++)
            {
                //Step 3- check if the user put in text that isn't on the list and,
                //if they did, tells the user their input is not on the list
                if (userNameInput1 == stringList1[k])
                {
                    Console.WriteLine(k);
                    Console.ReadLine();
                    found1 = true;

                }
                if (!found1)

                {
                    Console.WriteLine("Your input is not on the list");
                    Console.ReadLine();
                }
            }

            //ASSIGNMENT PART 6
            //Step 1- Create a list of strings that has two identical strings in the list
            List<string> stringList2 = new List<string>();
            stringList2.Add("A");
            stringList2.Add("B");
            stringList2.Add("C");
            stringList2.Add("D");
            stringList2.Add("B");
            stringList2.Add("C");
            //Step 2- Create a foreach loop that evaluates each item in the list, and displays
            //a message showing the string and whether or not it has already appeared in the list.

            foreach (string letter1 in stringList2)
            {
                int counter1 = 0;
                foreach (string letter2 in stringList2)
                {
                    if (letter2 == letter1)
                    {
                        counter1++;
                    }

                }

                if (counter1 == 1)
                {
                    Console.WriteLine(letter1 + " - This item is unique");
                }
                else
                {
                    Console.WriteLine(letter1 + " - This item is a duplicate");
                }
            }
            Console.ReadLine();
        }
    }
}
