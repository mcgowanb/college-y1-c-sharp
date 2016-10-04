/**********************************************************
Name        :   GradeCalculator.cs
Description :   Assignment 2 for C#
Author      :   Brian McGowan  
Date        :   30/11/2015
**********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeCalculator
{
    class GradeCalculator
    {
        static void Main(string[] args)
        {
            //declare variables
            string[] gradeList = { "H1", "H2", "H3", "H4", "H5", "H6", "H7", "H8", "O1", "O2", "O3", "O4", "O5", "O6", "O7", "O8" };
            List<Subject> subjects;
            int totalScore;
            bool repeat;
            double average;

            do
            {
                repeat = false;
                subjects = new List<Subject>();

                //inout with error checking
                for (int i = 1; i <= 6; i++)
                {
                    bool valid = true;
                    Subject sub = new Subject(); //create new object
                    Console.Write("{0,-30}", "Enter subject " + i + ":");
                    sub.Name = Console.ReadLine();
                    while (valid)
                    {
                        Console.Write("{0,-30}", "Enter grade for subject " + i + ":");
                        string grade = Console.ReadLine().ToUpper();
                        // If its a proper value, add to the list
                        if (Array.Exists(gradeList, element => element == grade))
                        {
                            sub.Grade = grade;
                            sub = FindScore(sub);   //convet grade string to score value
                            valid = false;
                        }
                        else
                        {
                            Console.WriteLine("Error, you have not entered a valid grade.");
                            valid = true;
                        }
                    }
                    subjects.Add(sub);      //add to the list
                }
                //output
                Console.WriteLine("Grade Report\n");
                Console.WriteLine("{0,-30}{1,10}{2,10}", "Subject", "Grade", "Points");

                foreach (Subject subject in subjects)
                {
                    Console.WriteLine(subject);
                }

                totalScore = subjects.Sum(item => item.Score);
                average = (double)totalScore / subjects.Count;

                Console.WriteLine("\n{0,-40}{1, 10}", "Total Points", totalScore);

                Console.WriteLine("{0,-40}{1,10:0.##}\n", "Average points per subject", average);

                Console.WriteLine("+ includes 25 bonus points");

                Console.Write("{0,-40}", "Would you like to calculate again? (y/n)");

                if (Console.ReadLine().ToLower() == "y") //clear screen and repeat if yes
                {
                    repeat = true;
                    Console.Clear();
                }
            }
            while (repeat);
        }

        static Subject FindScore(Subject sub)
        {
            bool getBonus = false;
            switch (sub.Grade)
            {
                case "H1":
                    sub.Score = 100;
                    if (sub.Name.ToUpper() == "MATHS")
                    {
                        getBonus = true;
                    }
                    break;
                case "H2":
                    sub.Score = 88;
                    if (sub.Name.ToUpper() == "MATHS")
                    {
                        getBonus = true;
                    }
                    break;
                case "H3":
                    sub.Score = 77;
                    if (sub.Name.ToUpper() == "MATHS")
                    {
                        getBonus = true;
                    }
                    break;
                case "H4":
                    sub.Score = 66;
                    if (sub.Name.ToUpper() == "MATHS")
                    {
                        getBonus = true;
                    }
                    break;
                case "H5":
                case "O1":
                    if ((sub.Name.ToUpper() == "MATHS") & (sub.Grade == "H5"))
                    {
                        getBonus = true;
                    }
                    sub.Score = 56;
                    break;
                case "H6":
                case "O2":
                    if ((sub.Name.ToUpper() == "MATHS") & (sub.Grade == "H6"))
                    {
                        getBonus = true;
                    }
                    sub.Score = 46;
                    break;
                case "H7":
                case "O3":
                    sub.Score = 37;
                    break;
                case "O4":
                    sub.Score = 28;
                    break;
                case "O5":
                    sub.Score = 20;
                    break;
                case "O6":
                    sub.Score = 12;
                    break;
                default:
                    sub.Score = 0;
                    break;
            }

            if (getBonus)
            {
                sub.Score += 25;
                sub.Bonus = "+";
            }

            return sub;
        }
    }
}
