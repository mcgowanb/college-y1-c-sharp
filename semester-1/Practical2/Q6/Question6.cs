using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Question6
    {
        static void Main(string[] args)
        {
            int celsius, fahrenheit;

            Console.Write("Please enter the temperature in Fahrenheit: ");
            fahrenheit = Convert.ToInt32(Console.ReadLine());

            celsius = 5 * (fahrenheit - 32) / 9;

            Console.WriteLine("Temperature in Celsuis is: " + celsius);
        }
    }
}
