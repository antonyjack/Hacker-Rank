using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        if (t <= 10 && t > 0)
        {
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                if (n <= 1000 && n > 0)
                {
                    if (k <= n && k > 0)
                    {
                        string[] a_temp = Console.ReadLine().Split(' ');
                        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
                        int abs = 0;
                        foreach (var num in a)
                        {
                            if (num < 1)
                                abs++;
                        }
                        if (abs < k)
                            Console.WriteLine("YES");
                        else
                            Console.WriteLine("NO");
                    }
                }
            }
        }
    }
}
