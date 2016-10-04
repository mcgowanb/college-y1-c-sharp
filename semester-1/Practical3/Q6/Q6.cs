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
            double cash;

            Console.Write("Please enter a cash value: ");
            cash = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0,-50}{1,-10:n3}", "Formatted as number with 3 decimal places:", cash);
            Console.WriteLine("{0,-50}{1,-10:f1}", "Formatted as float with 1 decimal place", cash);
            Console.WriteLine("{0,-50}{1,-10:n10}", "Formatted as number with 10 digits:", cash);
            Console.WriteLine("{0,-50}{1,-10:e2}", "Formatted as scientific notation:", cash);
            Console.WriteLine("{0,-50}{1,-10:g}", "Formatted as general format:", cash);
            Console.WriteLine("{0,-50}{1,-10:c2}", "Formatted as Currency:", cash);


        }
    }
}
