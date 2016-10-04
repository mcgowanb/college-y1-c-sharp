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
            string password;
            string passwordCheck = "pa55w0rd";

            Console.Write("{0, -20}", "Enter your password");
            password = Console.ReadLine();

            while (password != passwordCheck)
            {
                Console.Write("Incorrect password, please try again ");
                password = Console.ReadLine();
            }
            Console.WriteLine("Successfully authenticated ");
        }
    }
}
