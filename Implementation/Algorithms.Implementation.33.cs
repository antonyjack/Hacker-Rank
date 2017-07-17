using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Speech;

class Solution
{
    static void Main(String[] args)
    {
        string[] tokens_d1 = "2 7 1014".Split(' '); //Console.ReadLine().Split(' ');
        int d1 = Convert.ToInt32(tokens_d1[0]);
        int m1 = Convert.ToInt32(tokens_d1[1]);
        int y1 = Convert.ToInt32(tokens_d1[2]);
        string[] tokens_d2 = "1 1 1015".Split(' '); //Console.ReadLine().Split(' ');
        int d2 = Convert.ToInt32(tokens_d2[0]);
        int m2 = Convert.ToInt32(tokens_d2[1]);
        int y2 = Convert.ToInt32(tokens_d2[2]);

        int fine = 0;
        if(d1 <= 31 && d1 > 0 && d2 <= 31 && d2 > 0 &&
            m1 <= 12 && m1 > 0 && m2 <= 31 && m2 > 0 &&
            y1 <= 3000 && y1 > 0 && y2 <= 3000 && y2 > 0)
        {            
            DateTime date1 = Convert.ToDateTime(string.Format("{0}-{1}-{2}", m1, d1, y1));
            DateTime date2 = Convert.ToDateTime(string.Format("{0}-{1}-{2}", m2, d2, y2));
            int days = (int)(date1 - date2).TotalDays;
            int month = date1.Month - date2.Month;
            int year = date1.Year - date2.Year;
            if (year > 0)
                fine = 10000;
            else if (month > 0 && year == 0)
                fine = 500 * month;
            else if (days > 0 && month == 0)
                fine = 15 * days;
        }
        Console.WriteLine(fine);
    }
}
