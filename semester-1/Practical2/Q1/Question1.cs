using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Question1
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            Console.Write("Enter your Name: ");
            name = Console.ReadLine();
            Console.Write("How old are you? ");
            age = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine("Hello " + name + ", and welcome to IT Sligo");
            Console.WriteLine("You are " + age + " years old");
        }
    }
}
