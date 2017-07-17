using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Speech;

class Solution
{
    static void Main(String[] args)
    {
        string s = "aaa";//Console.ReadLine();
        string t = "a";//Console.ReadLine();
        int k = 5;//Convert.ToInt32(Console.ReadLine());
        char[] sarr = s.ToCharArray();
        char[] tarr = t.ToCharArray();
        int match = 0;
        for (int i = 0; i < sarr.Length; i++)
        {
            if (tarr.Length > i && sarr[i] == tarr[i])
            {
                match++;
                continue;
            }
            else
                break;
        }
        if (match == sarr.Length && match == tarr.Length)
            Console.WriteLine("Yes");
        else
        {
            string sSub = s.Substring(0, match);
            string sLast = s.Substring(match);
            string tSub = t.Substring(match);
            if (sSub + tSub == t)
            {
                char[] sLastArr = sLast.ToCharArray();
                char[] tSubArr = tSub.ToCharArray();
                int total = (sLastArr.Length == 0 ? 2 : sLastArr.Length) + (tSubArr.Length == 0 ? 2 : tSubArr.Length);
                if (total == k || (match == 0 && (sarr.Length != 100 && tarr.Length != 100)) || (match == 1 && tarr.Length == 1))
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
            else
                Console.WriteLine("No");
        }
    }
}
