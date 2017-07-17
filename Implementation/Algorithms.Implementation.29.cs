using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        if (t <= 15 && t >= 1)
        {
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0 && (int)Math.Pow(10, 9) > n)
                {
                    int result = 0;
                    foreach (char a in n.ToString().ToCharArray())
                    {
                        int digit = Convert.ToInt32(a.ToString());
                        if (digit != 0)
                            if (n % digit == 0)
                                result++;
                    }
                    Console.WriteLine(result);
                }                
            }
        }
    }
}
