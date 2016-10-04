using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Q1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0} {1}", "Merry Christmas", i);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine();
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine();
        
            for (int i = 20; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine();

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
