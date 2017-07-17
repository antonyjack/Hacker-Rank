using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int sockMerchant(int n, int[] ar)
    {
        int result = 0;
        if (n <= 100 && n >= 1)
        {
            Dictionary<int, int> socks = new Dictionary<int, int>();
            for (int i = 0; i < ar.Length; i++)
            {
                if (socks.Keys.Any(x => x == ar[i]))
                {
                    socks[ar[i]] = socks[ar[i]] + 1;
                }
                else
                {
                    socks.Add(ar[i], 1);
                }            
            }
            foreach (var item in socks)
            {
                int rem = item.Value / 2;
                result += rem;
            }
        }
        return result;        
    }

    static void Main(String[] args)
    {
        int n = 9;//Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = "10 20 20 10 10 30 50 10 20".Split(' ');// Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = sockMerchant(n, ar);
        Console.WriteLine(result);
        Console.Read();
    }
}
