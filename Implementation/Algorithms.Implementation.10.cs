using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int bonAppetit(int n, int k, int b, int[] ar)
    {
        int result = 0;
        if (n <= (int)Math.Pow(10, 5) && n >= 2)
        {
            if (b >= 0 && b <= Sum(ar) && k < ar.Length && k >= 0)
            {
                int charged = 0;
                for (int i = 0; i < ar.Length; i++)
                {
                    if (ar[i] <= (int)Math.Pow(10, 4) && ar[i] >= 0)
                    {
                        if (k != i)
                            charged += ar[i];
                    }
                }

                int pay = charged / 2;
                if (b != pay)
                    result = b - pay;
            }
        }
        return result;
    }

    static int Sum(int[] ar)
    {
        int sum = 0;
        for (int i = 0; i < ar.Length; i++)
        {
            sum += ar[i];
        }
        return sum;
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int b = Convert.ToInt32(Console.ReadLine());
        int result = bonAppetit(n, k, b, ar);
        if (result == 0)
            Console.WriteLine("Bon Appetit");
        else
            Console.WriteLine(result);
        Console.Read();
    }
}
