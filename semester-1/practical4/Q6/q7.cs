﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class q7
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double balance, withdrawlAmount;
            int pin =  5555;

            Console.Write("{0, -40}", "Enter your pin");
            if (Convert.ToInt32(Console.ReadLine()) == pin)
            {
                Console.Write("{0, -40}", "Enter your bank balance");
                balance = Convert.ToDouble(Console.ReadLine());

                Console.Write("{0, -40}", "How much do you want to withdraw");
                withdrawlAmount = Convert.ToDouble(Console.ReadLine());

                if (withdrawlAmount <= balance)
                {
                    balance -= withdrawlAmount;
                    Console.WriteLine("{0:c2} {1} {2:c2}", withdrawlAmount, "has been withdrawn\nNew balance is", balance);
                }
                else
                {
                    Console.WriteLine("{0} {1:c2} {2} {3:c2}", "Insufficent Funds, your balance is", balance, "so you cannot withdraw", withdrawlAmount);
                }
            }
            else {
                Console.WriteLine("Incorrect PIN, please try again");
            }

           
        }
    }
}
