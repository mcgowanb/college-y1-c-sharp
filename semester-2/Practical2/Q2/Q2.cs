using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Q2
    {
        const int MONTHS = 12;
        static void Main(string[] args)
        {
            int years = 0;
            int rainfall = 0;
            int tMonths = 0;
            double average = 0;

            Console.Write("{0,-60}", "Please enter the number of years:");
            years = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < years; i++)
            {

                for (int x = 1; x <= MONTHS; x++)
                {
                    Console.Write("for month {0}, Please enter the amount of rainfall in mm: ", x);
                    rainfall += Convert.ToInt32(Console.ReadLine());
                }

            }
            tMonths = years * MONTHS;
            average = (double)rainfall / tMonths;
            Console.WriteLine("Total nuber of months: {0}, Total rainfall: {1}", tMonths, rainfall);
            Console.WriteLine("Average rainfall per month for entire period: {0}", average);


        }
    }
}
