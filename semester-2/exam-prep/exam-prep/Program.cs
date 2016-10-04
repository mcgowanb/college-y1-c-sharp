using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace exam_prep
{
    class Program
    {
        static string[] dist = { "0-9", "10-19", "20-29", "30-39", "40-49", "50-59", "60-69", "70-79", "80-89", "90-100" };
        static string[] scores = new string[10];
        public static void Main(string[] args)
        {
            Console.WriteLine(Reverse("Sligo"));
//            Console.WriteLine(Q2.MonthDays(10));
//            Console.WriteLine(Q2.Repeat("RepeatMe",4));
//            Console.WriteLine(Q2.CanBuyNuggets(6));
//            Console.WriteLine(Q2.Sum(5,10));
//            LoadDataFromFile();
//            PrintScores();
        }

        static string Reverse(string str)
        {
            string Result = "";
            for (int i = str.Length -1; i >= 0; i--)
            {
                Result += str[i];
            }
            return Result;
        }
    

        private static void PrintScores()
        {
            Console.WriteLine("Grade Distribution Report:");    
            for (int i = 0; i < dist.Length; i++)
            {
                Console.WriteLine("{0,-20} {1,-20}", dist[i], scores[i]);
            }
        }

        static void LoadDataFromFile()
        {
            FileStream fs = new FileStream("data.csv", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string lineIn;

            while ((lineIn = sr.ReadLine()) != null)
            {
                string[] elements = lineIn.Split(',');
                AddScoreToList(Convert.ToInt32(elements[1]));
            }
        }

        static void AddScoreToList(int s)
        {
            if (s < 10)
                scores[0] += "#";
            else if (s < 20)
                scores[1] += "#";
            else if (s < 30)
                scores[2] += "#";
            else if (s < 40)
                scores[3] += "#";
            else if (s < 50)
                scores[4] += "#";
            else if (s < 60)
                scores[5] += "#";
            else if (s < 70)
                scores[6] += "#";
            else if (s < 80)
                scores[7] += "#";
            else if (s < 90)
                scores[8] += "#";
            else scores[9] += "#";
        }
    }
}
