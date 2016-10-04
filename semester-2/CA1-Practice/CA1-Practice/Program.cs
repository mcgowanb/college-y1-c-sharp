using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1_Practice
{
    class Program
    {
        static int hours, age;
        static string qualification, status;
        static double pay;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                getInputs();
                calculatePay();
                Console.WriteLine("Your pay is {0:c2}", pay);
                Console.Write("Would you like to calculate another: ");
                status = Console.ReadLine().ToUpper();
            }
            while (status != "NO");
         
        }

        static void calculatePay()
        {
            double rate = getHourlyRate();
            rate = checkAgeAndQualification(rate);
            pay = rate * hours;
            if (pay >= 50)
                pay = 50;
        }

        static double checkAgeAndQualification(double rate)
        {
            if (age < 18)
            {
                if (qualification == "NO")
                {
                    rate = rate * .9;
                }
                else rate = rate * .95;
            }
            else {
                if (qualification == "NO")
                {
                    rate = rate * 1.15;
                }
                else rate = rate * 1.2;
            }
            return rate;
        }

        static double getHourlyRate()
        {
            double r;
            switch (hours)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    r = .5;
                    break;

                case 6:
                case 7:
                    r = .75;
                    break;

                case 8:
                case 9:
                case 10:
                    r = 1;
                    break;

                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    r = 2;
                    break;

                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                    r = 2.5;
                    break;

                default:
                    r = 0;
                    break;
            }
            return r;
        }

        static void getInputs()
        {
            Console.Write("Please Enter hours worked\t");
            hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Have you a qualification (yes / no)\t");
            qualification = Console.ReadLine().ToUpper();

            Console.Write("Please Enter your age\t");
            age = Convert.ToInt32(Console.ReadLine());

        }
    }
}
