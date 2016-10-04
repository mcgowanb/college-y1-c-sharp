using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Question5
    {
        static void Main(string[] args)
        {
            int miles;
            double km;

            Console.Write("Please enter the number of miles: ");
            miles = Convert.ToInt32(Console.ReadLine());

            km = miles / .625;

            Console.WriteLine("Total KM when converted is: " + km);

        }
    }
}
