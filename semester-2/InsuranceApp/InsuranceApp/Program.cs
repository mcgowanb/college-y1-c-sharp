using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp
{
    class Program
    {
        static double phoneCost;
        static int age;
        static string location;
        static int previousClaim;
        static Quote quote;


        static void Main(string[] args)
        {
            getInputs();
        }

        static void getInputs() {
            Console.Write("{0,-30}" , "Enter Age");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0,-30}", "Enter cost of phone: ");
            phoneCost = Convert.ToDouble(Console.ReadLine());

            Console.Write("{0,-30}", "Enter Location:");
            location = Console.ReadLine();

            Console.WriteLine("{0,-30}", "Previous Claim? (1 for yes, 0 for no:");
            previousClaim = Convert.ToInt32(Console.ReadLine());
            quote = new Quote(phoneCost, age, location, previousClaim);
        }
    }
}
