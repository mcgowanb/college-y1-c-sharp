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
           for (int i = 1; i <= 20; i++)
            {
                if (i == 6 || i == 8) continue;
                Console.WriteLine(i);
            }
    }
}
