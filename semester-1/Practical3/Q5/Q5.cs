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
            string[] teams = new string[3];
            int[,] scores = new int[3, 5];
            double[] percentages = new double[3];
            //team win loss draw
            for (int i = 0; i < 3; i++)
            {
                int win, loss, draw, potPoints;
                Console.WriteLine("{0,-30}{1,-10}", "Team:", (i + 1));

                Console.Write("{0,-30}", "Please enter a team name");
                teams[i] = Console.ReadLine();

                Console.Write("{0,-30}", "Please enter no of wins");
                win = Convert.ToInt32(Console.ReadLine());
                scores[i, 1] = win;
                scores[i, 4] = win * 3;

                Console.Write("{0,-30}", "Please enter no of losses");
                loss = Convert.ToInt32(Console.ReadLine());
                scores[i, 2] = loss;

                Console.Write("{0,-30}", "Please enter no of draws");
                draw = Convert.ToInt32(Console.ReadLine());
                scores[i, 3] = draw;
                scores[i, 4] += draw;

                scores[i, 0] = (win + loss + draw);
                potPoints = scores[i, 0] * 3;

                percentages[i] = (double)scores[i, 4] / (double)potPoints;

            }

            Console.WriteLine("{0,-15}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10}", "Team", "Played", "Wins", "Losses", "Draws", "Points", "Percentage");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0,-15}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10:p0}", teams[i], scores[i, 0], scores[i, 1], scores[i, 2], scores[i, 3], scores[i, 4], percentages[i]);
            }
        }   
    }
}
