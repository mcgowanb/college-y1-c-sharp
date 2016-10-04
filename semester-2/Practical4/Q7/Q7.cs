using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class Q7
    {
        static void Main(string[] args)
        {
            int grade;

            Console.Write("Enter Grade Achieved: ");
            grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mark achieved is: {0}", CalculateGrade(grade));
        }


        static String CalculateGrade(int grade)
        {
            String result;
            if (grade > 100 || grade < 0)
                result = "Error";
            else if (grade >= 80 && grade <= 100)
                result = "A";
            else if (grade >= 60)
                result = "B";
            else if (grade >= 40)
                result = "C";
            else
                result = "F";

            return result;

        }




    }
}
