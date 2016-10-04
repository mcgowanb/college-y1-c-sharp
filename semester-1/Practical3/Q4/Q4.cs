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

            const double K = 9e9;
            double q1, q2, force, meters;

            Console.Write("Please enter Q1: ");
            q1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter Q2: ");
            q2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter Distance: ");
            meters = Convert.ToDouble(Console.ReadLine());

            force = (K * q1 * q2) / Math.Pow(meters, 2);
            Console.WriteLine("{0} {1:E0}", "Result is:", force);

        }
    }
}
