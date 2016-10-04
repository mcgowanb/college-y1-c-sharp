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
            DeliveryItem item;
            string again;

            do
            {
                repeat = false;
                item = new DeliveryItem();

                Console.Write("{0,-40}", "Enter weight of book: (grams):");
                item.Weight = Convert.ToInt32(Console.ReadLine());

                Console.Write("{0,-40}", "Enter Delivery Type (r/x/sx/ssx):");
                item.DeliveryType = Console.ReadLine();

                Console.WriteLine("Item delivery cost is: {0:c2} for {1} grams using the {2} delivery option", item.cost(), item.Weight, item.DeliveryType);

                Console.Write("Calculate another (y / n)");
                again = Console.ReadLine().ToLower();
            }
            while (again == "y");
        }
    }
}
