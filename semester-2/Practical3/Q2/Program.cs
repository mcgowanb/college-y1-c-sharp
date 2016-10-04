using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            String rank, message;

            Console.Write("Please enter a score: ");
            score = Convert.ToInt32(Console.ReadLine());

            if (score >= 80)
                rank = "A";
            else if (score >= 70)
                rank = "B";
            else if (score >= 60)
                rank = "C";
            else if (score >= 50)
                rank = "D";
            else rank = "E";


            switch (rank)
            {
                case "A":
                    message = "Awesome dude";
                    break;
                case "B":
                    message = "Your good dude";
                    break;
                case "C":
                    message = "Some potential here dude";
                    break;
                case "D":
                    message = "back to the training ground dude";
                    break;
                default:
                    message = "don't give up the day job dude";
                    break;

            }

            Console.WriteLine(message);

        }
    }
}
