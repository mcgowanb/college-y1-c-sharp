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
            int n1, n2;
            int sum = 0;
            Console.Write("Enter the first number: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            for (; n1 < n2; n1++ )
            {
                if (n1 % 2 != 0)
                {
                    sum += n1;
                }
                if (sum >= 500) {
                    Console.WriteLine("Number too large");
                    break;
                }
            }
            Console.WriteLine("Total of odd numbers is: {0}", sum);
        }
    }
}
