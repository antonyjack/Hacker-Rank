using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int num = 18;//Convert.ToInt32(Console.ReadLine());
        if (num <= 50 && num > 0)
        {
            string[] tokens = "2 5 11 10 1 14 7 3 16 9 8 6 18 12 15 17 13 4".Split(' ');// Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(tokens, Int32.Parse);
            if (a.Length > 0 && a.Length <= 50)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > 0 && a[i] <= a.Length)
                    {
                        var Obj = a.Select((x, n) => new { x, n }).ToArray();
                        var result = Obj.Where(x => x.x == i + 1).FirstOrDefault();
                        var step1 = Obj.Where(x => x.x == result.n + 1).FirstOrDefault();
                        if (result.x == a[step1.x-1])
                            Console.WriteLine(step1.n + 1);
                    }
                }
            }
        }
    }
}
