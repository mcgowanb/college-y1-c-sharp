using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2
{
    class Q1
    {
        static void Main(string[] args)
        {
            int distance = 0;
            int hours, speed;

            Console.Write("{0, -40}", "Please enter the vehicles speed in km:");
            speed = Convert.ToInt32(Console.ReadLine());

            while (speed <= 0)
            {
                Console.WriteLine("Your must enter a value greater than 0");
                Console.Write("{0, -40}", "Please enter the vehicles speed in km:");
                speed = Convert.ToInt32(Console.ReadLine());
            }



            Console.Write("{0, -40}", "Please enter the time taken:");
            hours = Convert.ToInt32(Console.ReadLine());

            while (hours < 0)
            {
                Console.WriteLine("Your must enter a value greater than -1");
                Console.Write("{0, -40}", "Please enter the time taken:");
                hours = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("{0,-10} {1,-20}", "Hour", "Distance Traveled");

            for (int i = 1; i <= hours; i++)
            {
                distance += speed;
                Console.WriteLine("{0,-10} {1}km", i, distance);
            }

        }

    }
}
