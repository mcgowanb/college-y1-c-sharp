using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Q3
    {
        static void Main(string[] args)
        {
            int digit1, digit2, sum;

            sum = 0;
            Console.Write("{0,-20}", "Enter number 1:");
            digit1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0,-20}", "Enter number 2:");
            digit2 = Convert.ToInt32(Console.ReadLine());

            for (int i = digit1; i <= digit2; i++) {
                sum += i;
            }
            Console.WriteLine(sum);


        }
    }
}
