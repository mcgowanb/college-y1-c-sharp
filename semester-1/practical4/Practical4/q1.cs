using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    class q1
    {
        static void Main(string[] args)
        {
            int temp;
            Console.Write("{0,-50}","Please enter the temerature in degrees celsius:");
            temp = Convert.ToInt32(Console.ReadLine());

            if (temp > 250)
            {
                Console.WriteLine("Shut down reactor now!");
            }
            else
            {
                Console.WriteLine("Evertything is spiffing");
            }

        }
    }
}
