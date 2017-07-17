using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static string solve(int year)
    {
        string result = string.Empty;
        if (year <= 2700 && year >= 1700)
        {
            int programmerday = 256;
            int days = 0;
            for (int i = 1; i <= 12; i++)
            {
                int monthdays = Day(i, year);
                if (days + monthdays < programmerday)
                    days += monthdays;
                else
                {
                    int day = programmerday - days;
                    string month = i < 10 ? string.Format("0{0}", i) : i.ToString();
                    result = string.Format("{0}.{1}.{2}", day, month, year);
                    break;
                }
            }
        }
        return result;
    }

    static int Day(int month, int year)
    {
        int day = 0;
        switch (month)
        {
            case 1:
                day = 31;
                break;
            case 2:
                if (LeapYear(year))
                {
                    day = 29;
                }
                else
                {
                    if (year != 1918)
                        day = 28;
                    else
                        day = 15;
                }
                break;
            case 3:
                day = 31;
                break;
            case 4:
                day = 30;
                break;
            case 5:
                day = 31;
                break;
            case 6:
                day = 30;
                break;
            case 7:
                day = 31;
                break;
            case 8:
                day = 31;
                break;
            case 9:
                day = 30;
                break;
            case 10:
                day = 31;
                break;
            case 11:
                day = 30;
                break;
            case 12:
                day = 31;
                break;
            default:
                break;
        }
        return day;
    }

    static bool LeapYear(int year)
    {
        bool leap = false;
        if (year > 1900)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                leap = true;
        }
        else
        {
            if (year % 4 == 0)
                leap = true;
        }
        return leap;
    }

    static void Main(String[] args)
    {
        int year = Convert.ToInt32(Console.ReadLine());
        string result = solve(year);
        Console.WriteLine(result);
        Console.Read();
    }
}
