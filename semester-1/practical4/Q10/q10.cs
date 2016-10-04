using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    class q10
    {
        static void Main(string[] args)
        {
            string[] locations = { "wonder lake", "wood stock", "big river" };
            string name, location, message;

            Console.Write("{0,-35}", "Please enter your name");
            name = Console.ReadLine();

            Console.Write("{0,-35}", "Please enter place of residence");
            location = Console.ReadLine().ToLower();

            if (Array.Exists(locations, element => element == location))
            {
                message = name + " you are elligible for carpooling";
            }
            else {
                message = "Sorry " +name + " you not elligible for carpooling";
            }

            Console.WriteLine(message);
        }
    }
}
