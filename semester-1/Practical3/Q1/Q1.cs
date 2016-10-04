using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Q1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
      
            int noOfPayments;
            double rate, currentValue, repaymentValue;

            Console.Write("Please enter the number of payments: ");
            noOfPayments = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the interest rate in percent (%): ");
            rate = (Convert.ToDouble(Console.ReadLine()) / 100);

            Console.Write("Please enter the current value of the loan: ");
            currentValue = Convert.ToDouble(Console.ReadLine());

            repaymentValue = calculateRePayment(rate, currentValue, noOfPayments);

            Console.WriteLine("The monthly repayment is: {0:c2}", repaymentValue);

        }

        static double calculateRePayment(double rate, double cValue, int payments)
        {
            double rePayment;
            rate = rate / 12;
            rePayment = ((rate * cValue) / 1) - (Math.Pow(1 + rate, payments));
            return rePayment;
        }
    }
}
