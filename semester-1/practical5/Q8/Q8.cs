using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    class Q8
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double value;
            int years = 10;
            const double DEPRECIATION = .2;

            Console.Write("Enter Initial Amount: ");
            value = Convert.ToDouble(Console.ReadLine());

            for (int i = years; i > 0; i--)
            {
                Console.WriteLine("{0} {1,-10} {2,10:c2}", "Starting Value year", i, value);
                value -= value * DEPRECIATION;
            }
        }
    }
}
