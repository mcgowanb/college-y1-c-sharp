using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Q4
    {
        static void Main(string[] args)
        {
            int[] stores = new int[5];
            int counter = 1;
            for (int i = 0; i < stores.Length; i++)
            {
                Console.Write("Enter Sales Figures for Store: {0} ", counter);
                stores[i] = Convert.ToInt32(Console.ReadLine());
                counter++;
            }

            for (int i = 0; i < stores.Length; i++)
            {
                int score = stores[i];
                for (int x = 100; x <= score; x += 100)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
