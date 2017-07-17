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
        string s = "ceebbcb";//Console.ReadLine();
        long n = 817723;//Convert.ToInt64(Console.ReadLine());
        char[] arr = s.ToCharArray();
        char first = 'a';
        if (n <= (long)Math.Pow(10, 12) && n > 0 && arr.Length <= 100 && arr.Length > 0)
        {
            if (arr.Any(x => x == first))
            {
                if (arr.Length == 1)
                    Console.WriteLine(n);
                else
                {

                    var obj = arr.Select((value, index) => new { value, index }).Where(x => x.value == first).ToList();
                    long mod = n % arr.Length;
                    long result = ((n / arr.Length) * obj.Count) + (mod == 0 ? 0 : obj.Where(x => x.index <= (mod - 1)).Count());
                    Console.WriteLine(result);
                }
            }
            else
                Console.WriteLine(0);
        }
    }
}
