using System;
using System.Linq;
using ConsoleInput;

namespace Practical5
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = Input.GetStringFromConsole("Please enter your name:");
            Console.WriteLine("Your name is: {0}", name);
        }

        public static int Smallest(int x, int y, int z)
        {
            int[] data = { x, y, z };
            return data.Min();
        }

        public static int Average(int x, int y, int z)
        {
            int[] data = { x, y, z };
            return (int)data.Average();
        }

        public static bool Same(int x, int y, int z)
        {
            return ((x == y) && (x == z));
        }

        public static bool Different(int x, int y, int z)
        {
            return ((x != y) && (x != z));
        }

        static bool Sorted(int x, int y, int z)
        {
            return ((x < y) && (y < z));
        }
    }
}
