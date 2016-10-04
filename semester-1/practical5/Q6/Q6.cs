using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Q6
    {
        static void Main(string[] args)
        {
            int[] scores = new int[6];
            int total;
            double average;

            for (int i = 0; i < 6; i++)
            {
                Console.Write("{0,-30}", "Please enter a score");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }
            total = scores.Sum();
            average = (double)total / scores.Length;
            Console.WriteLine("{0} {1:0.00}", "Average Score is", average);

        }
    }
}
