using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 5; i >= 0; i--)
            {
                for (int x = 1; x <= i; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

        }
    }
}
