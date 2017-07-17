using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int divisibleSumPairs(int n, int k, int[] ar)
    {
        int result = 0;
        if (n <= 100 && n >= 2 && k <= 100 && k >= 1)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] >= 1 && ar[i] <= 100)
                {
                    for (int j = 0; j < ar.Length; j++)
                    {
                        if (i < j)
                            if ((ar[i] + ar[j]) % k == 0)
                                result++;

                    }
                }
            }
        }
        return result;
    }

    static void Main(String[] args)
    {
        string[] tokens_n = "6 3".Split(' ');//Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] ar_temp = "1 3 2 6 1 2".Split(' ');//Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = divisibleSumPairs(n, k, ar);
        Console.WriteLine(result);
        Console.Read();
    }
}
