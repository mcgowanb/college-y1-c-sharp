using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleInput;

namespace Practical6
{
    class Program
    {
        static int[] playerAges = new int[6];

        static void Main(string[] args)
        {
            fillDummyData();
            //readSixValues();
            Console.WriteLine();
            Console.WriteLine();
            printArray();
            Console.WriteLine();
            Console.WriteLine();
            printArrayReverse();
            Console.WriteLine();
            Console.WriteLine();
            average();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(hasValue(7));
            Console.WriteLine(hasValue(3));
            Console.WriteLine();
            Console.WriteLine();
            reverse();
            printArray();

        }

        static void readSixValues()
        {
            for (int i = 0; i < playerAges.Length; i++)
            {
                playerAges[i] = Input.GetIntFromConsole("Please enter a Score");
            }
        }

        static void printArray()
        {
            Console.WriteLine("Array Standard Output");
     
            for (int i = 0; i < playerAges.Length; i++)
            {
                Console.WriteLine("Score value of index {0} is {1}", i, playerAges[i]);
            }
        }
        static void printArrayReverse()
        {
            Console.WriteLine("Array Reversal");

            for (int i = playerAges.Length -1; i >= 0 ; i--)
            {
                Console.WriteLine("Score value of index {0} is {1}", i, playerAges[i]);
            }
        }

        static void printOddElements()
        {
            Console.WriteLine("Print odd Elements");
            Console.WriteLine("First element of array is {0}", playerAges[0]);
            Console.WriteLine("Third element of array is {0}", playerAges[2]);
            Console.WriteLine("Last element of array is {0}", playerAges[5]);
        }

        static void fillDummyData()
        {
            int counter = 1;
            for (int i = 0; i < playerAges.Length; i++)
            {
                playerAges[i] = counter++;
            }
        }

        static void average()
        {
            
            Console.WriteLine("Average of the array valuse is {0}", playerAges.Average());
        }

        static bool hasValue(int value)
        {
            bool hasV = Array.Exists(playerAges, element => element == value);
            return hasV;
        }

        static void reverse()
        {
            Console.WriteLine("Reversing Array");
            Array.Reverse(playerAges);
        }
    }
}
