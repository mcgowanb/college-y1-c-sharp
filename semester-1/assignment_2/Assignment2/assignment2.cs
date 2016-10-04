/*
*********************************************************
Name        :   assignment2.cs
Description :   Assignment 2 for C#
Author      :   Brian McGowan  
Date        :   30/11/2015
*********************************************************
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class assignment2
    {
        static void Main(string[] args)
        {
            //declare variables
            string[] subjects = new string[6];
            int iterations = 6;
            string[] grades = new string[6];
            int[] scores = new int[6];
            string[] gradeList = { "H1", "H2", "H3", "H4", "H5", "H6", "H7", "H8", "O1", "O2", "O3", "O4", "O5", "O6", "O7", "O8" };
            string[] bonus = new string[6];
            int totalScore;
            bool repeat;
            double average;

            do
            {
                totalScore = 0;
                average = 0;
                repeat = false;
                //inout with error checking
                for (int i = 0; i < iterations; i++)
                {
                    Console.Write("{0,-40 }", "Please enter subject name:");
                    subjects[i] = Console.ReadLine();
                    do
                    {
                        Console.Write("{0,-40}", "Please enter the grade achieved:");
                        grades[i] = Console.ReadLine().ToUpper();

                        /* process within the input loop, so data can be validated and sums totalled without the
                        need for antoher loop later on  */
                        if (Array.Exists(gradeList, element => element == grades[i]))
                        {
                            totalScore += scores[i] = FindScore(grades[i]);
                            bonus[i] = "";
                            if (grades[i] == "H1")
                            {
                                bonus[i] = "+";
                                totalScore += 25;
                                scores[i] += 25;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error, you have not entered a valid grade.");
                        }
                    }
                    while (!Array.Exists(gradeList, element => element == grades[i]));
                }
                average = (double)totalScore / scores.Length;
                
                
                //output
                Console.WriteLine("Grade Report\n");
                Console.WriteLine("{0,-30}{1,10}{2,10}", "Subject", "Grade", "Points");
                for (int i = 0; i < iterations; i++)
                {
                    Console.WriteLine("{0,-30}{1,10}{2,10} {3}", subjects[i], grades[i], scores[i], bonus[i]);
                }

                Console.WriteLine("\n{0,-40}{1, 10}", "Total Points", totalScore);
                Console.WriteLine("{0,-40}{1,10:g2}\n", "Average points per subject", average);
                
                Console.WriteLine("+ includes 25 bonus points");


                //repeat if necessary, and clear screen
                Console.Write("{0,-40}", "Would you like to calculate again? (y/n)");
                if (Console.ReadLine().ToLower() == "y") {
                    repeat = true;
                    Console.Clear();
                } 
            }
            while (repeat);
        }

        static int FindScore(string grade)
        {
            int score;
            switch (grade)
            {
                case "H1":
                    score = 100;
                    break;
                case "H2":
                    score = 88;
                    break;
                case "H3":
                    score = 77;
                    break;
                case "H4":
                    score = 66;
                    break;
                case "H5":
                case "O1":
                    score = 56;
                    break;
                case "H6":
                case "O2":
                    score = 46;
                    break;
                case "H7":
                case "O3":
                    score = 37;
                    break;
                case "O4":
                    score = 28;
                    break;
                case "O5":
                    score = 20;
                    break;
                case "O6":
                    score = 12;
                    break;
                default:
                    score = 0;
                    break;
            }
            return score;
        }
    }
}
