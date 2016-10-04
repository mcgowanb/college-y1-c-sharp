using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class CA1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            string name;
            DateTime date = DateTime.Now;
            int noOfRooms, roomSize;
            double costPerGallon, labourCost, gallons, hours, totalPaintCost, pVat, lVat, grandTotal, sterling;
            const double LTAX = .1;
            const double HTAX = .2;
            const double RATE_PER_HOUR = 20;
            const double EURO_TO_STERLING = .81;
            const string LINEBREAK = "========================================";
            const string SPACER = "----------------------------------------";

            Console.Write("Please enter the client name:\t ");
            name = Console.ReadLine();

            Console.Write("Please enter the no of rooms:\t ");
            noOfRooms = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please size of room is square feet:\t ");
            roomSize = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter cost of paint per gallon:\t ");
            costPerGallon = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            grandTotal = 0;

            gallons = (double)(noOfRooms * roomSize) / 150;
            hours = gallons * 8;
            totalPaintCost = costPerGallon * gallons;
            grandTotal += totalPaintCost;

            pVat = totalPaintCost * HTAX;
            grandTotal += pVat;

            labourCost = hours * RATE_PER_HOUR;
            grandTotal += labourCost;

            lVat = labourCost * LTAX;
            grandTotal += lVat;

            sterling = grandTotal * EURO_TO_STERLING;

            Console.WriteLine("Job Quote:");
            Console.WriteLine(LINEBREAK);
            Console.WriteLine("{0,-30}{1,10:d}", "Date:", date);
            Console.WriteLine("{0,-30}{1,10}", "Customer Name:", name);
            Console.WriteLine();
            Console.WriteLine("{0,-30}{1,10:0.00}", "Total Number of Gallons:", gallons);
            Console.WriteLine("{0,-30}{1,10:0.00}", "Total number of hours labour:" , hours);

            Console.WriteLine(SPACER);
            Console.WriteLine("{0,-30}{1,10:C2}", "Cost of paint:", totalPaintCost);
            Console.WriteLine("{0,-30}{1,10:c2}", "Paint VAT:", pVat);
            Console.WriteLine("{0,-30 }{1,10:c2}", "Total cost of paint:", totalPaintCost + pVat);
            Console.WriteLine(SPACER);

            Console.WriteLine("{0,-30}{1,10:C2}", "Labour Cost:", labourCost);
            Console.WriteLine("{0,-30}{1,10:c2}", "Labour VAT:", lVat);
            Console.WriteLine("{0,-30 }{1,10:c2}", "Total cost of Labour:", labourCost + lVat);
            Console.WriteLine(SPACER);

            Console.WriteLine("{0,-30}{1,10:c2}", "Total cost of job", grandTotal);
            Console.WriteLine("{0,-30}{1,10:c2}", "Sterling Equivalent", sterling);

        }
    }
}
