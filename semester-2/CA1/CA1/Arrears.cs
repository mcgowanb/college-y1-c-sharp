/****************************************************************************
*   Filename    :   Arrears.cs                                              *
*   Author      :   Brian McGowan / S00165159                               *
*   Date        :   29/02/2016                                              *
*   Type        :   Submission for in-class asessment CA1                   *
****************************************************************************/



using System;
using System.Text;

namespace CA1
{
    class Arrears
    {
        static string releaseType;
        static int lateDays, age;
        static double retailValue;
        const string NEW_RENTAL = "NEW";
        const string REPEAT = "YES";
        const int AGE_LIMIT = 18;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string repeat;
            do
            {
                GetInputs();
                double fine = CalculateFine();
                fine = CheckMaxFine(fine);
                Console.WriteLine("The fine incured for this DVD is {0:c2}", fine);

                Console.Write("{0,-50}", "Do you wish to calcualte another? (yes / no)");
                repeat = Console.ReadLine().ToUpper();
            }
            while (repeat == REPEAT);



        }

        static double CheckMaxFine(double fine)
        {
            if (fine > retailValue)
            {
                return retailValue;
            }

            else
            {
                return fine;
            }

        }

        static double CalculateFine()
        {
            double rate = GetBaseRate();

            if (rate == 0)
            {
                return rate;
            }

            rate = (rate * lateDays);
            rate = AdjustRateBasedOnAgeAndType(rate);
            return rate;

        }

        static double AdjustRateBasedOnAgeAndType(double rate)
        {
            int percentageIncrease;
            if (age < AGE_LIMIT)
            {
                if (releaseType == NEW_RENTAL)
                {
                    percentageIncrease = 10;
                }
                else
                {
                    percentageIncrease = 5;
                }

            }
            else {
                if (releaseType == NEW_RENTAL)
                {
                    percentageIncrease = 12;
                }

                else
                {
                    percentageIncrease = 7;
                }
            }
            double newRate = rate += PercentOfRetailCost(percentageIncrease);
            return newRate;
        }

        static double PercentOfRetailCost(double percent)
        {
            return (retailValue / 100) * percent;
        }

        static double GetBaseRate()
        {
            double rate;
            switch (lateDays)
            {
                case 0:
                    rate = 0;
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                    rate = .5;
                    break;
                case 5:
                case 6:
                case 7:
                    rate = .75;
                    break;
                case 8:
                case 9:
                case 10:
                    rate = 1;
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    rate = 2;
                    break;
                default:
                    rate = 2.5;
                    break;
            }
            return rate;
        }

        static void GetInputs()
        {
            Console.Write("{0,-40}", "Enter Days Late");
            lateDays = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0,-40}", "Enter DVD Type (new / old)");
            releaseType = Console.ReadLine().ToUpper();

            Console.Write("{0,-40}", "Enter DVD Retail Value");
            retailValue = Convert.ToDouble(Console.ReadLine());

            Console.Write("{0,-40}", "Enter Members Age");
            age = Convert.ToInt32(Console.ReadLine());
        }
    }
}
