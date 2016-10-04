using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Q5
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            const int MONTHS_IN_YEAR = 12;
            const double PERCENT_RATE = .01;
            double initialBalance = 0, monthlySavings = 0, balance = 0;
            int noOfYears = 0, noOfMonths = 0;

            Console.Write("Enter initial Balance: ");
            initialBalance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter No of years: ");
            noOfYears = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter monthly savings: ");
            monthlySavings = Convert.ToDouble(Console.ReadLine());

            noOfMonths = noOfYears * MONTHS_IN_YEAR;

            balance = initialBalance;

            for (int i = 0; i < noOfMonths; i++)
            {
                balance += monthlySavings + (balance * PERCENT_RATE);
                Console.WriteLine("Running balance now is: {0:c2}", balance);
            }
            Console.WriteLine("Total balance now is: {0:c2}", balance);
        }
    }
}
