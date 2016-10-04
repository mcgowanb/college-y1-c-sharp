using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class Q7
    {
        static void Main(string[] args)
        {
            int scoreTotal = 0;
            int counter = 0;
            bool repeat;
            double average;

            do {
                repeat = true;
                Console.Write("Enter Score: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num != -999)
                {
                    scoreTotal += num;
                    counter++;
                }
                else repeat = false;

            }
            while (repeat);

            average = (double)scoreTotal / counter;

            Console.WriteLine("{0} {1:0.##}", "The Average score is:", average);
        }
    }
}
