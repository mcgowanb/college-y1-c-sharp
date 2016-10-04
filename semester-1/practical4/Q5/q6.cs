using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class q6
    {
        static void Main(string[] args)
        {
            double loanAmount, salary;
            const int MULTIPLIER = 5;
            const int YEARS_IN_JOB = 2;
            int years;

            Console.Write("{0,-30}", "Enter Loan amount");
            loanAmount = Convert.ToDouble(Console.ReadLine());

            Console.Write("{0,-30}", "Enter Salary");
            salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("{0,-30}", "Enter years in job");
            years = Convert.ToInt32(Console.ReadLine());

            if (years <= YEARS_IN_JOB)
            {
                Console.WriteLine("Sorry , you are not in your current job long enough");
            }

            else if (salary < (loanAmount * MULTIPLIER))
            {
                Console.WriteLine("Sorry , you do not earn enough money");
            }
            else
            {
                Console.WriteLine("Congratulations , you qualify for the loan");
            }
        }
    }
}
