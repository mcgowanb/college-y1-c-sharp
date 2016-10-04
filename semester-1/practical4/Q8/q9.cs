using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    class q9
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] winningNumbers = new int[3];
            int[] userNumber = new int[3];
            double[] prizeMoney = { 0, 10, 100, 1000 };
            int matches = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0} {1,-15}", "Enter winning number ", i);
                winningNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0} {1,-18}", "Enter user number ", i);
                userNumber[i] = Convert.ToInt32(Console.ReadLine());

                if (Array.Exists(winningNumbers, element => element == userNumber[i]))
                {
                    matches++;
                }
            }
            Console.WriteLine("{0,-40} {1} {2} {3}", "You guessed the following three numbers", userNumber[0], userNumber[1], userNumber[2]);
            Console.WriteLine("{0,-40} {1} {2} {3}", "These are the winning three numbers", winningNumbers[0], winningNumbers[1], winningNumbers[2]);
            Console.WriteLine("{0,-15} {1:c2}", "You have won", prizeMoney[matches]);





        }
    }
}
