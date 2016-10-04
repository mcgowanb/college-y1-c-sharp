using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Q3
    {
        static void Main(string[] args)
        {
            int startNumber, days;
            double dailyIncrease, totalPopulation = 0;

            Console.Write("{0,-50}", "Enter initial population: ");
            startNumber = Convert.ToInt32(Console.ReadLine());
            totalPopulation = (double)startNumber;

            Console.Write("{0,-50}", "Enter average increase as a percentage: ");
            dailyIncrease = (Convert.ToDouble(Console.ReadLine()) / 100);

            Console.Write("{0,-50}", "Enter no of days: ");
            days = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= days; i++)
            {
                totalPopulation += totalPopulation * dailyIncrease;
                Console.WriteLine("Population on  day {0} is {1}", i, Math.Round(totalPopulation));
            }
        }
    }
}
