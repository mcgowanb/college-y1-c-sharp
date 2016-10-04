using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Q4
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number of nuggets: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (canBuy(number)) {
                Console.WriteLine("Valid Selection");
            }
            else Console.WriteLine("Invalid Selection");

        }

        static Boolean canBuy(int number)
        {
            if((number == 6) || (number == 9) || (number == 20))
                return true;
            else return false;
        }
    }
}
