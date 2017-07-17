using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int birthdayCakeCandles(int n, int[] ar)
    {
        int max = 0;
        int count = 0;
        for (int i = 0; i < ar.Length; i++)
        {
            if (max == 0)
            {
                max = ar[i];
                count++;
            }
            else
            {
                if (max == ar[i])
                {
                    count++;
                }
                else if (max > ar[i])
                {
                    continue;
                }
                else
                {
                    max = ar[i];
                    count = 1;
                }
            }
        }
        return count;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = birthdayCakeCandles(n, ar);
        Console.WriteLine(result);
    }
}
