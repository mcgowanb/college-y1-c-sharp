using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    class Q8
    {
        static void Main(string[] args)
        {
            int days;

            Console.Write("Enter Holiday days: ");
            days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("discount achieved is: {0:P0}", evaluateDiscount(days));
        }

        static double evaluateDiscount(int days)
        {
            double result;
            if (days >= 22)
                result = .15;
            else if (days >= 15)
                result = .1;
            else if (days >= 8)
                result = .05;
            else result = 0;
            return result;
        }
    }
}
