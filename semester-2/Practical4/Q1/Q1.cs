using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Q1
    {
        static void Main(string[] args)
        {
            String name = "Brian McGowan";
            int age = 33;
            sayName(name, age);

            int radius = 4;
            double result = circleArea(radius);
            Console.WriteLine("Area of Circle with radius {0} is {1:N2}", radius, result);

            int l = 12;
            int w = 14;
            Console.WriteLine("Area of rectangle of length {0} and width {1} is {2:N2}", l, w, rectangleArea(l, w));


        }

        static void sayName(String fName, int age)
        {
            Console.WriteLine("Your name is {0} and your age is {1}", fName, age);
        }

        static double circleArea(int radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        static double rectangleArea(int length, int width)
        {
            return length * width;
        }
    }
}
