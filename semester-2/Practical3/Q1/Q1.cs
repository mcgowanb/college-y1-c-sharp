using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3
{
    class Q1
    {
        static double cost = 0;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            String product;
            String[] codes = { "ASD", "THF", "TYG", "GHT", "YUR", "UIT", "HIT", "UIP", "RRT", "JJK", "IOP" };
            int qty;

            Console.Write("{0,-30}", "Enter Product Quantity:");
            qty = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0,-30}", "Enter Product Code:");
            product = Console.ReadLine().ToUpper();

            while (!Array.Exists(codes, element => element == product))
            {
                Console.WriteLine("Incorrect product code entered, please try again:");
                Console.Write("{0,-30}", "Enter Product Code:");
                product = Console.ReadLine().ToUpper();
            }

            cost = calculateCost(product, qty);

            Console.WriteLine("The cost for {0} items of code: {1} is: {2:c2}", qty, product, cost);

        }

        private static double calculateCost(string product, int qty)
        {
            switch (product)
            {
                case "ASD":
                    cost = 67.95;
                    break;
                case "THF":
                    cost = 68.90;
                    break;
                case "TYG":
                    cost = 34.95;
                    break;
                case "GHT":
                    cost = 88.9;
                    break;
                case "YUR":
                    cost = 23.8;
                    break;
                case "UIT":
                    cost = 9.9;
                    break;
                case "HIT":
                case "UIP":
                case "RRT":
                case "JJK":
                case "IOP":
                    cost = (double)10;
                    break;

            }
            return cost * qty;
        }
    }
}
