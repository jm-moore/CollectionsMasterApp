using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();


            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] numbers = new int[50];

            Populater(numbers);

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers.Length-1);
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50


            //TODO: Print the first number of the array

            //TODO: Print the last number of the array            

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            NumberPrinter(numbers.Reverse());

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            
            ThreeKiller(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            
            List<int> numberList = new List<int>();

            Console.WriteLine(numberList.Count());

            //TODO: Print the capacity of the list to the console

            Populater(numberList);
            

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Console.WriteLine(numberList.Count());

            //TODO: Print the new capacity
            

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            var searchNumber = int.Parse(Console.ReadLine());
            NumberChecker(numberList, searchNumber);
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numberList);

            Console.WriteLine("-------------------");
            Console.WriteLine("-------------------");

            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            EvensOnly(numberList);
            NumberPrinter(numberList);
            
            
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

            numberList.Sort();
            NumberPrinter(numberList);
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            

            //TODO: Clear the list
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
           for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"{searchNumber} is in the list.");
            }
            else
            {
                Console.WriteLine($"{searchNumber} is not in the list.");
            }
            
        }

        private static void Populater(List<int> numberList)
        {
            while (numberList.Count < 50)
            {
                Random r = new Random();
                numberList.Add(r.Next(1, 51));
            } 
            
        }

        private static void Populater(int[] numbers)
        {
            Random r = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(1, 51);
            }
        }

        private static void EvensOnly(List<int> numbersList)
        {
            for (int i = 0; i < numbersList.Count; i++)
                if (numbersList[i] % 2 != 0)
                {
                    numbersList.Remove(numbersList[i]);
                }
            numbersList.Add(0);
        }


        private static void ReverseArray(int[] array)
        {
            
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
