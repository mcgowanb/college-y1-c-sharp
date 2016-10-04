using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "This is a string";
            string x = "1 this is a string";
            Q1(s);

            Console.WriteLine(Q2(s));
            Console.WriteLine(Q2(x));

        }

        static void Q1(string s)
        {
            foreach (char c in s)
            {
                Console.WriteLine(c);
            }
            
        }

        static bool Q2(string s)
        {
            return Char.IsDigit(s, 0);
        }



    }
}
