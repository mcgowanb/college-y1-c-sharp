using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Question4
    {
        static void Main(string[] args)
        {
            int km, hrs;
            double kmh;

            Console.Write("Please enter the distance covered in KM: ");
            km = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the Journey time in hours: ");
            hrs = Convert.ToInt32(Console.ReadLine());

            kmh = (double)(km / hrs);

            Console.WriteLine("The average speed for this journey is: " + kmh + " km/hr");
        }
    }
}
