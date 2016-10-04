using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class q5
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            const double COST_PER_DAY = 2;
            const double REDUCED_COST_PER_DAY = 1.5;
            const double MAX_COST = 50;
            double totalCost;
            const int PRICE_CHANGE_DAY = 3;
            int daysRental;

            Console.Write("{0,-45}", "Please enter the number of days rental");
            daysRental = Convert.ToInt32(Console.ReadLine());

            if (daysRental <= PRICE_CHANGE_DAY)
            {
                totalCost = (COST_PER_DAY * daysRental);
            }
            else
            {
                totalCost = (COST_PER_DAY * PRICE_CHANGE_DAY);
                int remainingDays = daysRental - PRICE_CHANGE_DAY;
                totalCost += (REDUCED_COST_PER_DAY * remainingDays);
                if (totalCost > MAX_COST)
                {
                    totalCost = MAX_COST;
                }
            }
            Console.WriteLine("{0} {1:c2}", "Total Cost for rental is:", totalCost);

        }
    }
}
