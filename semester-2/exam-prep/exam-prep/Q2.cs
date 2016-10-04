using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_prep
{
    class Q2
    {
        public static string Repeat(string str, int n)
        {
            string msg = "";
            for (int i = 0; i < n; i++)
            {
                msg += str;
            }
            return msg;
        }

        public static bool CanBuyNuggets(int num)
        {
            if ((num == 6) || (num == 9) || (num == 20))
                return true;
            else return false;
        }

        public static int Sum(int n1, int n2)
        {
            int total = 0;
            for (int i = ++n1; i < n2; i++)
            {
                total += i;
            }
            return total;
        }

        public static int MonthDays(int month)
        {
            int days;
            switch (month)
            {
                case 9:
                case 4:
                case 5:
                case 11:
                    days = 30;
                    break;
                case 1:
                case 3:
                case 6:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 2:
                    days = 28;
                    break;
                default:
                    days = 0;
                    break;
            }
            return days;
        }
    }
}
