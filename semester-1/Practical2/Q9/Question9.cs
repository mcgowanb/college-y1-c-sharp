using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    class Question9
    {
        static void Main(string[] args)
        {
            double length, width, area, fVolume;
            const int fCost = 10 ;


            Console.Write("Enter Lawn Width in meters:\t");
            width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Lawn length in meters:\t");
            length = Convert.ToDouble(Console.ReadLine());

            area = length * width;
            fVolume = (area * 50) / 100;

            Console.WriteLine("Total Lawn area:\t" + area + " sq m");
            Console.WriteLine("Total Fertiliser needed:\t" + fVolume + " kg");
            Console.WriteLine("Total Cost:\t$" + fVolume * fCost);



        }
    }
}
