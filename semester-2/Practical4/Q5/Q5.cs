using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Q5
    {
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 504;
            Console.WriteLine("Total for whole numbers between {0} and {1} is {2}", num1, num2, addNumbers(num1, num2));

            Console.WriteLine("Number of days in February 2016 is {0}", DaysInMonthToCalculate(2));
        }

        static int addNumbers(int first, int second)
        {
            int total = 0;
            for (int i = first; i <= second; i++)
            {
                total += i;
            }
            return total;
        }

        static int DaysInMonthToCalculate(int month)
        {
            return DateTime.DaysInMonth(2016, month);
        }
    }
}
