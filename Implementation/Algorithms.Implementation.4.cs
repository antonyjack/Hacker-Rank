using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int getTotalX(int[] a, int[] b)
    {
        int X = 0;
        int min = Max(a);
        int max = Min(b);
        for (int i = min; i <= max; i++)
        {
            int tempA = 0;
            foreach (var aa in a)
            {
                if (i % aa == 0)
                    tempA++;
                else
                    break;
            }

            if (a.Length == tempA)
            {
                int tempB = 0;
                foreach (var bb in b)
                {
                    if (bb % i == 0)
                        tempB++;
                    else
                        break;
                }
                if (b.Length == tempB)
                    X++;
            }

        }
        return X;        
    }

    static int Min(int[] a)
    {
        int min = 0;
        foreach (var v in a)
        {
            if (min == 0)
                min = v;
            if (min > v)
                min = v;
        }
        return min;
    }

    static int Max(int[] a)
    {
        int max = 0;
        foreach (var v in a)
        {
            if (max == 0)
                max = v;
            if (max < v)
                max = v;
        }
        return max;
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        string[] b_temp = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(b_temp, Int32.Parse);
        int total = getTotalX(a, b);
        Console.WriteLine(total);
    }
}
