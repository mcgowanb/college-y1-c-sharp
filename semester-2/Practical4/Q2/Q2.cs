using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Q2
    {
        static void Main(string[] args)
        {
            String name = "Brian McGowan";
            int age = 33;
            sayName(name, age);
        }

        static void sayName(String fName, int age)
        {
            Console.WriteLine("Your name is {0} and your age is {1}", fName, age);
        }
    }
}
