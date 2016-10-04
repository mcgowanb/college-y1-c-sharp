using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    class Q10
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string status;
            double salary;

            Console.Write("{0,-40}", "Please enter your status (m = Married, s = Single)");
            status = Console.ReadLine().ToLower();

            Console.Write("{0,-40}", "Please enter your salary");
            salary = Convert.ToDouble(Console.ReadLine());

            Tax tax = new Tax(status, salary);
            Console.WriteLine(tax.calculateTax());  
        }
    }
}
