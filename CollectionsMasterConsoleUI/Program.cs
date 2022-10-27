﻿using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            /*
            //TODO: Create an integer Array of size 50

            var intArray = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(intArray);

            //TODO: Print the first number of the array

            Console.WriteLine($"{intArray[0]}");

            //TODO: Print the last number of the array

            Console.WriteLine($"{intArray[49]}");

                        // note if you dk the last index of the array you can do {intArray.Length - 1}

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            
            NumberPrinter(intArray);
            
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            /*
            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(intArray);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(intArray);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            /*
            Console.WriteLine("Sorted numbers:");
            
            Array.Sort(intArray);
            NumberPrinter(intArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            */
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List

            var numberList = new List<int>();
            

            //TODO: Print the capacity of the list to the console

            Console.WriteLine($"Capacity is {numberList.Capacity}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Populater(numberList);

            //TODO: Print the new capacity

            Console.WriteLine($"New capacity is {numberList.Capacity}");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!

            int userNumber;
            bool isNumber;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isNumber = int.TryParse(Console.ReadLine(), out userNumber); 
            } while (!isNumber);

            //int.TryParse convers user input string to int, if number is not inputed, prompt to input nr repeats.
            // when user inputs a number, the number is stored in userNumber, done by "out userNumber".
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            
            NumberPrinter(numberList);
            Console.WriteLine($"Current Count: {numberList.Count}");
            
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            OddKiller(numberList);
            Console.WriteLine($"Current Count: {numberList.Count}");

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

            numberList.Sort();
            NumberPrinter(numberList);
            Console.WriteLine($"Current Count: {numberList.Count}");


            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable

            var myArray = numberList.ToArray();
            

            //TODO: Clear the list

            numberList.Clear();
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            if (numbers[i] % 3 == 0)
            {
                numbers[i] = 0;
            }

            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            for(int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }

            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if(numberList.Contains(searchNumber))
            {
                Console.WriteLine("Yes, number is in list");
            }    
            else
            {
                Console.WriteLine("No, number is not in list");
            }
        }

        private static void Populater(List<int> numberList)
        {
            while(numberList.Count < 51)
            {
                Random rng = new Random();
                var number = rng.Next(0, 50);

                numberList.Add(number);
            }
            
            NumberPrinter(numberList);

        }

        private static void Populater(int[] numbers)
        {
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50

            for (int i = 0; i < numbers.Length; i++)
            {
                Random rng = new Random();
                numbers[i] = rng.Next(0, 50);
            }

        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
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
