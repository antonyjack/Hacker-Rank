using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        string[] days = "1 2000000 23047885".Split(' ');//Console.ReadLine().Split(' ');
        int i = Convert.ToInt32(days[0]);
        int j = Convert.ToInt32(days[1]);
        int k = Convert.ToInt32(days[2]);
        if (i <= (int)Math.Pow(10, 6) * 2 && i > 0 &&
            j <= (int)Math.Pow(10, 6) * 2 && j > 0 &&
            k <= (int)Math.Pow(10, 9) * 2 && k > 0)
        {
            Console.WriteLine(Solve(i, j, k));
        }
    }

    static int Solve(int a, int b, int c)
    {
        int result = 0;
        for (int i = a; i <= b; i++)
        {
            if ((i - Reverse(i)) % c == 0)
                result++;
        }
        return result;
    }

    static int Reverse(int number)
    {
        int num = number;
        int reverse = 0;
        while (num > 0)
        {
            int remainder = num % 10;
            reverse = (reverse * 10) + remainder;
            num = num / 10;
        }
        return reverse;
    }
}
