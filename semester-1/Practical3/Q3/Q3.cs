using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Q3
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            decimal amountDue, amtRecd, dChange;
            int euro, fifty, twenty, ten, five, two, change;

            Console.Write("Please enter the amound due: ");
            amountDue = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Please enter the amount tendered: ");
            amtRecd = Convert.ToDecimal(Console.ReadLine());

            dChange = (amtRecd - amountDue);

            change = (int)(dChange * 100);

            euro = (change / 100);
            change %= 100;

            fifty = (change / 50);
            change %= 50;

            twenty = change / 20;
            change %= 20;

            ten = change / 10;
            change %= 10;

            five = change / 5;
            change %= 5;

            two = change / 2;
            change %= 2;

            Console.WriteLine("Change due is: {0:c2}", dChange);

            Console.WriteLine("{0:0} Euro, {1:0} Fifty, {2:0} Twenty, {3:0} Ten, {4:0} Five, {5:0} Two, {6:0} One", euro, fifty, twenty, ten, five, two, change);
        }
    }
}
