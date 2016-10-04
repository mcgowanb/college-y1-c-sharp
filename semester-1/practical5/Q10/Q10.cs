using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    class Q10
    {
        static void Main(string[] args)
        {
            double initialHeight, targetHeight;
            const double RATE_OF_DECLINE = .75;
            int bounces = 0;

            Console.Write("Enter Initial height ");
            initialHeight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Target height ");
            targetHeight = Convert.ToDouble(Console.ReadLine());

            while (initialHeight > targetHeight) {
                initialHeight = (initialHeight * RATE_OF_DECLINE);
                bounces++;
            }

            Console.WriteLine("Total number of bounces befor target height is reached: " + bounces);
        }
    }
}
