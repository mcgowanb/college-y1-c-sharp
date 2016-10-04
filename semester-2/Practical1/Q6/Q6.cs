using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Q6
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double total = 0, cost = 0;
            int hours = 0;

            Console.Write("{0,-40}", "Enter number of hours: (-999 to quit):");
            hours = Convert.ToInt32(Console.ReadLine());
            while (hours != -999)
            {
                cost = new Q6().calcualteCost(hours);
                total += cost;
                Console.WriteLine("Customer Charge {0:c2} Total receipt: {1,-40:c2}", cost, total);

                Console.Write("{0,-40}", "Enter number of hours: (-999 to quit):");
                hours = Convert.ToInt32(Console.ReadLine());
            }
        }


        public double calcualteCost(int hours)
        {
            double basic = 2;
            if (hours <= 3) return basic;
            else
            {
                hours -= 3;
                for (int i = 0; i < hours; i++)
                {
                    basic += .5;
                    if (basic > 10) basic = 10;
                }
            }
            return basic;
        }
    }
}
