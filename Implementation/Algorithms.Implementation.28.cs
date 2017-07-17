using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        if (n <= 25 && n >= 2 && k <= n && k >= 1 && n % k == 0)
        {
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);
            int temp = 100;
            for (int i = 0; i < c.Length; i = i + k)
            {                
                if (c[i] == 0)
                    temp--;
                else
                    temp = temp - 3;
            }
            Console.WriteLine(temp);
        }
    }
}
