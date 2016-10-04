using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Q2
    {
        static void Main(string[] args)
        {
            int hours, minutes, seconds;

            Console.Write("Please enter a time in seconds: ");
            seconds = Convert.ToInt32(Console.ReadLine());
            hours = seconds / 3600;
            seconds %= 3600;
            minutes = seconds / 60;
            seconds %= 60;

            Console.WriteLine("The time when converted to hours minutes and seconds is: {0:00}:{1:00}:{2:00}", hours, minutes, seconds);


        }
    }
}
