using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Q5
    {
        static void Main(string[] args)
        {
            string password;
            string passwordCheck = "pa55w0rd";
            int counter = 1;
            int attemptLimit = 5;

            Console.Write("{0, -20}", "Enter your password");
            password = Console.ReadLine();

            while ((password != passwordCheck) && (counter < attemptLimit))
            {
                Console.Write("{0,-30}","Incorrect password, please try again ");
                password = Console.ReadLine();
                counter++;
            }

            if (counter == attemptLimit)
            {
                Console.WriteLine("Maximum number of entries exceeded, goodbye ");
            }
            else
            {
                Console.WriteLine("Successfully authenticated ");
            }
            
        }
    }
}
