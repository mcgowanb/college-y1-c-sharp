/****************************************************************************
*   Filename    :   CA2.cs                                                  *
*   Author      :   Brian McGowan / S00165159                               *
*   Date        :   29/03/2016                                              *
*   Type        :   Submission for in-class asessment CA1                   *
****************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;

namespace CA2
{
    class CA2
    {
        public static int option;
        public const string ERROR_MESSAGE = "Invalid option selected, please try again";
        public static List<SalesPerson> salesReps;
        public const string LINE_BREAK = "\n\n";
        public const int ONE_STAR = 400, TWO_STAR = 600, THREE_STAR = 700, FOUR_STAR = 900;

        static void Main(string[] args)
        {
            salesReps = FileHandler.LoadFromFile();

            while (option != 4)
            {
                DisplayMenu();
                option = GetMenuInput();
                Console.Clear();
                switch (option)
                {
                    case 1:
                        SalesPersonReport();
                        break;
                    case 2:
                        SalesReport();
                        break;
                    case 3:
                        Search();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine(ERROR_MESSAGE);
                        break;
                }
            }
        }

        //Search for employee
        private static void Search()
        {
            Console.Write("Enter Employee Number: ");
            string term = Console.ReadLine().ToUpper();

            Console.WriteLine(LINE_BREAK);

            try
            {
                SalesPerson sp = new SalesPerson();
                sp = salesReps.Find(x => x.Number == term);
                Console.WriteLine("{0,-15} {1}", "Employee Name:", sp.FullName);
                Console.WriteLine("{0,-15} {1}", "Sales:", sp.Sales);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No match found");
            }
            Console.WriteLine(LINE_BREAK);
        }

        //salesperson report
        private static void SalesPersonReport()
        {
            string tableFormat = "{0,-20}{1,-10}{2,-10}";
            Console.WriteLine(tableFormat, "Employee Name", "Score", "Star Rating");
            int count = 0;
            int total = 0;
            foreach (SalesPerson rep in salesReps)
            {
                Console.WriteLine(tableFormat, rep.InitialSurname, rep.Sales, rep.StarRating);
                total += rep.Sales;
                count++;
            }

            Console.WriteLine("\n{0,-20}{1,-10}", "Average Score:", salesReps.Average(item => item.Sales));
            Console.WriteLine("{0,-20}{1,-10:0.00}", "Standard Deviation", CalculateDeviation());

            SalesPerson topRep = salesReps.OrderByDescending(element => element.Sales).First();

            Console.WriteLine("{0,-20}{1,-10}", "Top Seller:", topRep.Initials);
            Console.WriteLine(LINE_BREAK);
        }

        public static int GetMenuInput()
        {
            int[] options = { 1, 2, 3, 4 };

            String result = Console.ReadLine();
            int value;

            while (!int.TryParse(result, out value))
            {
                Console.WriteLine(ERROR_MESSAGE);
                result = Console.ReadLine();
            }
            return value;
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Please choose from one of the following options");
            Console.WriteLine("=============================");
            Console.WriteLine("1) {0}", "Sales Person Report");
            Console.WriteLine("2) {0}", "Sales Report");
            Console.WriteLine("3) {0}", "Search for Sales person");
            Console.WriteLine("4) {0}", "Exit");
            Console.WriteLine("=============================");
        }

        //standard deviation calculator
        public static double CalculateDeviation()
        {
            double sigmaXSquared = salesReps.Sum(element => Math.Pow(element.Sales, 2));
            double mean = salesReps.Average(element => element.Sales);
            int n = salesReps.Count;
            double mewSquared = Math.Pow(mean, 2);
            double sDev = Math.Sqrt(((sigmaXSquared / n) - mewSquared));
            return sDev;
        }

        //Sales report
        public static void SalesReport()
        {
            int[,] summaries = summariseData();
            string[] titles = { "Under 400", "400 - 599", "600 - 699", "700 - 799", "1000 +" };
            int tCount = 0, tNonIrish = 0, tIrish = 0;


            Console.WriteLine("{0,-20}{1,-10}{2,-10}{3,-10}", "Score Range", "Count", "Non-Irish", "Irish");
            for (int i = 0; i < titles.Length; i++)
            {
                Console.WriteLine("{0,-20}{1,-10}{2,-10}{3,-10}", titles[i], summaries[i, 0], summaries[i, 1], summaries[i, 2]);
                tCount += summaries[i, 0];
                tNonIrish += summaries[i, 1];
                tIrish += summaries[i, 2];
            }
            Console.WriteLine();
            Console.WriteLine("{0,-20}{1,-10}{2,-10}{3,-10}", "Totals:", tCount, tNonIrish, tIrish);
            Console.WriteLine();
        }
        //iterator to summarise data for report
        public static int[,] summariseData()
        {
            int[,] data = new int[5, 3];
            foreach (var rep in salesReps)
            {
                if (rep.Sales < ONE_STAR)
                {
                    data[0, 0]++;
                    if (rep.Nationality.ToUpper() == "IRISH")
                    {
                        data[0, 2]++;
                    }
                    else
                    {
                        data[0, 1]++;
                    }
                }
                else if (rep.Sales < TWO_STAR)
                {
                    data[1, 0]++;
                    if (rep.Nationality.ToUpper() == "IRISH")
                    {
                        data[1, 2]++;
                    }
                    else
                    {
                        data[1, 1]++;
                    }
                }
                else if (rep.Sales < THREE_STAR)
                {
                    data[2, 0]++;
                    if (rep.Nationality.ToUpper() == "IRISH")
                    {
                        data[2, 2]++;
                    }
                    else
                    {
                        data[2, 1]++;
                    }
                }
                else if (rep.Sales < FOUR_STAR)
                {
                    data[3, 0]++;
                    if (rep.Nationality.ToUpper() == "IRISH")
                    {
                        data[3, 2]++;
                    }
                    else
                    {
                        data[3, 1]++;
                    }
                }
                else
                {
                    data[4, 0]++;
                    if (rep.Nationality.ToUpper() == "IRISH")
                    {
                        data[4, 2]++;
                    }
                    else
                    {
                        data[4, 1]++;
                    }
                }
            }
            return data;
        }
    }
}
