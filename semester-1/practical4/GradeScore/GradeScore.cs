using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeScore
{
    class GradeScore
    {
        static void Main(string[] args)
        {
            int mark;
            char grade;

            Console.Write("{0,-30}", "Please enter a grade:");
            mark = Convert.ToInt32(Console.ReadLine());

            if (mark < 30) grade = 'F';
            else if (mark < 40) grade = 'D';
            else if (mark < 60) grade = 'C';
            else if (mark < 80) grade = 'B';
            else if (mark <= 100) grade = 'A';
            else grade = 'X';

            if (grade == 'X') {
                Console.WriteLine("Invalid grade entered");
            }
            else Console.WriteLine(grade);
        }

    }
}
