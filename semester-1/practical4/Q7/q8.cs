using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class q8
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int customerAreaCode, calledAreaCode, callTime;
            const int CALL_LIMIT = 20;
            const double PRICE_PER_MINUTE = .13;
            double totalCost;

            Console.Write("{0,-35}", "Enter your area code:");
            customerAreaCode = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0,-35}", "Enter area code you are calling");
            calledAreaCode = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0,-35}", "Enter call duration");
            callTime = Convert.ToInt32(Console.ReadLine());

            if (callTime >= CALL_LIMIT && calledAreaCode != customerAreaCode)
            {
                totalCost = (double)callTime;
            }
            else
            {
                totalCost = ((double)callTime * PRICE_PER_MINUTE);
            }

            Console.WriteLine("{0} {1:c2}", "Total call cost is", totalCost);
        }
    }
}
