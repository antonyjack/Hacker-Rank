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
                int n = Convert.ToInt32(Console.ReadLine());
                if (n <= 60 && n >= 0)
                {
                    Console.WriteLine(Solve(n));
                }
            }
        }        
    }

    static int Solve(int n)
    {
        int result = 1;
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    result++;
                else
                    result *= 2;
            }
        }
        return result;
    }
}
