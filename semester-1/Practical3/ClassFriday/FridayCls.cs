using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFriday
{
    class FridayCls
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string description;
            double price, discount, due;
            int qty;
            const double DISCOUNT_RATE = .15;

            DateTime date = DateTime.Now;
            Console.WriteLine(date);

            Console.Write("Please enter the item description: ");
            description = Console.ReadLine();

            Console.Write("Please enter the quantity: ");
            qty = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the price per unit: ");
            price = Convert.ToDouble(Console.ReadLine());

            discount = price * DISCOUNT_RATE;

            due = price - discount;

            Console.WriteLine("\n\n\n---------------------------------------");
            Console.WriteLine("Sales Receipt:");
            Console.WriteLine("{0,-30}{1,-10}", "Description:",description);
            Console.WriteLine("{0,-30}{1,-10}", "Quantity:", qty);
            Console.WriteLine("{0,-30}{1,-10:c2}", "Unit Price:", price);
            Console.WriteLine("{0,-30}{1,-10:P2}", "Discount Rate: ", DISCOUNT_RATE);
            Console.WriteLine("{0,-30}{1,-10:c2}", "Discount: ", discount);
            Console.WriteLine("{0,-30}{1,-10:c2}", "Total Due: ", due);
            Console.WriteLine("---------------------------------------");
        }
    }
}
