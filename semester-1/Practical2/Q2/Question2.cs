using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Question2
    {
        static void Main(string[] args)
        {
            int num1, num2, total;
            double avg;

            Console.Write("Please enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            total = num1 + num2;
            avg = (double)total / 2;

            Console.WriteLine("The average is: " + avg);

            Console.WriteLine("The average of " + num1 + " and " + num2 + " is: " + avg);

        }
    }
}
