using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1();
            //Console.WriteLine("\n\n");
            //Q2();
            //Q3();
            Q4();
        }

        static void Q1()
        {
            FileStream fs = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string line;
            int count = 0;

            while ((line = sr.ReadLine()) != null)
            {
                if (++count == 3)
                {
                    Console.WriteLine(line);
                }

            }
            fs.Close();
        }

        static void Q2()
        {
            FileStream fs = new FileStream("dates.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string line;
            string format = "{0,-15}{1,-15}";
            int count = 0, total = 0;

            Console.WriteLine("{0,-15}{1,-15}", "Date","Temperature");
            while((line = sr.ReadLine()) != null)
            {
                string[] elems = line.Split(',');
                Console.WriteLine(format, elems[0], elems[1]);
                count++;
                total += Convert.ToInt32(elems[1]);
            }
            Console.WriteLine();
            Console.WriteLine(format, "Average", (double)total/count);

            fs.Close();
        }

        static void Q3()
        {
            FileStream fs = new FileStream("dates.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string line;
            string format = "{0,-15}{1,-15}";


            string[] rangeTitles = { "< 0", "0 - 9", "10 - 19", "20 - 29", "30+" };

            int[] ranges = new int[rangeTitles.Length];

            while ((line = sr.ReadLine()) != null)
            {
                string[] elems = line.Split(',');
                int value = Convert.ToInt32(elems[1]);
                if (value < 0)
                    ranges[0]++;
                else if (value < 10)
                    ranges[1]++;
                else if (value < 20)
                    ranges[2]++;
                else if (value < 30)
                    ranges[3]++;
                else ranges[4]++;
            }

            Console.WriteLine("{0,-15}{1,-15}", "Range", "No Of Days");

            for (int i = 0; i < ranges.Length; i++)
            {
                Console.WriteLine(format, rangeTitles[i], ranges[i]);
            }
            fs.Close();
        }

        static void Q4()
        {
            FileStream fs = new FileStream("membership.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            string line;
            Console.Write("Please enter a name for the person whom has paid, or -999 to exit: ");
            while((line = Console.ReadLine()) != "-999")
            {
                string lineOut = line;
                Console.WriteLine(lineOut);
                sw.WriteLine(lineOut);
                Console.Write("Please enter a name for the person whom has paid, or -999 to exit: ");
            }


            sw.Close();
            fs.Close();
        }
    }
}
