/**********************************************************
Name        :   Subject.cs
Description :   Class for Subject Objects
Author      :   Brian McGowan  
Date        :   30/11/2015
**********************************************************/

using System;

namespace GradeCalculator
{
    class Subject
    {
        private string name, grade, bonus;
        private int score;

        public override string ToString()
        {
            return String.Format("{0,-30}{1,10}{2,10} {3}", name, grade, score, bonus);
        }

        public string Bonus
        {
            get
            {
                return bonus;
            }

            set
            {
                bonus = value;
            }
        }

        public string Grade
        {
            get
            {
                return grade;
            }

            set
            {
                grade = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Score
        {
            get
            {
                return score;
            }

            set
            {
                score = value;
            }
        }
    }
}
