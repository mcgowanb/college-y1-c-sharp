using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    class Question8
    {
        static void Main(string[] args)
        {
            string name;
            double hFeet, hInches, hMeters;

            Console.Write("Pleaese enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Pleaese enter your height: ");

            Console.Write("\tFeeet:");
            hFeet = Convert.ToDouble(Console.ReadLine());

            Console.Write("\tInches:");
            hInches = Convert.ToDouble(Console.ReadLine());

            hMeters = (hFeet * .3048);
            hMeters += ((hInches * .3048) / 12);

            Console.WriteLine(name + ", you are " + hMeters + " tall");
        }
    }
}