using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int saveThePrisoner(int n, int m, int s)
    { 
        int mod = m % n;
        int result = mod + (s - 1);
        result = result > n ? result % n : result;
        return result == 0 ? n : result;        
    }

    static void Main(String[] args)
    {
        int t = 1;//Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            string[] tokens_n = "13 140874526 1".Split(' ');// Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            int s = Convert.ToInt32(tokens_n[2]);
            int result = saveThePrisoner(n, m, s);
            Console.WriteLine(result);
        }
    }
}
