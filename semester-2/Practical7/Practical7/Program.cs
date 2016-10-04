using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practical7
{
    class Program
    {
        static int[] playerAges = new int[6];
        static int[] otherNumbers = {5,7,6,5,4,3};
        static void Main(string[] args)
        {

            test();

            ReadFromConsole();

            OutputOddElements();

            OutputAges();

            OutputReverse();

            OutputAverage();

            ReverseArray();

            Console.WriteLine("Sum of multiplication is {0}", MultiplyByOtherNumbers());
        }

        static int MultiplyByOtherNumbers()
        {
            int sum = 0;
            for (int i = 0; i < playerAges.Length; i++)
            {
                sum += playerAges[i]*otherNumbers[i];
            }
            return sum;
        }

        private static void ReverseArray()
        {
            playerAges.Reverse();
            Console.WriteLine(  "Array now reversed");
        }

        private static void OutputAverage()
        {
            Console.WriteLine("Average age is: {0:G2}", playerAges.Average());
        }

        private static void OutputReverse()
        {
            Console.WriteLine("Output in reverse order:");
            for (int i = playerAges.Length -1; i >= 0; i--)
            {
                Console.WriteLine("Player age is {0}", playerAges[i]);
            }
        }

        private static void OutputOddElements()
        {
            Console.WriteLine("Age at location {0} is {1}", 1, playerAges[0]);
            Console.WriteLine("Age at location {0} is {1}", 3, playerAges[2]);
            Console.WriteLine("Age at location {0} is {1}", 6, playerAges[5]);
        }

        private static void OutputAges()
        {
            foreach (int age in playerAges)
            {
                Console.WriteLine("Player age is {0}", age);
            }
        }

        private static void ReadFromConsole()
        {
            for (int i = 0; i < playerAges.Length; i++)
            {
                Console.Write("Please enter player age:");
                playerAges[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void test()
        {
            Console.WriteLine("enter a searc term");
            string term = Console.ReadLine();


            string[] scores = { "1", "2", "3", "4", "5", "6", "7", "8" };

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == term)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
