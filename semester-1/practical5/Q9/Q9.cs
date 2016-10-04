using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    class Q9
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double amount, percent;
            int years, months;

            Console.Write("{0,-25}", "Enter Amount:");
            amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("{0,-25}", "Enter Rate in percent:");
            percent = (Convert.ToDouble(Console.ReadLine()) / 100);

            Console.Write("{0,-25}", "Enter years:");
            years = Convert.ToInt32(Console.ReadLine());
            months = years * 12;

            for (int i = 0; i < months; i++)
            {
                amount += amount * percent;
            }

            Console.WriteLine("{0,-30} {1,10:c2}", "Total Loan Amount:", amount);
        }
    }
}
