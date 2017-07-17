using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static string timeConversion(string s)
    {
        // Complete this function
        if (s.Contains("PM") || s.Contains("pm"))
        {
            string[] str = s.Split(':');
            if (Convert.ToInt32(str[0]) != 12)
            {
                int hour = Convert.ToInt32(str[0]) + 12;
                str[0] = (hour >= 24 ? 0 : hour).ToString();
            }
            str[2] = str[2].Substring(0, 2);
            s = string.Join(":", str);

        }
        else if (s.Contains("AM") || s.Contains("am"))
        {
            string[] str = s.Split(':');
            if (Convert.ToInt32(str[0]) >= 12)
            {
                str[0] = "00";
            }
            str[2] = str[2].Substring(0, 2);
            s = string.Join(":", str);
        }
        return s;
    }

    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);
    }
}
