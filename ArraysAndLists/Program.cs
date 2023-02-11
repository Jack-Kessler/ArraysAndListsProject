using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] myArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> evensArray = new List<int>();
            List<int> oddsArray = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    evensArray.Add(myArray[i]);
                }
                else
                {
                    oddsArray.Add(myArray[i]);
                }
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            for (int i = 0; i < oddsArray.Count; i++)
            {
                Console.WriteLine($"Even Array: I have {evensArray[i]} in my array!");
                Console.WriteLine($"Odd Array: That's odd... I don't have a {evensArray[i]} but I have a {oddsArray[i]}");
            }
        }
    }
}
