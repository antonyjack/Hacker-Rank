using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int solve(int n, int p)
    {
        int result = 0;
        if (n <= (int)Math.Pow(10, 5) && n >= 1)
        {
            if (n != p && p != 1)
            {
                if (n / 2 < p)
                {
                    if (n % 2 == 0)
                    {                        
                        for (int i = n - 1; i <= n - 1; i = i - 2)
                        {
                            result++;
                            if (p == i || p == i - 1)
                                break;
                        }
                    }
                    else
                    {
                        if (n - 1 != p)
                        {
                            for (int i = n - 2; i <= n - 2; i = i - 2)
                            {
                                result++;
                                if (p == i || p == i - 1)
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 2; i <= n; i = i + 2) 
                    {
                        result++;
                        if (p == i || p == i + 1)
                            break;
                    }
                }
            }
        }
        return result;
    }

    static void Main(String[] args)
    {
        int n = 5;// Convert.ToInt32(Console.ReadLine());
        int p = 4;// Convert.ToInt32(Console.ReadLine());
        int result = solve(n, p);
        Console.WriteLine(result);
        Console.Read();
    }
}
