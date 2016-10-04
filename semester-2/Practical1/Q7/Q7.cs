using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            string status = "is not a leap year";

            Console.Write("Enter year: ");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)) {
                status = "is a leap year";
            }


            Console.WriteLine("{0} {1}", year, status);

        }
    }
}
