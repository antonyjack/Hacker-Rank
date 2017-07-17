using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int days = Convert.ToInt32(Console.ReadLine());
        if (days <= 50 && days > 0)
        {
            Console.WriteLine(Solve(days));
        }
    }

    static int Solve(int n)
    {
        int result = 0;
        int previous = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i == 1)
            {
                result += 5 / 2;
                previous = 5 / 2;
            }
            else
            {
                previous = (3 * previous) / 2;
                result += previous;

            }
        }
        return result;
    }
}
