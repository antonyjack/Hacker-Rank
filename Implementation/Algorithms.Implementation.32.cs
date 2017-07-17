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
        int n = 1;// Convert.ToInt32(Console.ReadLine());
        if (n <= 100 && n > 0)
        {
            for (int i = 0; i < n; i++)
            {
                string[] token = "3 9".Split(' ');//Console.ReadLine().Split(' ');
                int start = Convert.ToInt32(token[0]);
                int end = Convert.ToInt32(token[1]);
                if (start > 0 && end >= start && end <= (int)Math.Pow(10, 9))
                {
                    int result = 0;
                    if (start != end)
                    {
                        var endsqr = Math.Sqrt(end);
                        var startsqr = Math.Sqrt(start);
                        result = (int)endsqr - (start != 1 ? (startsqr % 1 == 0 ? (int)startsqr - 1 : (int)startsqr) : 0);
                    }
                    else
                    {
                        var sqr = Math.Sqrt(start);
                        result = sqr % 1 == 0 ? 1 : 0;
                    }
                    Console.WriteLine(result);
                }
            }
        }
    }
}
