using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class Question7
    {
        static void Main(string[] args)
        {
            double cost, tipRate, total, tip;

            Console.Write("Please enter the cost of the meal: ");
            cost = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the tip rate in %: ");
            tipRate = (Convert.ToDouble(Console.ReadLine()) / 100);

            tip = cost * tipRate;
            total = cost + tip;

            Console.WriteLine("Meal Cost:\t$" + cost);
            Console.WriteLine("Tip Rate:\t" + (tipRate * 100) + "%");
            Console.WriteLine("Tip:\t\t$" + tip);
            Console.WriteLine("=====================");
            Console.WriteLine("Total Due:\t$" + total);
        }
    }
}
