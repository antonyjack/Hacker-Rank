using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int solve(int n, int[] s, int d, int m)
    {
        int result = 0;
        if (n <= 100 && n >= 1)
        {
            if (m >= 1 && m <= 12 && d >= 1 && d <= 31)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (i < n && s[i] <= 5 && s[i] >= 1)
                    {
                        if (i + m <= s.Length)
                        {
                            int chocolate = 0;
                            for (int j = i; j < i + m; j++)
                            {
                                chocolate += s[j];
                            }
                            if (d == chocolate)
                                result++;
                        }
                        else
                            break;
                    }
                }
            }
        }
        return result;
    }

    static void Main(String[] args)
    {
        int n = 1;// Convert.ToInt32(Console.ReadLine());
        string[] s_temp = "4".Split(' ');//Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp, Int32.Parse);
        string[] tokens_d = "4 1".Split(' ');//Console.ReadLine().Split(' ');
        int d = Convert.ToInt32(tokens_d[0]);
        int m = Convert.ToInt32(tokens_d[1]);
        int result = solve(n, s, d, m);
        Console.WriteLine(result);
        Console.Read();
    }
}
