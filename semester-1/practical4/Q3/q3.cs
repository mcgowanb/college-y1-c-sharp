using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class q3
    {
        static void Main(string[] args)
        {
            int age;
            const int MAX_AGE = 25;
            const int MIN_AGE = 18;

            Console.Write("{0,-30}","Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());

            if (age < MIN_AGE)
            {
                Console.WriteLine("Sorry, you are too young");
            }
            else if (age > MAX_AGE)
            {
                Console.WriteLine("Sorry, you are too old or young");
            }
            else {
                Console.WriteLine("Congratulations, you qualify for a visa");
            }
        }
    }
}
