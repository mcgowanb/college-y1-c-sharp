using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Question3
    {
        static void Main(string[] args)
        {
            double length, width, area, woodLength;

            Console.Write("Enter Window Width (in mm):\t");
            width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Window Length (in mm):\t");
            length = Convert.ToDouble(Console.ReadLine());

            width = convertToMeter(width);
            length = convertToMeter(length);
            area = length * width;
            woodLength = (length * 2) + ( width * 2);

            Console.WriteLine("Wood amount:\t\t\t" + woodLength + "m");
            Console.WriteLine("Glass amount:\t\t\t" + area + " sqr m");

        }

        static double convertToMeter(double val)
        {
            return val / 1000;
        }
    }
}
